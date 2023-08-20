using System.Runtime.InteropServices;

namespace TrinitySceneEditor
{
    public static class DefaultIcons
    {
        private static Icon? _folderIcon;
        public static Icon FolderLarge => _folderIcon ??= GetStockIcon(SIID_FOLDER, SHGSI_LARGEICON);
        private static Icon? _folderOpenIcon;
        public static Icon FolderOpenLarge => _folderOpenIcon ??= GetStockIcon(SIID_FOLDEROPEN, SHGSI_LARGEICON);
        private static Icon? _FileIcon;
        public static Icon FileLarge => _FileIcon ??= GetStockIcon(SIID_DOCNOASSOC, SHGSI_LARGEICON);

        private static Icon GetStockIcon(uint type, uint size)
        {
            var info = new SHSTOCKICONINFO();
            info.cbSize = (uint)Marshal.SizeOf(info);

            _ = SHGetStockIconInfo(type, SHGSI_ICON | size, ref info);

            var icon = (Icon)Icon.FromHandle(info.hIcon).Clone(); // Get a copy that doesn't use the original handle
            DestroyIcon(info.hIcon); // Clean up native icon to prevent resource leak

            return icon;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SHSTOCKICONINFO
        {
            public uint cbSize;
            public IntPtr hIcon;
            public int iSysIconIndex;
            public int iIcon;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szPath;
        }

        [DllImport("shell32.dll")]
        public static extern int SHGetStockIconInfo(uint siid, uint uFlags, ref SHSTOCKICONINFO psii);

        [DllImport("user32.dll")]
        public static extern bool DestroyIcon(IntPtr handle);

        //https://www.pinvoke.net/default.aspx/Enums/SHSTOCKICONID.html
        private const uint SIID_DOCNOASSOC = 0x0;
        private const uint SIID_FOLDER = 0x3;
        private const uint SIID_FOLDEROPEN = 0x4;
        //Utility
        private const uint SHGSI_ICON = 0x100;
        private const uint SHGSI_LARGEICON = 0x0;
        private const uint SHGSI_SMALLICON = 0x1;
        private const uint SHGSI_SHELLICONSIZE = 0x4;
    }
}
