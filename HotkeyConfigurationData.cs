using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HotKeyManager
{
    [XmlRoot(ElementName="HotkeyConfiguration")]
    public sealed class HotkeyConfigurationData
    {
        private String? className = null!;

        [XmlElement]
        public String? ClassName
        {
            get => className;
            set
            {
                if (className != null) throw new Exception("不可重複設定 ClassName");
                className = value;
            }
        }

        /// <summary>
        /// 當下正在設定的Hotkey。
        /// </summary>
        [XmlArray]
        public List<HotkeyData> Hotkeys { get; set; } = null!;
    }
}
