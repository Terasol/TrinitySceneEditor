using System.Reflection;

namespace TrinitySceneEditor.Search
{
    internal class SearchData
    {
        internal TreeNode TreeNode { get; set; }
        internal object FoundData { get; set; }
        internal PropertyInfo PropertyInfo { get; set; }
        internal EntryFileMapping EntryFileMapping { get; set; }
        public SearchData(TreeNode treeNode, object foundData, PropertyInfo propertyInfo, EntryFileMapping entryFileMapping)
        {
            TreeNode = treeNode;
            FoundData = foundData;
            PropertyInfo = propertyInfo;
            EntryFileMapping = entryFileMapping;
        }
    }
}
