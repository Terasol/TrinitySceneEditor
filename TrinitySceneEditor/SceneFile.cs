using gfl.scene.fb;
using Titan.TrinityScene;
using TrinitySceneEditor.Forms;

namespace TrinitySceneEditor
{
    public class SceneFile
    {
        public string Filepath = "";
        public string Relative = "";
        public string Extension { get { return Path.GetExtension(Filepath); } }
        public bool isChanged = false;
        public string GameVarieant
        {
            get
            {
                if (Path.GetFileNameWithoutExtension(Filepath).EndsWith("_0")) return "_0";
                else if (Path.GetFileNameWithoutExtension(Filepath).EndsWith("_1")) return "_1";
                else return "";
            }
        }
        public trinity_SceneT SceneData;

        public SceneFile(string Filepath) : this(Filepath, File.ReadAllBytes(Filepath)) { }
        public SceneFile(string Filepath, byte[] Data)
        {
            this.Filepath = Filepath;
            Relative = Filepath;
            if (Settings.Mode == Mode.Folder)
            {
                Filepath = Filepath.Replace("/", "\\");
                Relative = Filepath.Replace(Settings.Last_opened_folder + "\\", "");
            }
            else if (Settings.Mode == Mode.Single_File)
            {
                Relative = Path.GetFileName(Filepath);
            }
            SceneData = trinity_SceneT.DeserializeFromBinary(Data);
        }

        public TreeNode GetRootTreeNode(ContextMenuStrip cms)
        {
            TreeNode root = new(SceneData.SceneName)
            {
                Tag = SceneData,
                ContextMenuStrip = cms
            };
            LoadSubNodes(root, SceneData.SceneObjectList, cms);
            return root;

        }

        private void LoadSubNodes(TreeNode node, List<SceneEntryT> ents, ContextMenuStrip cms)
        {
            foreach (var ent in ents)
            {
                TreeNode newnode = node.Nodes.Add(ent.TypeName);
                newnode.ContextMenuStrip = cms;
                newnode.Tag = new EntryFileMapping(this, ent);
                if (ent.TypeName == "SubScene" && Settings.Load_Scenes_Recursive && Settings.Mode != Mode.Single_File)
                {
                    Titan.TrinityScene.SubSceneT ss = Titan.TrinityScene.SubSceneT.DeserializeFromBinary([.. ent.NestedType]);
                    SceneFile? sub = Filemanager.OpenFile(ss.FilePath, this);
                    if (sub != null)
                    {
                        newnode.Nodes.Add(sub.GetRootTreeNode(cms));
                    }
                }
                if (ent.SubObjects.Count > 0)
                    LoadSubNodes(newnode, ent.SubObjects, cms);
            }
        }

        internal Tuple<bool, string?> LoadTRSOTatTreeNode(TreeNode treeNode, string filepath)
        {
            var of = Filemanager.OpenFile(filepath);
            if (of is SceneFile sf)
            {
                return LoadTRSOTatTreeNode(treeNode, sf.SceneData);
            }
            return new(false, $"could not load {filepath}");
        }

        internal Tuple<bool, string?> LoadTRSOTatTreeNode(TreeNode treeNode, trinity_SceneT trsot)
        {
            if (trsot.SceneObjectList.Count != 1)
            {
                return new(false, "TRSOT root not exactly 1 node");
            }
            if (treeNode.Tag is EntryFileMapping efm)
            {
                if (efm.SceneEntryT.TypeName != "trinity_ObjectTemplate")
                    return new(false, "Node is not a trinity_ObjectTemplate");
                var ot = SceneEditor.Deserelize_SceneEntryT(efm.SceneEntryT);
                if (ot is ObjectTemplateT ott)
                {
                    SceneEntryT se = trsot.SceneObjectList.First();
                    treeNode.Nodes.Clear();

                    LoadSubNodes(treeNode, se.SubObjects, treeNode.ContextMenuStrip);

                    efm.SceneEntryT.SubObjects.Clear();

                    efm.SceneEntryT.SubObjects = se.SubObjects;
                    ott.EntityType = se.TypeName;
                    ott.EntityData = se.NestedType;

                    efm.SceneEntryT.NestedType = [.. ott.SerializeToBinary()];

                    isChanged = true;
                    return new(true, null);
                }
                else
                {
                    return new(false, "could not Parese SceneEntryT to ObjectTemplateT");
                }
            }
            else
            {
                return new(false, "Node Tag is not EntryFileMapping");
            }
        }
    }
}
