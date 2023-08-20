
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Web;
using System.Windows.Forms;

namespace TrinitySceneView
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
                string[] files = Filemanager.RomFS.SearchFiles(@"(\.trscn|\.trsog)$");
                List<TreeNode> nodes = new();
                foreach (string file in files)
                {
                    string[] path = file.Split("/");
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
                            n.Tag = file;
                            n.ImageIndex = 1;
                            n.SelectedImageIndex = 1;
                        }
                    }
                }
                SetNodes(nodes.ToArray());
            }
            else if (Folder_path != null)
            {
                SetNodes(Array.Empty<TreeNode>());
            }
            else Close();

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
                    if (Mode == Mode.RomFS)
                    {
                        SceneFile? sf = Filemanager.OpenFile(p);
                        if (sf != null)
                        {
                            SceneEditor sv = new(sf);
                            Hide();
                            sv.FormClosed += (object? sender, FormClosedEventArgs e) => { Show(); };
                            sv.Show();
                        }
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
