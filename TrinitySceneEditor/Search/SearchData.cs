namespace TrinitySceneEditor.Search
{
    internal class SearchData
    {
        TreeNode TreeNode { get; set; }
        object FoundData { get; set; }
        public SearchData(TreeNode treeNode, object foundData)
        {
            TreeNode = treeNode;
            FoundData = foundData;
        }
    }
}
