
namespace TrinitySceneView
{
    public class Settings
    {
        public string last_opened_file { get; set; }
        public string last_opened_folder { get; set; }
        public string last_opened_RomFS { get; set; }
        public Mode mode { get; set; }
        public Settings() 
        {
            last_opened_file = string.Empty;
            last_opened_folder = string.Empty;
            last_opened_RomFS = string.Empty;
        }
    }
    public enum Mode
    {
        Single_File,
        Folder,
        RomFS
    }
}
