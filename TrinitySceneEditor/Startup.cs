using System.Text.Json;
using System.Xml.Linq;
using Titan.FileSystem;

namespace TrinitySceneEditor
{
    public partial class Startup : Form
    {
        public static Settings Settings = new();
        public Startup()
        {
            InitializeComponent();
            LoadSettingsFromFile();
            textBox1.TextChanged += TextBox1_TextChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateSettings();
            ProcessSettings();
        }

        private void LoadSettingsFromFile()
        {
            if (File.Exists("settings.json"))
            {
                Settings? s = JsonSerializer.Deserialize<Settings>(File.ReadAllText("settings.json"));
                if (s != null) Settings = s;
            }
            ProcessSettings();
        }

        private void Startup_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettingsToFile();
        }

        private void SaveSettingsToFile()
        {
            JsonSerializerOptions options = new()
            {
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(Settings,options);
            File.WriteAllText("settings.json", json);
        }

        private void UpdateSettings()
        {
            switch (Settings.Mode)
            {
                case Mode.Single_File:
                    Settings.last_opened_file = textBox1.Text;
                    break;
                case Mode.Folder:
                    Settings.last_opened_folder = textBox1.Text;
                    break;
                case Mode.RomFS:
                    Settings.last_opened_RomFS = textBox1.Text;
                    break;
                default:
                    break;
            }
            Settings.Mode = (Mode)comboBox1.SelectedIndex;
        }

        private void ProcessSettings()
        {
            switch (Settings.Mode)
            {
                case Mode.Single_File:
                    Label_File_Path.Text = "Scene File Path:";
                    comboBox1.SelectedIndex = 0;
                    textBox1.Text = Settings.last_opened_file;
                    tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[2].Height = 0;
                    tableLayoutPanel1.RowStyles[3].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[3].Height = 0;
                    button_load.Text = "Open Scene File";
                    if (File.Exists(Settings.last_opened_file))
                    {
                        button_load.Enabled = true;
                    }
                    else
                    {
                        button_load.Enabled = false;
                    }
                    break;
                case Mode.Folder:
                    Label_File_Path.Text = "Folder with Scene Files:";
                    comboBox1.SelectedIndex = 1;
                    textBox1.Text = Settings.last_opened_folder;
                    tableLayoutPanel1.RowStyles[2].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[2].Height = 0;
                    tableLayoutPanel1.RowStyles[3].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.RowStyles[3].Height = 0;
                    button_load.Text = "List all Scene Files in Folder";
                    if (Directory.Exists(Settings.last_opened_folder))
                    {
                        button_load.Enabled = true;
                    }
                    else
                    {
                        button_load.Enabled = false;
                    }
                    break;
                case Mode.RomFS:
                    Label_File_Path.Text = "Path for RomFS Dump:";
                    comboBox1.SelectedIndex = 2;
                    textBox1.Text = Settings.last_opened_RomFS;
                    tableLayoutPanel1.RowStyles[2].SizeType = SizeType.AutoSize;
                    tableLayoutPanel1.RowStyles[3].SizeType = SizeType.AutoSize;
                    bool can_load = true;
                    if (File.Exists("GFPAKHashCache.bin"))
                    {
                        label_GFPAKHashCache_status.Text = "Found";
                        label_GFPAKHashCache_status.ForeColor = Color.Green;
                    }
                    else
                    {
                        label_GFPAKHashCache_status.Text = "Missing!!";
                        label_GFPAKHashCache_status.ForeColor = Color.Red;
                        can_load = false;
                    }
                    if (File.Exists("oo2core_6_win64.dll"))
                    {
                        label_oodle_dll_status.Text = "Found";
                        label_oodle_dll_status.ForeColor = Color.Green;
                    }
                    else
                    {
                        label_oodle_dll_status.Text = "Missing!!";
                        label_oodle_dll_status.ForeColor = Color.Red;
                        can_load = false;
                    }
                    string trpfd = Path.Combine(Settings.last_opened_RomFS, "arc/data.trpfd");
                    string trpfs = Path.Combine(Settings.last_opened_RomFS, "arc/data.trpfs");
                    if (!(File.Exists(trpfs) && File.Exists(trpfd)))
                    {
                        can_load = false;
                    }
                    button_load.Enabled = can_load;
                    button_load.Text = "List all Scene Files in RomFS";
                    break;
                default:
                    break;
            }

        }
        
        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            UpdateSettings();
            ProcessSettings();
        }

        private void Button_select_path_Click(object? sender, EventArgs e)
        {
            switch (Settings.Mode)
            {
                case Mode.Single_File:
                    openFileDialog1.Title = "Select Trinity Scene File";
                    openFileDialog1.Filter = "Trinity Scene (*.trscn;*.trsog)|*.trscn;*.trsog";
                    openFileDialog1.Multiselect = false; openFileDialog1.CheckFileExists = true;
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        textBox1.Text = openFileDialog1.FileName;
                        UpdateSettings();
                        ProcessSettings();
                    }
                    break;
                case Mode.Folder:
                    folderBrowserDialog1.UseDescriptionForTitle = true;
                    folderBrowserDialog1.Description = "Select Folder Containing Trinity Scene Files";
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        textBox1.Text = folderBrowserDialog1.SelectedPath;
                        UpdateSettings();
                        ProcessSettings();
                    }
                    break;
                case Mode.RomFS:
                    folderBrowserDialog1.UseDescriptionForTitle = true;
                    folderBrowserDialog1.Description = "Select your full RomFS Dump";
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        textBox1.Text = folderBrowserDialog1.SelectedPath;
                        UpdateSettings();
                        ProcessSettings();
                    }
                    break;
                default:
                    break;
            }
        }

        private void Button_regenerate_hashcache_Click(object sender, EventArgs e)
        {
            string fileUrl = "https://raw.githubusercontent.com/pkZukan/PokeDocs/main/SV/Hashlists/FileSystem/hashes_inside_fd.txt";
            using var httpClient = new HttpClient();

            HttpResponseMessage response = httpClient.GetAsync(fileUrl).GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                Stream fileStream = response.Content.ReadAsStreamAsync().GetAwaiter().GetResult();
                string filePath = "hashes_inside_fd.txt";
                using var fileOutput = File.Create(filePath);
                fileStream.CopyTo(fileOutput);
                fileOutput.Close();
            }
            else
            {
                var message_text = "Failed to download latest hashes.\n\nManually download the \"hashes_inside_fd.txt\" file into your Trinity folder.\n\nClick OK to copy the URL of the file to your clipboard.";

                if (MessageBox.Show(message_text, "Failed to download", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Clipboard.SetText(fileUrl);
                }
            }
            GFPAKHashCache.ReadFromTxt();
            GFPAKHashCache.WriteCache();
            ProcessSettings();
        }
        

        private void Button_load_Click(object sender, EventArgs e)
        {
            switch (Settings.Mode)
            {
                case Mode.Single_File:
                    SceneEditor sv = new(Settings.last_opened_file);
                    sv.Show();
                    break;
                case Mode.Folder:
                    FolderView fvf = new();
                    fvf.FormClosed += (object? sender, FormClosedEventArgs e) =>{ Show(); };
                    Hide();
                    fvf.Show();
                    break;
                case Mode.RomFS:
                    GFPAKHashCache.LoadHashCache();
                    FolderView fvrfs = new();
                    fvrfs.FormClosed += (object? sender, FormClosedEventArgs e) => { Show(); };
                    Hide();
                    fvrfs.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
