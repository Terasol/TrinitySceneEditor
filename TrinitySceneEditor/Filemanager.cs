namespace TrinitySceneEditor
{
    static class Filemanager
    {
        private static readonly List<SceneFile> Files = new();

        public static int ChangedFiles => Files.Where(file=> file.isChanged).Count();

        public static RomFS? RomFS { get; internal set; }

        public static SceneFile? OpenFile(string path)
        {
            var result = (from SceneFile file in Files where file.Filepath == path select file).FirstOrDefault();

            if(result != null) return result;

            if(RomFS != null && Startup.Settings.Mode == Mode.RomFS)
            {
                byte[] f = RomFS.GetFile(path);
                if (f == null || f.Length == 0) return null;
                SceneFile file = new(path,f);
                Files.Add(file);
                return file;

            }
            else if (File.Exists(path))
            {
                SceneFile file = new (path);
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
                new_path = new_path.Replace("\\","/");
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
    }
}
