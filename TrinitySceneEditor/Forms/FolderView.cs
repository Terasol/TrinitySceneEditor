using System.Text.RegularExpressions;

namespace TrinitySceneEditor.Forms
{
    public partial class FolderView : Form
    {
        readonly string Folder_path = "";
        private readonly Dictionary<string, TreeNode> _SceneFileNodes = new();
        public FolderView()
        {
            InitializeComponent();
            checkBox_load_Recursive.Checked = Startup.Settings.Load_Scenes_Recursive;
            if (Startup.Settings.Mode == Mode.Folder)
            {
                treeView1.Nodes.Add($"Loading Files in {Startup.Settings.last_opened_folder}");
                Folder_path = Startup.Settings.last_opened_folder;
            }
            else if (Startup.Settings.Mode == Mode.RomFS)
            {
                treeView1.Nodes.Add($"Loading Files from RomFS");
                Folder_path = Startup.Settings.last_opened_RomFS;
            }
            ImageList imglist = new()
            {
                ColorDepth = ColorDepth.Depth32Bit,
                Images = { DefaultIcons.FolderLarge.ToBitmap(), DefaultIcons.FileLarge.ToBitmap() }
            };
            treeView1.ImageList = imglist;
            var thread2 = new Thread(Setup_File_List);
            thread2.Start();
        }

        public void Setup_File_List()
        {

            if (Startup.Settings.Mode == Mode.RomFS)
            {
                Filemanager.RomFS = new RomFS(Folder_path);
                string[] files = Filemanager.RomFS.SearchFiles(Scene_File_Extensions());
                CreateNodes(files);
            }
            else if (Startup.Settings.Mode == Mode.Folder)
            {
                Regex reg = Scene_File_Extensions();

                string[] files = Directory.GetFiles(Folder_path, "*", new EnumerationOptions() { RecurseSubdirectories = true })
                                     .Where(path => reg.IsMatch(path))
                                     .ToArray();
                CreateNodes(files);
            }
            else Close();

        }

        private void AddPathToNodes(TreeNodeCollection nodes, string[] path, string full_Path)
        {
            if (path.Length == 0) return;
            int ind = nodes.IndexOfKey(path[0]);
            TreeNode? current_node;
            if (ind == -1)
            {
                current_node = new(path[0])
                {
                    Name = path[0]
                };
                nodes.Add(current_node);
            }
            else
            {
                current_node = nodes[ind];
            }
            if (path.Length == 1)
            {
                current_node.Tag = full_Path;
                current_node.ImageIndex = 1;
                current_node.SelectedImageIndex = 1;
                _SceneFileNodes.Add(full_Path, current_node);
            }
            else
            {
                AddPathToNodes(current_node.Nodes, path.Skip(1).ToArray(), full_Path);
            }
        }

        private void CreateNodes(string[] files)
        {
            TreeNode root_tmp = new();
            Array.Sort(files);
            foreach (string full_path in files)
            {
                string short_path = full_path;
                string[] path = Array.Empty<string>();
                if (Startup.Settings.Mode == Mode.Folder)
                {
                    short_path = full_path.Replace(Folder_path, "");
                    if (short_path.StartsWith("\\")) short_path = short_path.Remove(0, 1);
                    path = short_path.Split("\\");
                }
                else if (Startup.Settings.Mode == Mode.RomFS) path = short_path.Split("/");

                AddPathToNodes(root_tmp.Nodes, path, full_path);
            }
            SetNodes(root_tmp.Nodes);
        }

        public void SetNodes(TreeNodeCollection Nodes)
        {
            if (treeView1.InvokeRequired)
            {
                Action safeWrite = delegate { SetNodes(Nodes); };
                treeView1.Invoke(safeWrite);
            }
            else
            {
                treeView1.Nodes.Clear();
                foreach (TreeNode node in Nodes)
                {
                    treeView1.Nodes.Add(node);
                }
            }
        }

        private void OpenSelectedFile(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Tag != null)
                {
                    if (Startup.Settings.Mode == Mode.RomFS && Startup.Settings.Load_Scenes_Recursive)
                    {
                        if (MessageBox.Show("You are opening a file from RomFS with recursive loading enabled.\r\nThis may take a while to load. Do you want to Continue?", "Load Time Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            return;
                        }
                    }
                    string p = (string)treeView1.SelectedNode.Tag;
                    SceneFile? sf = Filemanager.OpenFile(p);
                    if (sf != null)
                    {
                        SceneEditor sv = new(sf);
                        sv.FormClosed += SceneEditor_FormClosed;
                        sv.Show();
                        Hide();
                    }
                }
            }
        }

        private void Button_Revert_File_Changes_Click(object sender, EventArgs e)
        {
            if (Filemanager.ChangedFiles > 0)
            {
                if (MessageBox.Show($"There are currently {Filemanager.ChangedFiles} changed files.\r\nDo really want to clear them?", "Clearing changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string[] changedfiles = Filemanager.GetFilePathsOfChangedFiles();
                    Filemanager.CloseAllFiles();
                    foreach (string path in changedfiles)
                    {
                        if (_SceneFileNodes.ContainsKey(path))
                        {
                            _SceneFileNodes[path].NodeFont = new Font(treeView1.Font, FontStyle.Regular);
                            _SceneFileNodes[path].Text = _SceneFileNodes[path].Text;

                        }
                    }
                }
            }
        }

        private void SceneEditor_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Show();
            string[] changedfiles = Filemanager.GetFilePathsOfChangedFiles();
            foreach (string path in changedfiles)
            {
                if (_SceneFileNodes.ContainsKey(path))
                {
                    _SceneFileNodes[path].NodeFont = new Font(treeView1.Font, FontStyle.Bold);
                    _SceneFileNodes[path].Text = _SceneFileNodes[path].Text;

                }
            }
        }


        [GeneratedRegex("(\\.trscn|\\.trsot|\\.trsog)$", RegexOptions.IgnoreCase)]
        private static partial Regex Scene_File_Extensions();

        private void checkBox_load_Recursive_CheckedChanged(object sender, EventArgs e)
        {
            Startup.Settings.Load_Scenes_Recursive = checkBox_load_Recursive.Checked;
        }

        private void Button_Save_Changed_Files_Click(object sender, EventArgs e)
        {
            string[] changedfiles = Filemanager.GetFilePathsOfChangedFiles();
            Filemanager.SaveAllOpenFiles();
            foreach (string path in changedfiles)
            {
                if (_SceneFileNodes.ContainsKey(path))
                {
                    _SceneFileNodes[path].NodeFont = new Font(treeView1.Font, FontStyle.Regular);
                    _SceneFileNodes[path].Text = _SceneFileNodes[path].Text;

                }
            }
        }
    }
}
