using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace HotKeyManager
{
    public class HotkeyData 
    {
        public String Name { get; set; } = null!;

        public String Description { get; set;} = null!;
        [XmlIgnore]
        public Keys? Combination { get; set; }

        [XmlElement("Combination")]
        public int Combi {
            get => Combination is null ? -1 : ((int)Combination);
            set => Combination = (Keys)value;
        }

    }
}