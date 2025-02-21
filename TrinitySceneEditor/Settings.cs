
using System.Text.Json;

namespace TrinitySceneEditor
{
    public static class Settings
    {
        public static string Last_opened_file { get => file.last_opened_file; set => file.last_opened_file = value; }
        public static string Last_opened_folder { get => file.last_opened_folder; set => file.last_opened_folder = value; }
        public static string Last_opened_RomFS { get => file.last_opened_RomFS; set => file.last_opened_RomFS = value; }
        public static string Last_save_Folder { get => file.last_save_Folder; set => file.last_save_Folder = value; }
        public static Mode Mode { get => file.Mode; set => file.Mode = value; }
        public static bool Load_Scenes_Recursive { get => file.Load_Scenes_Recursive; set => file.Load_Scenes_Recursive = value; }
        public static bool Convert_Rad_to_Degree { get => file.Convert_Rad_to_Degree; set => file.Convert_Rad_to_Degree = value; }

        private static Settings_File file = new();

        public static void LoadSettings()
        {
            if (File.Exists("settings.json"))
            {
                Settings_File? s = JsonSerializer.Deserialize<Settings_File>(File.ReadAllText("settings.json"));
                if (s != null) file = s;
            }
        }

        private static readonly JsonSerializerOptions JsonSerializerOptions = new()
        {
            WriteIndented = true
        };
        public static void SaveSettingsToFile()
        {
            string json = JsonSerializer.Serialize(file, JsonSerializerOptions);
            File.WriteAllText("settings.json", json);
        }
    }
    public class Settings_File
    {
        public string last_opened_file { get; set; }
        public string last_opened_folder { get; set; }
        public string last_opened_RomFS { get; set; }
        public string last_save_Folder { get; set; }
        public Mode Mode { get; set; }
        public bool Load_Scenes_Recursive { get; set; }
        public bool Convert_Rad_to_Degree { get; set; }
        public Settings_File()
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
