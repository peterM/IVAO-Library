using System.Runtime.Serialization;

namespace MalikP.IVAO.Library.Models.Status
{
    [DataContract]
    public sealed class ShortTafStatusItem : AbstractStatusItem
    {
        private ShortTafStatusItem()
        {
        }

        public ShortTafStatusItem(string value)
            : base("shorttaf0", value)
        {
        }
    }
}
