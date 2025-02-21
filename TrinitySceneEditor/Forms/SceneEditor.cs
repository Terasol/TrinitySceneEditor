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
        readonly ToolStripMenuItem _contextMenuRemove;
        readonly ToolStripMenuItem _contextMenuLoadTRSOT;

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
            _contextMenuLoadTRSOT = new("Load TRSOT", null, new EventHandler(LoadTRSOTToolStripMenuItem_Click), "Load TRSOT")
            {
                Visible = false,
            };
            _contextMenuRemove = new("Remove", null, new EventHandler(LoadTRSOTToolStripMenuItem_Click), "Remove")
            {
                Enabled = false,
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
            SceneViewContext.Items.AddRange([_contextMenuRemove, _contextMenuLoadTRSOT]);
        }

        private void Open_File(SceneFile SceneFile)
        {
            OpenScene = SceneFile;
            if (OpenScene != null)
            {
                sceneView.Nodes.Clear();
                sceneView.Nodes.Add(OpenScene.GetRootTreeNode(SceneViewContext));
                if (Settings.Mode == Mode.Single_File)
                    saveTRSOT.Visible = true;
            }
        }

        //delegate for Search Window
        public void SelectNode(TreeNode Node)
        {
            if (sceneView.InvokeRequired)
            {
                void safeWrite() { SelectNode(Node); }
                sceneView.Invoke(safeWrite);
            }
            else
            {
                sceneView.SelectedNode = Node;
            }
        }

        private void OpenTRSOT_Click(object sender, EventArgs e)
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

        private void CloseTRSOT_Click(object sender, EventArgs e)
        {
            if (Settings.Mode == Mode.Single_File && OpenScene != null)
            {
                Filemanager.CloseFile(OpenScene);
            }
            Close();
        }

        private void SaveTRSOT_Click(object sender, EventArgs e)
        {
            if (OpenScene != null)
            {
                Filemanager.SaveFile(OpenScene, CloseFile: false);
            }
        }

        private void SceneView_AfterSelect(object? sender, TreeViewEventArgs? e)
        {

            if (sceneView.SelectedNode.Tag is EntryFileMapping entry)
            {
                propertyGrid1.SelectedObject = Deserelize_SceneEntryT(entry.SceneEntryT);
                _propertyGridSaveButton.Visible = true;
                _propertyGridswitchOTButton.Visible = false;
                _contextMenuLoadTRSOT.Visible = false;
                if (propertyGrid1.SelectedObject is gfl.scene.fb.SubSceneT)
                    _propertyGridOpenSubSceneButton.Visible = true;
                else
                    _propertyGridOpenSubSceneButton.Visible = false;
                if (propertyGrid1.SelectedObject is ObjectTemplateT ot2)
                {
                    if (!show_Objecttemplate)
                    {
                        propertyGrid1.SelectedObject = Deserelize_SceneEntryT(ot2.EntityType, [.. ot2.EntityData]);
                    }
                    _propertyGridswitchOTButton.Visible = true;
                    _contextMenuLoadTRSOT.Visible = true;
                }
            }
            else if (sceneView.SelectedNode.Tag is trinity_SceneT)
            {
                propertyGrid1.SelectedObject = sceneView.SelectedNode.Tag;
                _propertyGridSaveButton.Visible = false;
                _propertyGridswitchOTButton.Visible = false;
                _contextMenuLoadTRSOT.Visible = false;
            }
            else
            {
                propertyGrid1.SelectedObject = null;
                _propertyGridSaveButton.Visible = false;
                _propertyGridswitchOTButton.Visible = false;
                _contextMenuLoadTRSOT.Visible = false;
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
            if (mapping.TryGetValue(Type_name, out string? value))
            {
                return Type.GetType(value);
            }
            else if (Type_name.StartsWith("trinity_"))
            {
                return Type.GetType($"gfl.scene.fb.{Type_name.Replace("trinity_", "")}T");
            }
            else
            {
                return Type.GetType($"Titan.TrinityScene.{Type_name}T");
            }
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
                        if (subscene is gfl.scene.fb.SubSceneT subsceneT)
                        {
                            SceneFile? sf = Filemanager.OpenFile(subsceneT.Name, OpenScene);
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
            SceneView_AfterSelect(null, null);

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
                            var ot = Deserelize_SceneEntryT(entry.SceneEntryT);
                            if (ot is ObjectTemplateT ott)
                            {
                                Type? type2 = Get_type(ott.EntityType);

                                if (type2 != null)
                                {
                                    MethodInfo? Serialize = type2.GetMethod("SerializeToBinary", BindingFlags.Instance | BindingFlags.Public);
                                    if (Serialize != null)
                                    {
                                        var output = Serialize.Invoke(propertyGrid1.SelectedObject, null);

                                        if (output is byte[] data)
                                        {
                                            ott.EntityData = [.. data];
                                            entry.SceneEntryT.NestedType = [.. ott.SerializeToBinary()];
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

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
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
            Search?.Close();
        }

        private void DeleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadTRSOTToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (OpenScene == null) return;
            if (sceneView.SelectedNode.Tag is EntryFileMapping entryFileMapping)
            {
                openFileDialog1.Title = "Select Trinity Scene Object Tempalte File";
                openFileDialog1.Filter = "Trinity Scene (*.trsot;)|*.trsot;";
                openFileDialog1.Multiselect = false; openFileDialog1.CheckFileExists = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var res = entryFileMapping.SceneFile.LoadTRSOTatTreeNode(sceneView.SelectedNode, openFileDialog1.FileName);
                    if (!res.Item1)
                    {
                        if (res.Item2 is string s)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    SceneView_AfterSelect(null, null);
                }
            }
        }

        private void SceneView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point ClickPoint = new(e.X, e.Y);
                TreeNode ClickNode = sceneView.GetNodeAt(ClickPoint);
                sceneView.SelectedNode = ClickNode;
                if (ClickNode == null) return;

                Point ScreenPoint = sceneView.PointToScreen(ClickPoint);
                Point FormPoint = this.PointToClient(ScreenPoint);
                SceneViewContext.Show(this, FormPoint);
            }
        }
    }
}