
namespace TrinitySceneEditor
{
    public class Settings
    {
        public string last_opened_file { get; set; }
        public string last_opened_folder { get; set; }
        public string last_opened_RomFS { get; set; }
        public string last_save_Folder { get; set; }
        public Mode Mode { get; set; }
        public bool Load_Scenes_Recursive { get; set; }
        public Settings()
        {
            last_opened_file = string.Empty;
            last_opened_folder = string.Empty;
            last_opened_RomFS = string.Empty;
            Load_Scenes_Recursive = false;
            last_save_Folder = string.Empty;
        }
    }
    public enum Mode
    {
        Single_File,
        Folder,
        RomFS
    }
}
