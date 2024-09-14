using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotKeyManager
{
    /// <summary>
    /// 操作設定系統時使用的快速鍵更新類別。
    /// </summary>
    public class ManagedHotkey
    {
        /**
         * 要被設定的快速鍵。
         */
        private HotkeyData srcData;
        /***
         * 新設定的快速鍵。
         */
        private HotkeyData newData;
        private bool saveChanged = false;
        public ManagedHotkey(HotkeyData hotkeyToManage) {
            srcData= hotkeyToManage;
            newData= new HotkeyData() { Name= srcData.Name};
        }

        public String DisplayName => srcData.Name+ "--".PadRight(4).PadLeft(7) + $"{Combination?.ToString()}";

        public String Name { get { return srcData.Name!; } }
        public String Description { 
            get => (newData.Description is null ? srcData : newData).Description!; 
            set => newData.Description = value;
        }

        public Keys? Combination {
            get => (newData.Combination is null ? srcData : newData).Combination;
            set {
                saveChanged = true;
                newData.Combination = value; 
            }
        }

        /// <summary>
        /// 將更新內容回寫到來源物件。回傳這個快速鍵是否有被更新過。
        /// </summary>
        /// <returns>
        /// 如果有被更新：true，沒有任何更新：false。
        /// </returns>
        public bool Apply() {
            if(newData.Combination is null & newData.Description is null) return false;
            if(newData.Combination is not null) srcData.Combination = newData.Combination;
            if(newData.Description is not null) srcData.Description = newData.Description!;
            newData=new HotkeyData() { Name = srcData.Name };
            return true;
        }






    }
}
