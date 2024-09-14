using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotKeyManager
{
    public class Hotkey
    {
        public KeyEventHandler Handler=null!;

        public readonly HotkeyData Data;
        /***
         * 建立一個空的Hotkey。
         **/
        public Hotkey() { 
            Data = new HotkeyData();
        }

        public Hotkey(HotkeyData data , KeyEventHandler handler) { 
            Handler=handler;
            Data= data;
        
        }
        
        
    }
}
