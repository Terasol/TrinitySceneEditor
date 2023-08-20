
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace TrinitySceneEditor
{
    public partial class FolderView : Form
    {
        readonly string Folder_path;
        readonly Mode Mode;
        public FolderView(string Path, Mode Mode)
        {
            InitializeComponent();
            this.Mode = Mode;
            Folder_path = Path;
            if (Mode == Mode.Folder)
            {
                treeView1.Nodes.Add($"Loading Files in {Path}");
            }
            else if(Mode == Mode.RomFS)
            {
                treeView1.Nodes.Add($"Loading Files from RomFS");
            }
            Setup();
        }

        private void Setup()
        {
            ImageList imglist = new()
            {
                ColorDepth = ColorDepth.Depth32Bit,
                Images = { DefaultIcons.FolderLarge.ToBitmap() , DefaultIcons.FileLarge.ToBitmap() }
            };
            treeView1.ImageList = imglist;
            var thread2 = new Thread(Setup_File_List);
            thread2.Start();
        }

        public void Setup_File_List()
        {

            if (Mode == Mode.RomFS)
            {
                Filemanager.RomFS = new RomFS(Folder_path);
                string[] files = Filemanager.RomFS.SearchFiles(Scene_File_Extensions());
                CreateNodes(files);
            }
            else if (Mode == Mode.Folder)
            {
                Regex reg = Scene_File_Extensions();

                string[] files = Directory.GetFiles(Folder_path, "*", new EnumerationOptions() {RecurseSubdirectories = true })
                                     .Where(path => reg.IsMatch(path))
                                     .ToArray();
                CreateNodes(files);
            }
            else Close();

        }

        private void CreateNodes(string[] files)
        {
            List<TreeNode> nodes = new();
            foreach (string full_path in files)
            {
                string short_path = full_path;
                string[] path = Array.Empty<string>();
                if (Mode == Mode.Folder)
                {
                    short_path = full_path.Replace(Folder_path, "");
                    if (short_path.StartsWith("\\")) short_path = short_path.Remove(0,1);
                    path = short_path.Split("\\");
                }
                else if(Mode == Mode.RomFS) path = short_path.Split("/");
                TreeNode? n = nodes.FirstOrDefault(n => n.Text == path[0]);
                if (n == null)
                {
                    n = new TreeNode(path[0])
                    {
                        Name = path[0],
                        ImageIndex = 0,
                        SelectedImageIndex = 0
                    };
                    nodes.Add(n);
                }
                for (int i = 1; i < path.Length; i++)
                {
                    int ind = n.Nodes.IndexOfKey(path[i]);
                    if (ind == -1)
                    {
                        TreeNode nn = new(path[i])
                        {
                            Name = path[i],
                            ImageIndex = 0,
                            SelectedImageIndex = 0
                        };
                        n.Nodes.Add(nn);
                        n = nn;
                    }
                    else
                    {
                        n = n.Nodes[ind];
                    }
                    if (i == path.Length - 1)
                    {
                        n.Tag = full_path;
                        n.ImageIndex = 1;
                        n.SelectedImageIndex = 1;
                    }
                }
            }
            SetNodes(nodes.ToArray());
        }

        public void SetNodes(TreeNode[] Nodes)
        {
            if (treeView1.InvokeRequired)
            {
                Action safeWrite = delegate { SetNodes(Nodes); };
                treeView1.Invoke(safeWrite);
            }
            else
            {
                treeView1.Nodes.Clear();
                treeView1.Nodes.AddRange(Nodes);
            }
        }

        private void TreeView_DoubleClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Tag != null)
                {
                    string p = (string)treeView1.SelectedNode.Tag;
                    SceneFile? sf = Filemanager.OpenFile(p);
                    if (sf != null)
                    {
                        SceneEditor sv = new(sf);
                        Hide();
                        sv.FormClosed += (object? sender, FormClosedEventArgs e) => { Show(); };
                        sv.Show();
                    }
                }
            }
        }

        [GeneratedRegex("(\\.trscn|\\.trsog)$",RegexOptions.IgnoreCase)]
        private static partial Regex Scene_File_Extensions();
    }
}
