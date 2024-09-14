using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotKeyManager
{
    internal class HotkeyUncompatibleException : Exception
    {

        public HotkeyUncompatibleException(String configClassName, String manageClassName) :base($"本設定檔的使用類別 {configClassName} 與 受管理類別 {manageClassName} 不相容。"){ 
            
        }
    }
}
