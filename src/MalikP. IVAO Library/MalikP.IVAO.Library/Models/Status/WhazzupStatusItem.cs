using System.Runtime.Serialization;

namespace MalikP.IVAO.Library.Models.Status
{
    [DataContract]
    public sealed class WhazzupStatusItem : AbstractStatusItem
    {
        private WhazzupStatusItem()
        {
        }

        public WhazzupStatusItem(string value)
            : base("url0", value)
        {
        }
    }
}
