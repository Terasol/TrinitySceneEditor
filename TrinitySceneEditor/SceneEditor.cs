
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using Titan.TrinityScene;

namespace TrinitySceneEditor
{
    public partial class SceneEditor : Form
    {
        SceneFile? OpenScene;

        ToolStripButton _propertyGridSaveButton;

        public SceneEditor(string Filepath) :this()
        {
            Open_File(Filepath);
        }
        public SceneEditor(SceneFile SceneFile) :this()
        {
            OpenScene = SceneFile;
            sceneView.Nodes.Add(OpenScene.GetRootTreeNode());
            saveTRSOT.Enabled = true;
        }

        public SceneEditor()
        {
            InitializeComponent();
            _propertyGridSaveButton = new("💾", null, new EventHandler(PropertyGrid_Butto_Save_Click), "Save")
            {
                Visible = false
            };
            foreach (Control control in propertyGrid1.Controls)
            {
                if (control is ToolStrip toolStrip)
                {
                    toolStrip.Items.Add(_propertyGridSaveButton);
                }
            }
        }

        private void Open_File(string Filepath)
        {
            OpenScene = Filemanager.OpenFile(Filepath);
            if (OpenScene != null)
            {
                sceneView.Nodes.Add(OpenScene.GetRootTreeNode());
                saveTRSOT.Enabled = true;
            }
        }

        private void openTRSOT_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            sceneView.Nodes.Clear();
            Open_File(ofd.FileName);
        }

        private void closeTRSOT_Click(object sender, EventArgs e)
        {
            OpenScene = null;
            saveTRSOT.Enabled = false;
            _propertyGridSaveButton.Visible = false;
            sceneView.Nodes.Clear();
        }

        private void saveTRSOT_Click(object sender, EventArgs e)
        {
            if (OpenScene != null)
            {
                var sfd = new SaveFileDialog
                {
                    AddExtension = true,
                    DefaultExt = "trscn",
                    Filter = "Trinity Scene (*.trscn;*.trsog)|*.trscn;*.trsog",
                    OverwritePrompt = true
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;

                File.WriteAllBytes(sfd.FileName, OpenScene.SceneData.SerializeToBinary());
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
            if (sceneView.SelectedNode.Tag is SceneEntryT entry)
            {
                propertyGrid1.SelectedObject = Deserelize_SceneEntryT(entry);
                _propertyGridSaveButton.Visible = true;
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

        private static object? Deserelize_SceneEntryT(SceneEntryT se)
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

        private void PropertyGrid_Butto_Save_Click(object? sender, EventArgs e)
        {
            if (sceneView.SelectedNode != null)
            {
                //SceneObjectData_Parsed[sceneView.SelectedNode] = propertyGrid1.SelectedObject;

                //switch (InnerData[sceneView.SelectedNode].TypeName)
                //{
                //    case "SubScene":
                //        InnerData[sceneView.SelectedNode].NestedType = ((SubSceneT)propertyGrid1.SelectedObject).SerializeToBinary().ToList();
                //        break;
                //    case "trinity_SceneObject":
                //        InnerData[sceneView.SelectedNode].NestedType = ((trinity_SceneObjectT)propertyGrid1.SelectedObject).SerializeToBinary().ToList();
                //        break;
                //    case "ti_PokemonModelComponent":
                //        InnerData[sceneView.SelectedNode].NestedType = ((ti_PokemonModelComponentT)propertyGrid1.SelectedObject).SerializeToBinary().ToList();
                //        break;
                //    default:
                //        break;
                //}
            }
        }
        private static TreeNode? Find_first_appearence(TreeNode start, object search_value)
        {
            TreeNode? tn = Search_SceneEntry(start, search_value);
            if (tn != null) return tn;
            else
            {
                foreach (TreeNode node in start.Nodes)
                {
                    TreeNode? tn_ch = Find_first_appearence(node, search_value);
                    if (tn_ch != null) return tn_ch;
                }
            }
            return null;
        }

        private static TreeNode? Search_SceneEntry(TreeNode start, object search_value)
        {
            if (start.Tag is SceneEntryT ent)
            {
                var etrie = Deserelize_SceneEntryT(ent);
                Type? type = Type.GetType($"Titan.TrinityScene.{ent.TypeName}T");
                if (type != null)
                {
                    PropertyInfo[] properties = type.GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        if (property.PropertyType == search_value.GetType() && search_value.GetType() == typeof(string))
                        {
                            string value = (string)(property.GetValue(etrie) ?? "");

                            string search_value_string = (string)search_value;

                            if (value.Contains(search_value_string))
                            {
                                return start;
                            }
                        }
                        else if (property.PropertyType == search_value.GetType() && search_value.GetType() == typeof(int))
                        {
                            int value = (int)(property.GetValue(etrie) ?? 0);

                            int search_value_int = (int)search_value;

                            if (value == search_value_int)
                            {
                                return start;
                            }
                        }
                        else if (property.PropertyType == search_value.GetType() && search_value.GetType() == typeof(float))
                        {
                            float value = (float)(property.GetValue(etrie) ?? 0);

                            float search_value_float = (float)search_value;

                            if (value == search_value_float)
                            {
                                return start;
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}