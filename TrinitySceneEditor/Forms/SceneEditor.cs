using System.Reflection;
using Titan.TrinityScene;

namespace TrinitySceneEditor.Forms
{
    public partial class SceneEditor : Form
    {
        SceneFile? OpenScene;

        readonly ToolStripButton _propertyGridSaveButton;
        readonly ToolStripButton _propertyGridOpenSubSceneButton;
        Search? Search;

        public SceneEditor(string Filepath) : this()
        {
            SceneFile? sf = Filemanager.OpenFile(Filepath);
            if (sf != null)
            {
                Open_File(sf);
            }
        }
        public SceneEditor(SceneFile SceneFile) : this()
        {
            Open_File(SceneFile);
        }

        public SceneEditor()
        {
            InitializeComponent();
            _propertyGridSaveButton = new("💾", null, new EventHandler(PropertyGrid_Butto_Save_Click), "Save")
            {
                Visible = false
            };
            _propertyGridOpenSubSceneButton = new("📂", null, new EventHandler(PropertyGrid_Butto_OpenSubScene_Click), "Open")
            {
                Visible = false
            };
            foreach (Control control in propertyGrid1.Controls)
            {
                if (control is ToolStrip toolStrip)
                {
                    toolStrip.Items.Add(_propertyGridSaveButton);
                    toolStrip.Items.Add(_propertyGridOpenSubSceneButton);
                }
            }
        }

        public void SelectNode(TreeNode Node)
        {
            if (sceneView.InvokeRequired)
            {
                Action safeWrite = delegate { SelectNode(Node); };
                sceneView.Invoke(safeWrite);
            }
            else
            {
                sceneView.SelectedNode = Node;
            }
        }

        private void Open_File(SceneFile SceneFile)
        {
            OpenScene = SceneFile;
            if (OpenScene != null)
            {
                sceneView.Nodes.Clear();
                sceneView.Nodes.Add(OpenScene.GetRootTreeNode());
                if (Startup.Settings.Mode == Mode.Single_File)
                    saveTRSOT.Visible = true;
            }
        }

        private void openTRSOT_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            sceneView.Nodes.Clear();
            SceneFile? sf = Filemanager.OpenFile(ofd.FileName);
            if (sf != null)
            {
                Open_File(sf);
            }
        }

        private void closeTRSOT_Click(object sender, EventArgs e)
        {
            if (Startup.Settings.Mode == Mode.Single_File && OpenScene != null)
            {
                Filemanager.CloseFile(OpenScene);
            }
            Close();
        }

        private void saveTRSOT_Click(object sender, EventArgs e)
        {
            if (OpenScene != null)
            {
                Filemanager.SaveFile(OpenScene, CloseFile: false);
            }
        }

        private void sceneView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point ClickPoint = new(e.X, e.Y);
                TreeNode ClickNode = sceneView.GetNodeAt(ClickPoint);
                sceneView.SelectedNode = ClickNode;
                if (ClickNode == null) return;

                Point ScreenPoint = sceneView.PointToScreen(ClickPoint);
                Point FormPoint = this.PointToClient(ScreenPoint);
                sceneContext.Show(this, FormPoint);
            }
        }

        private void sceneView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (sceneView.SelectedNode.Tag is EntryFileMapping entry)
            {
                propertyGrid1.SelectedObject = Deserelize_SceneEntryT(entry.SceneEntryT);
                _propertyGridSaveButton.Visible = true;
                if (propertyGrid1.SelectedObject is SubSceneT)
                    _propertyGridOpenSubSceneButton.Visible = true;
                else
                    _propertyGridOpenSubSceneButton.Visible = false;
                if (propertyGrid1.SelectedObject is trinity_ObjectTemplateT ot)
                {
                    propertyGrid1.SelectedObject = trinity_SceneObjectT.DeserializeFromBinary(ot.ObjectBytes.ToArray());
                    _propertyGridSaveButton.Visible = false;
                }
            }
            else if (sceneView.SelectedNode.Tag is trinity_SceneT)
            {
                propertyGrid1.SelectedObject = sceneView.SelectedNode.Tag;
                _propertyGridSaveButton.Visible = false;
            }
            else
            {
                propertyGrid1.SelectedObject = null;
                _propertyGridSaveButton.Visible = false;
            }
        }

        internal static object? Deserelize_SceneEntryT(SceneEntryT se)
        {
            Type? type = Type.GetType($"Titan.TrinityScene.{se.TypeName}T");
            if (type != null)
            {
                MethodInfo? Deserialize = type.GetMethod("DeserializeFromBinary", BindingFlags.Static | BindingFlags.Public);
                if (Deserialize != null)
                {
                    var a = Deserialize.Invoke(null, new object[] { se.NestedType.ToArray() });
                    return a;
                }
            }
            return null;
        }

        private void PropertyGrid_Butto_OpenSubScene_Click(object? sender, EventArgs e)
        {
            if (sceneView.SelectedNode.Tag is EntryFileMapping entry)
            {
                if (entry != null && OpenScene != null)
                {
                    if (entry.SceneEntryT.TypeName == "SubScene")
                    {
                        var subscene = Deserelize_SceneEntryT(entry.SceneEntryT);
                        if (subscene is SubSceneT)
                        {
                            SceneFile? sf = Filemanager.OpenFile(((SubSceneT)subscene).FilePath, OpenScene);
                            if (sf != null)
                            {
                                SceneEditor sv = new(sf);
                                sv.Show();
                            }
                        }
                    }
                }
            }
        }
        private void PropertyGrid_Butto_Save_Click(object? sender, EventArgs e)
        {
            if (sceneView.SelectedNode != null && OpenScene != null)
            {
                if (sceneView.SelectedNode.Tag is EntryFileMapping entry)
                {
                    Type? type = Type.GetType($"Titan.TrinityScene.{entry.SceneEntryT.TypeName}T");
                    if (type != null)
                    {
                        MethodInfo? Serialize = type.GetMethod("SerializeToBinary", BindingFlags.Instance | BindingFlags.Public);
                        if (Serialize != null)
                        {
                            var output = Serialize.Invoke(propertyGrid1.SelectedObject, null);
                            if (output is byte[] data)
                            {
                                if (!entry.SceneEntryT.NestedType.ToArray().SequenceEqual(data))
                                {
                                    entry.SceneEntryT.NestedType = data.ToList();
                                    entry.SceneFile.isChanged = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Search != null)
            {
                Search.Focus();
            }
            else
            {
                Search = new(sceneView.Nodes[0], this);
                Search.Show();
            }
        }

        private void SceneEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Search != null)
            {
                Search.Close();
            }
        }
    }
}