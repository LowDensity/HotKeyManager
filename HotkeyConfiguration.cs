using System.Text;
using System.Xml.Serialization;

namespace HotKeyManager
{
    public class HotkeyConfiguration
    {
        private HotkeyConfigurationData data = null!;
        public IReadOnlyList<HotkeyData> Hotkeys { get => data.Hotkeys.AsReadOnly(); }
        public bool Initialized { get => data is not null; }
        public String ClassName { get => data.ClassName is null ? "" : data.ClassName; }
        private FileInfo? configFile = null!;
        /// <summary>
        /// 從已存在的檔案中載入快速建設定。
        /// </summary>
        /// <param name="configFile"></param>
        public HotkeyConfiguration(String configFilePath, Type managedClass)
        {
            configFile = new FileInfo(configFilePath);
            Load(configFile);
            if (managedClass.FullName != ClassName) throw new Exception("使用類別名稱與設定檔中紀錄的類別不相符。");
        }

        /// <summary>
        /// 建立一個新的 HotkeyConfiguration物件。
        /// </summary>
        /// <param name="managedClass">這個設定值對應的Windows Form 類別</param>
        public HotkeyConfiguration(Type managedClass)
        {
            if (!managedClass.IsSubclassOf(typeof(Form))) throw new Exception("HotkeyManager 僅支援 Widnows Form.");
            this.configFile = new FileInfo("Hotkeys.xml");
            if (configFile.Exists) Load(configFile);
        }

        public void Initialize()
        {
            this.data = new HotkeyConfigurationData();
            this.data.Hotkeys = new List<HotkeyData>();
        }

        public void SetHotkey(HotkeyData hotkey)
        {
            data.Hotkeys.Add(hotkey);
        }

        public Dictionary<String, Hotkey> GetDitcionary() => data.Hotkeys.ToDictionary(item => item.Name, item => new Hotkey(item, null!));

        public void Save()
        {    
            using Stream configFileStream = this.configFile!.Open(FileMode.Create);
            using var writer = new StreamWriter(configFileStream, Encoding.UTF8);
            configFileStream.Seek(0, SeekOrigin.Begin);
            var xlr = new XmlSerializer(typeof(HotkeyConfigurationData));
            xlr.Serialize(writer, data);
            writer.Close();
        }

        public void Load(FileInfo cfgFile)
        {
            XmlSerializer xlr = new XmlSerializer(typeof(HotkeyConfigurationData));
            using var cfg = cfgFile.OpenRead();
            data = (HotkeyConfigurationData)xlr.Deserialize(cfg)!;
        }

        public void ShowManager()
        {
            using var hkm = new HotKeyManager(this);
            hkm.ShowDialog();
        }





    }
}
