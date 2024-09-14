using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotKeyManager
{
    public partial class HotkeyPad : UserControl
    {
        private Keys? combination;
        public Keys? Combination
        {
            get
            {
                var combi = combination;
                combination = null;
                return combi;
            }
        }


        public HotkeyPad()
        {
            InitializeComponent();
            HotkeyTestArea.Text = "";
            HotkeyTestArea.ReadOnly = true;
        }

        public void ClearTestArea()
        {
            HotkeyTestArea.Clear();
        }

        public void SetCurrentHotkey(Keys? combi)
        {
            ClearTestArea();
            HotkeyTestArea.Text = combi?.ToString();
            combination = combi;
        }

        public void SetCurrentCommand(String commandName) {
            ClearTestArea();
            HotkeyTestArea.Text=commandName;
        }
    }
}
