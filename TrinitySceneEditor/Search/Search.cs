using System.Reflection;

namespace TrinitySceneEditor.Search
{
    internal class Search
    {
        private static SearchData? Find_first_appearence(TreeNode start, object search_value)
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
        private static SearchData[] Find_all_appearences(TreeNode start, object search_value)
        {
            List<SearchData> found = new();
            SearchData? tn = Search_SceneEntry(start, search_value);
            if (tn != null) found.Add(tn);
            else
            {
                foreach (TreeNode node in start.Nodes)
                {
                    SearchData[] tn_ch = Find_all_appearences(node, search_value);
                    if (tn_ch != null) found.AddRange(tn_ch);
                }
            }
            return found.ToArray();
        }

        private static SearchData? Search_SceneEntry(TreeNode node, object search_value)
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
                                return new(node, value);
                            }
                        }
                        else if (property.PropertyType == search_value.GetType() && search_value.GetType() == typeof(int))
                        {
                            int value = (int)(property.GetValue(etrie) ?? 0);

                            int search_value_int = (int)search_value;

                            if (value == search_value_int)
                            {
                                return new(node, value);
                            }
                        }
                        else if (property.PropertyType == search_value.GetType() && search_value.GetType() == typeof(float))
                        {
                            float value = (float)(property.GetValue(etrie) ?? 0);

                            float search_value_float = (float)search_value;

                            if (value == search_value_float)
                            {
                                return new(node, value);
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}
