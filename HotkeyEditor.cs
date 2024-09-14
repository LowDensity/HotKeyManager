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
    public partial class HotkeyEditor : UserControl
    {
        public HotkeyEditor()
        {
            InitializeComponent();
        }

        public void SetCombination(Keys combination) { 
            HotkeyCombination.Items.Clear();
            Keys[] allKeys = Enum.GetValues<Keys>();
           foreach (Keys key in allKeys) if ((combination & key) == key) HotkeyCombination.Items.Add(key);
        }

        
    }
}
