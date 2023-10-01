using System.Windows.Forms;

namespace TrinitySceneEditor
{
    static class Filemanager
    {
        private static readonly List<SceneFile> Files = new();

        public static int ChangedFiles => Files.Where(file => file.isChanged).Count();

        public static RomFS? RomFS { get; internal set; }

        public static SceneFile? OpenFile(string path)
        {
            var result = (from SceneFile file in Files where file.Filepath == path select file).FirstOrDefault();

            if (result != null) return result;

            if (RomFS != null && Startup.Settings.Mode == Mode.RomFS)
            {
                byte[] f = RomFS.GetFile(path);
                if (f == null || f.Length == 0) return null;
                SceneFile file = new(path, f);
                Files.Add(file);
                return file;

            }
            else if (File.Exists(path))
            {
                SceneFile file = new(path);
                Files.Add(file);
                return file;
            }
            else return null;
        }
        public static SceneFile? OpenFile(string path, SceneFile sceneFile)
        {
            string new_filename = Path.GetFileNameWithoutExtension(path) + sceneFile.GameVarieant + Path.GetExtension(path);
            string relative_path = Path.Combine(Path.GetDirectoryName(sceneFile.Filepath) ?? "", Path.GetDirectoryName(path) ?? "", new_filename);
            if (RomFS == null)
            {
                string new_path = new Uri(relative_path).AbsolutePath;
                return OpenFile(new_path);
            }
            else
            {
                string new_path = Path.GetFullPath(relative_path).Replace(Environment.CurrentDirectory, "");
                new_path = new_path.Replace("\\", "/");
                if (new_path.StartsWith("/")) new_path = new_path.Remove(0, 1);
                return OpenFile(new_path);
            }
        }

        public static void CloseFile(SceneFile file)
        {
            Files.Remove(file);
        }

        public static void CloseAllFiles()
        {
            Files.Clear();
        }

        public static string[] GetFilePathsOfChangedFiles()
        {
            return Files.Where(file => file.isChanged).Select(file => file.Filepath).ToArray();
        }

        public static void SaveFile(SceneFile SceneFile, string SaveRoot = "", bool CloseFile = true)
        {
            if (SaveRoot == "")
            {
                SaveRoot = GetSavePath();
                if (SaveRoot == "") return;

            }
            string filepath = "";
            filepath = Path.Combine(SaveRoot, SceneFile.Relative);
            string? folder = Path.GetDirectoryName(filepath);
            if (!Path.Exists(folder) && folder != null)
            {
                Directory.CreateDirectory(folder);
            }
            File.WriteAllBytes(filepath, SceneFile.SceneData.SerializeToBinary());

            if (CloseFile)
                Files.Remove(SceneFile);
        }

        private static string GetSavePath()
        {
            FolderBrowserDialog dialog = new()
            {
                UseDescriptionForTitle = true,
                Description = "Select the Folder to Save the Files to"
            };
            if (Path.Exists(Startup.Settings.last_save_Folder))
                dialog.SelectedPath = Startup.Settings.last_save_Folder;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Startup.Settings.last_save_Folder = dialog.SelectedPath;
                return dialog.SelectedPath;
            }
            else return "";
        }

        public static void SaveAllOpenFiles(bool CloseFile = true)
        {
            string SaveRoot = GetSavePath();
            if (SaveRoot != "")
            {
                SceneFile[] f = Files.Where(file => file.isChanged).ToArray();
                foreach (SceneFile file in f)
                {
                    SaveFile(file, SaveRoot, CloseFile);
                }
            }
        }
    }
}
