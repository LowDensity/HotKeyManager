using System.Text;

namespace HotKeyManager
{

    public partial class HotKeyManager : Form
    {
        private enum HotkeyInputMode
        {
            Input = 1,
            Test = 2
        }

        StringBuilder msgBuilder = new StringBuilder(32768);
        private HotkeyConfiguration config = null!;
        private ManagedHotkey[] ManagedHotkeys = null!;
        private HotkeyInputMode currentInputMode = HotkeyInputMode.Input;
        public HotKeyManager()
        {
            InitializeComponent();
            InitializeDefaultTexts();
        }

        public HotKeyManager(HotkeyConfiguration config) : this()
        {
            this.config = config;
        }

        private void InitializeDefaultTexts()
        {
            HotkeyDescription.Text = "";
        }




        private void HotkeyManagerShown(object sender, EventArgs e)
        {
            if (config is not null)
            {
                SetManagedHotkeys(config.Hotkeys);
            }
            else if (
                MessageBox.Show("尚未載入快速鍵資料，載入測試用快速鍵？", "HotkeyManager", MessageBoxButtons.YesNo)
                ==
                DialogResult.Yes)
            {
                SetManagedHotkeys(
                    [
                         new HotkeyData{ Combination = null, Name = "功能一", Description = "描述描述描述-1" }
                        ,new HotkeyData() { Combination = null, Name = "功能二", Description = "描述描述描述-2" }
                        ,new HotkeyData() { Combination = null, Name = "功能三", Description = "描述描述描述-3" }
                    ]
                   );
            }
        }


        private void SetHotkey_Click(object sender, EventArgs e)
        {
            msgBuilder.Clear();
            var combi = HotkeyTestPad.Combination;
            if (combi is null) msgBuilder.AppendLine("尚未設定任何快速鍵。");
            if (HotkeyList.SelectedItem is null) msgBuilder.AppendLine("未選擇要設定的快速鍵。");
            if (msgBuilder.Length > 0)
            {
                MessageBox.Show(msgBuilder.ToString());
                return;
            }
            var hotkey = (ManagedHotkey)HotkeyList.SelectedItem!;
            hotkey.Combination = combi;
            hotkey.Apply();
            HotkeyList.Items.Clear();
            HotkeyList.Items.AddRange(ManagedHotkeys);
        }
        private void TestMode_Click(object sender, EventArgs e)
        {
            currentInputMode = currentInputMode == HotkeyInputMode.Input ? HotkeyInputMode.Test : HotkeyInputMode.Input;
            switch (currentInputMode)
            {
                case HotkeyInputMode.Input:
                    TestMode.BackColor = SystemColors.Control;
                    break;
                case HotkeyInputMode.Test:
                    TestMode.BackColor = Color.Aquamarine;
                    break;
            }
            HotkeyTestPad.ClearTestArea();
        }


        private void HotkeyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            var hkey = ((ManagedHotkey)lb.SelectedItem);
            HotkeyTestPad.ClearTestArea();
            HotkeyDescription.Text = hkey?.Description;
            HotkeyTestPad.SetCurrentHotkey(hkey?.Combination);

        }

        public void SetManagedHotkeys(IEnumerable<HotkeyData> hotkeys)
        {
            ManagedHotkeys = hotkeys.Select(data => new ManagedHotkey(data)).ToArray();
            HotkeyList.DisplayMember = "DisplayName";
            HotkeyList.Items.Clear();
            HotkeyList.Items.AddRange(ManagedHotkeys);
        }

        private void HotkeyDown(object sender, KeyEventArgs e)
        {
            switch (currentInputMode)
            {
                case HotkeyInputMode.Input:
                    if (HotkeyList.SelectedItem is not null) HotkeyTestPad.SetCurrentHotkey(e.KeyData);
                    break;
                case HotkeyInputMode.Test:
                    String cmdName = ManagedHotkeys.FirstOrDefault(hkey => hkey.Combination == e.KeyData)?.Name!;
                    String msg = String.IsNullOrEmpty(cmdName) ? "未知" : cmdName;
                    HotkeyTestPad.SetCurrentCommand("測試：" + msg);
                    break;
            }
        }

        private void SaveHotkeyConfig_Click(object sender, EventArgs e)
        {
            config.Save();
        }


        private void LoadHotkeyConfig_Click(object sender, EventArgs e)
        {
            if (LoadConfigFile.ShowDialog() != DialogResult.OK) return;
            config.Load(new FileInfo(LoadConfigFile.FileName));
            SetManagedHotkeys(config.Hotkeys);
        }
    }
}
