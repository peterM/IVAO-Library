using System.Runtime.Serialization;

namespace MalikP.IVAO.Library.Models.Status
{
    [DataContract]
    public sealed class TafStatusItem : AbstractStatusItem
    {
        private TafStatusItem()
        {
        }

        public TafStatusItem(string value)
            : base("taf0", value)
        {
        }
    }
}
