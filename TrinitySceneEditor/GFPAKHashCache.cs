
namespace TrinitySceneEditor
{
    public class GFPAKHashCache
    {
        private static Dictionary<ulong, string> HashCacheContent = new Dictionary<ulong, string>();

        private static ulong CurrentVersionHash;
        private static readonly string HashBinaryPath = "GFPAKHashCache.bin";

        public static void LoadHashCache()
        {
            HashCacheContent = new Dictionary<ulong, string>();
            if (File.Exists(HashBinaryPath))
            {
                using (BinaryReader Reader = new BinaryReader(new FileStream(HashBinaryPath, FileMode.Open)))
                {
                    ulong CacheVersionHash = Reader.ReadUInt64();
                    uint Count = Reader.ReadUInt32();
                    for (uint HashIndex = 0; HashIndex < Count; HashIndex++)
                    {
                        ulong HashCode = Reader.ReadUInt64();
                        string HashName = Reader.ReadString();
                        PutHash(HashCode, HashName);
                    }
                }
            }
        }
        public static void ReadFromTxt()
        {
            HashCacheContent = new Dictionary<ulong, string>();
            if (File.Exists("hashes_inside_fd.txt"))
            {
                using (StreamReader streamReader = new StreamReader("hashes_inside_fd.txt"))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        var hashEntry = line.Split(' ');
                        ulong hash;
                        string name;

                        if (hashEntry.Length == 2 && !string.IsNullOrEmpty(hashEntry[0]) && !string.IsNullOrEmpty(hashEntry[1]))
                        {
                            try
                            {
                                hash = Convert.ToUInt64(hashEntry[0], 16);
                                name = hashEntry[1].TrimEnd('\r', '\n');
                            }
                            catch
                            {
                                continue;
                            }

                            TryAddHash(name);
                        }
                    }
                }
            }
        }

        public static void WriteCache()
        {
            using (BinaryWriter writer = new BinaryWriter(new FileStream(HashBinaryPath, FileMode.OpenOrCreate, FileAccess.Write)))
            {
                writer.Write(CurrentVersionHash);
                writer.Write(HashCacheContent.Count);
                foreach (KeyValuePair<ulong, string> Entry in HashCacheContent)
                {
                    writer.Write(Entry.Key);
                    writer.Write(Entry.Value);
                }
            }
        }

        private static void TryAddHash(string str) {
            ulong hash = FNV64A1.Calculate(str);
            if (!HashCacheContent.ContainsKey(hash))
                HashCacheContent.Add(hash, str);
        }

        public static void EnsureHashCache()
        {
            if (HashCacheContent == null)
            {
                HashCacheContent = new Dictionary<ulong, string>();
                LoadHashCache();
            }
        }

        public static string GetHashName(ulong Hash)
        {
            if (HashCacheContent.ContainsKey(Hash))
            {
                return HashCacheContent[Hash];
            }
            return string.Empty;
        }

        public static void PutHash(string Name)
        {
            PutHash(FNV64A1.Calculate(Name), Name);       
        }

        public static void PutHash(ulong Hash, string Name)
        {
            if (!HashCacheContent.ContainsKey(Hash))
            {
                HashCacheContent.Add(Hash, Name);

                if (Name.Contains('/'))
                {
                    string[] HashPaths = Name.Split('/');
                    for (int i = 0; i < HashPaths.Length; i++)
                    {
                        PutHash(HashPaths[i]);
                    }
                }
            }
        }
    }
}
