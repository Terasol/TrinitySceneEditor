using gfl.scene.fb;
using System.Reflection;
using Titan.TrinityScene;

namespace TrinitySceneEditor.Forms
{
    public partial class SceneEditor : Form
    {
        SceneFile? OpenScene;

        readonly ToolStripButton _propertyGridSaveButton;
        readonly ToolStripButton _propertyGridOpenSubSceneButton;
        readonly ToolStripButton _propertyGridswitchOTButton;
        bool show_Objecttemplate = false;
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
                Visible = false,
                ToolTipText = "Save Scene Entry"
            };
            _propertyGridOpenSubSceneButton = new("📂", null, new EventHandler(PropertyGrid_Butto_OpenSubScene_Click), "Open")
            {
                Visible = false,
                ToolTipText = "Open SubScene"
            };
            _propertyGridswitchOTButton = new("⟲", null, new EventHandler(PropertyGrid_Butto_SwitchObjectTemplate_Click), "Switch Object Tempalte")
            {
                Visible = false,
                ToolTipText = "Switch Object Tempalte"
            };
            foreach (Control control in propertyGrid1.Controls)
            {
                if (control is ToolStrip toolStrip)
                {
                    toolStrip.Items.Add(_propertyGridSaveButton);
                    toolStrip.Items.Add(_propertyGridOpenSubSceneButton);
                    toolStrip.Items.Add(_propertyGridswitchOTButton);
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

        private void sceneView_AfterSelect(object? sender, TreeViewEventArgs? e)
        {

            if (sceneView.SelectedNode.Tag is EntryFileMapping entry)
            {
                propertyGrid1.SelectedObject = Deserelize_SceneEntryT(entry.SceneEntryT);
                _propertyGridSaveButton.Visible = true;
                _propertyGridswitchOTButton.Visible = false;
                if (propertyGrid1.SelectedObject is gfl.scene.fb.SubSceneT)
                    _propertyGridOpenSubSceneButton.Visible = true;
                else
                    _propertyGridOpenSubSceneButton.Visible = false;
                if ((propertyGrid1.SelectedObject is ObjectTemplateT ot2))
                {
                    if (!show_Objecttemplate)
                    {
                        propertyGrid1.SelectedObject = Deserelize_SceneEntryT(ot2.EntityType, [.. ot2.EntityData]);
                    }
                    _propertyGridswitchOTButton.Visible = true;
                }
            }
            else if (sceneView.SelectedNode.Tag is trinity_SceneT)
            {
                propertyGrid1.SelectedObject = sceneView.SelectedNode.Tag;
                _propertyGridSaveButton.Visible = false;
                _propertyGridswitchOTButton.Visible = false;
            }
            else
            {
                propertyGrid1.SelectedObject = null;
                _propertyGridSaveButton.Visible = false;
                _propertyGridswitchOTButton.Visible = false;
            }
        }
        private static readonly Dictionary<string, string> mapping = new()
        {
            {"pe_AudioComponent", "gfl.audio.fb.AudioComponentT" },
            {"pe_AudioGeneratorComponent", "gfl.audio.fb.AudioGeneratorComponentT" },
            {"pe_AudioJointComponent", "gfl.audio.fb.AudioJointComponentT" },
            {"pe_AudioPlayerComponent", "gfl.audio.fb.AudioPlayerComponentT" },
            {"pe_InputEventTriggerComponent", "gfl.scene.fb.InputEventTriggerComponentT" },
            {"pe_ParticleAudioComponent", "gfl.audio.fb.ParticleAudioComponentT" },
            {"SubScene", "gfl.scene.fb.SubSceneT" },
            {"trinity_OverrideSensorData", "Titan.TrinityScene.trinity_OverrideSensorDataT" },
        };

        internal static Type? Get_type(string Type_name)
        {
            Type? t = null;
            if (mapping.ContainsKey(Type_name))
            {
                t = Type.GetType(mapping[Type_name]);
            }
            else if (Type_name.StartsWith("trinity_"))
            {
                t = Type.GetType($"gfl.scene.fb.{Type_name.Replace("trinity_", "")}T");
            }
            else
            {
                t = Type.GetType($"Titan.TrinityScene.{Type_name}T");
            }
            return t;
        }

        internal static object? Deserelize_SceneEntryT(SceneEntryT se)
        {
            return Deserelize_SceneEntryT(se.TypeName, [.. se.NestedType]);
        }

        internal static object? Deserelize_SceneEntryT(string type_name, byte[] data)
        {
            Type? type = Get_type(type_name);
            if (type != null)
            {
                MethodInfo? Deserialize = type.GetMethod("DeserializeFromBinary", BindingFlags.Static | BindingFlags.Public);
                if (Deserialize != null)
                {
                    var a = Deserialize.Invoke(null, [data]);
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
                        if (subscene is gfl.scene.fb.SubSceneT)
                        {
                            SceneFile? sf = Filemanager.OpenFile(((gfl.scene.fb.SubSceneT)subscene).Name, OpenScene);
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

        private void PropertyGrid_Butto_SwitchObjectTemplate_Click(object? sender, EventArgs e)
        {
            show_Objecttemplate = !show_Objecttemplate;
            sceneView_AfterSelect(null, null);

        }
        private void PropertyGrid_Butto_Save_Click(object? sender, EventArgs e)
        {
            if (sceneView.SelectedNode != null && OpenScene != null)
            {
                if (sceneView.SelectedNode.Tag is EntryFileMapping entry)
                {
                    Type? type = Get_type(entry.SceneEntryT.TypeName);
                    if (type != null)
                    {
                        if (entry.SceneEntryT.TypeName == "trinity_ObjectTemplate" && !show_Objecttemplate)
                        {
                            ObjectTemplateT? ot = (ObjectTemplateT?)Deserelize_SceneEntryT(entry.SceneEntryT);
                            if (ot != null)
                            {
                                Type? type2 = Get_type(ot.EntityType);

                                if (type2 != null)
                                {
                                    MethodInfo? Serialize = type2.GetMethod("SerializeToBinary", BindingFlags.Instance | BindingFlags.Public);
                                    if (Serialize != null)
                                    {
                                        var output = Serialize.Invoke(propertyGrid1.SelectedObject, null);

                                        if (output is byte[] data)
                                        {
                                            ot.EntityData = [.. data];
                                            entry.SceneEntryT.NestedType = [.. ot.SerializeToBinary()];
                                            entry.SceneFile.isChanged = true;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MethodInfo? Serialize = type.GetMethod("SerializeToBinary", BindingFlags.Instance | BindingFlags.Public);
                            if (Serialize != null)
                            {
                                var output = Serialize.Invoke(propertyGrid1.SelectedObject, null);

                                if (output is byte[] data)
                                {
                                    if (!entry.SceneEntryT.NestedType.ToArray().SequenceEqual(data))
                                    {
                                        entry.SceneEntryT.NestedType = [.. data];
                                        entry.SceneFile.isChanged = true;
                                    }
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