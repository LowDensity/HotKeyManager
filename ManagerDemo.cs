using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HotKeyManager
{
    public partial class ManagerDemo : Form
    {
        Random rnd = new Random();
        int curPanelIndex = 0;
        public long HotkeyMessageDuration { get; set; } = 500;
        private Stopwatch displayLasted =null!;
        private Dictionary<String, Hotkey> hotkeyEvents=null!;
        private HotkeyConfiguration hotkeyConfig=null!;
        private Panel[] allPanels=null!;
        private Hotkey[] allHotkeys =null! ;
        public ManagerDemo()
        {
            InitializeComponent();
            InitializeHotkeyConfig();
            InitializeHotkeyEvents();
            SetupDemoContents();
        }

        private void InitializeHotkeyConfig()
        {
            hotkeyConfig = new HotkeyConfiguration(this.GetType());
            if (hotkeyConfig.Initialized) return;
            hotkeyConfig.Initialize();
            hotkeyConfig.SetHotkey(new HotkeyData { Name = "快速鍵一", Description = "隨機變更下方方塊的顏色。", Combination = Keys.Q });
            hotkeyConfig.SetHotkey(new HotkeyData { Name = "快速鍵二", Description = "減少區塊中方塊數量。", Combination = Keys.W });
            hotkeyConfig.SetHotkey(new HotkeyData { Name = "快速鍵三", Description = "增加區塊中方塊數量(最多五個)。", Combination = Keys.E });
            hotkeyConfig.SetHotkey(new HotkeyData { Name = "快速鍵四", Description = "在下方區塊中顯示一個隨機數字。", Combination = Keys.R } );
            hotkeyConfig.Save();
        }

        private void InitializeHotkeyEvents()
        {
            var hokeyDic = hotkeyConfig.GetDitcionary();
            hokeyDic["快速鍵一"].Handler = Hotkey1Test_Click!;
            hokeyDic["快速鍵二"].Handler = Hotkey2Test_Click!;
            hokeyDic["快速鍵三"].Handler = Hotkey3Test_Click!;
            hokeyDic["快速鍵四"].Handler = Hotkey4Test_Click!;
            allHotkeys = hokeyDic.Values.ToArray();

        }

        private void SetupDemoContents()
        {
            displayLasted = new Stopwatch();
            CurrentHotkey.Text = "";
            CurrentInput.Text = "";
            allPanels = [AddBlock1, AddBlock2, AddBlock3, AddBlock4, AddBlock5];
        }

        private void Hotkey1Test_Click(object sender, EventArgs e)
        {
            FillTestSquareWithRandomColor();
        }


        public void FillTestSquareWithRandomColor()
        {
            Hotkey1TestSquare.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

        }

        private void Hotkey2Test_Click(object sender, EventArgs e)
        {
            curPanelIndex--;
            if (curPanelIndex < 0) curPanelIndex = 0;
            for (int pidx = 4; pidx >= curPanelIndex; pidx--)
            {
                var p = allPanels[pidx];
                p.Visible = false;
            }
        }

        private void Hotkey3Test_Click(object sender, EventArgs e)
        {
            curPanelIndex++;
            if (curPanelIndex > 5) curPanelIndex = 5;
            for (int pidx = 0; pidx < curPanelIndex; pidx++)
            {
                var p = allPanels[pidx];
                p.Visible = true;
            }
        }

        private void Hotkey4Test_Click(object sender, EventArgs e)
        {
            RandomNumber.Text = rnd.Next(Int32.MinValue, Int32.MaxValue).ToString();
        }



        private void ManagerDemoKeyDown(object sender, KeyEventArgs e)
        {
            Hotkey? hotkey = allHotkeys.FirstOrDefault(hotkey => hotkey.Data.Combination == e.KeyData);
            if (hotkey is null) {
                CurrentHotkey.Text = "未定義";
                CurrentInput.Text = e.KeyData.ToString();
            } else {
                CurrentHotkey.Text = hotkey.Data.Name;
                CurrentInput.Text = e.KeyData.ToString();
                hotkey.Handler(sender, e);
            }
            e.Handled = true;
            displayLasted.Restart();
        }

        private void ResetHotkeyDisplay(object sender, EventArgs e)
        {
            if (displayLasted.Elapsed.TotalMilliseconds > HotkeyMessageDuration)
            {
                displayLasted.Stop();
                displayLasted.Reset();
                CurrentInput.Text = "";
                CurrentHotkey.Text = "";
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            hotkeyConfig.ShowManager();
        }
    }
}
;