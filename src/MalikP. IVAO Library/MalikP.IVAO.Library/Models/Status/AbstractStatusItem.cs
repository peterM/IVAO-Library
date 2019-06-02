using System.Runtime.Serialization;

namespace MalikP.IVAO.Library.Models.Status
{
    [DataContract]
    public abstract class AbstractStatusItem
    {
        protected AbstractStatusItem(string key, string value)
        {
            Key = key;
            Value = value;
        }

        protected AbstractStatusItem()
        {
        }

        [DataMember]
        public string Key { get; private set; }

        [DataMember]
        public string Value { get; private set; }
    }
}
