using System.Reflection;
using TrinitySceneEditor.Search;

namespace TrinitySceneEditor.Forms
{
    public partial class Search : Form
    {
        TreeNode RootNode;
        SearchData[] Found_Data = Array.Empty<SearchData>();
        SceneEditor SceneEditor { get; set; }
        public Search(TreeNode rootNode, SceneEditor sceneEditor)
        {
            InitializeComponent();
            RootNode = rootNode;
            SceneEditor = sceneEditor;
        }

        private void toolStripButton_Search_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox_SearchValue.Text == "") return;
            dataGridView1.Rows.Clear();
            switch (toolStripComboBox_SearchType.SelectedIndex)
            {
                case 0://string
                    Found_Data = Find_all_appearences(RootNode, toolStripTextBox_SearchValue.Text);
                    break;
                case 1://int
                    if (int.TryParse(toolStripTextBox_SearchValue.Text, out int i))
                        Found_Data = Find_all_appearences(RootNode, i);
                    break;
                case 2://float
                    if (float.TryParse(toolStripTextBox_SearchValue.Text, out float f))
                        Found_Data = Find_all_appearences(RootNode, f);
                    break;
                default:
                    break;
            }
            if (Found_Data.Length == 0) return;
            foreach (SearchData data in Found_Data)
            {
                _ = dataGridView1.Rows.Add(data.PropertyInfo.Name, data.FoundData, Path.GetFileName(data.EntryFileMapping.SceneFile.Filepath));
            }
        }

        internal static SearchData? Find_first_appearence(TreeNode start, object search_value)
        {
            SearchData? tn = Search_SceneEntry(start, search_value);
            if (tn != null) return tn;
            else
            {
                foreach (TreeNode node in start.Nodes)
                {
                    SearchData? tn_ch = Find_first_appearence(node, search_value);
                    if (tn_ch != null) return tn_ch;
                }
            }
            return null;
        }
        internal static SearchData[] Find_all_appearences(TreeNode start, object search_value)
        {
            List<SearchData> found = new();
            SearchData? tn = Search_SceneEntry(start, search_value);
            if (tn != null) found.Add(tn);
            foreach (TreeNode node in start.Nodes)
            {
                SearchData[] tn_ch = Find_all_appearences(node, search_value);
                found.AddRange(tn_ch);
            }
            return found.ToArray();
        }

        internal static SearchData? Search_SceneEntry(TreeNode node, object search_value)
        {
            if (node.Tag is EntryFileMapping ent)
            {
                var etrie = SceneEditor.Deserelize_SceneEntryT(ent.SceneEntryT);
                Type? type = Type.GetType($"Titan.TrinityScene.{ent.SceneEntryT.TypeName}T");
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
                                return new(node, value, property, ent);
                            }
                        }
                        else if (property.PropertyType == search_value.GetType() && search_value.GetType() == typeof(int))
                        {
                            int value = (int)(property.GetValue(etrie) ?? 0);

                            int search_value_int = (int)search_value;

                            if (value == search_value_int)
                            {
                                return new(node, value, property, ent);
                            }
                        }
                        else if (property.PropertyType == search_value.GetType() && search_value.GetType() == typeof(float))
                        {
                            float value = (float)(property.GetValue(etrie) ?? 0);

                            float search_value_float = (float)search_value;

                            if (value == search_value_float)
                            {
                                return new(node, value, property, ent);
                            }
                        }
                    }
                }
            }
            return null;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SceneEditor.SelectNode(Found_Data[e.RowIndex].TreeNode);
        }
    }
}
