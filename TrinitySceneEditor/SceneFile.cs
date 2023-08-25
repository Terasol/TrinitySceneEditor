﻿using Titan.TrinityScene;

namespace TrinitySceneEditor
{
    public class SceneFile
    {
        public string Filepath = "";
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

        public SceneFile(string Filepath)
        {
            this.Filepath = Filepath;
            SceneData = trinity_SceneT.DeserializeFromBinary(File.ReadAllBytes(Filepath));
        }
        public SceneFile(string Filepath, byte[] Data)
        {
            this.Filepath = Filepath;
            SceneData = trinity_SceneT.DeserializeFromBinary(Data);
        }

        public TreeNode GetRootTreeNode()
        {
            TreeNode root = new(SceneData.SceneName)
            {
                Tag = SceneData
            };
            LoadSubNodes(root, SceneData.SceneObjectList);
            return root;

        }

        private void LoadSubNodes(TreeNode node, List<SceneEntryT> ents)
        {
            foreach (var ent in ents)
            {
                TreeNode newnode = node.Nodes.Add(ent.TypeName);
                newnode.Tag = ent;
                if (ent.SubObjects.Count > 0)
                    LoadSubNodes(newnode, ent.SubObjects);
            }
        }
    }
}
