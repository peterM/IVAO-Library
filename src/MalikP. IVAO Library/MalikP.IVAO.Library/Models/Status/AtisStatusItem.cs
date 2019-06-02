using System.Runtime.Serialization;

namespace MalikP.IVAO.Library.Models.Status
{
    [DataContract]
    public sealed class AtisStatusItem : AbstractStatusItem
    {
        private AtisStatusItem()
        {
        }

        public AtisStatusItem(string value)
            : base("atis0", value)
        {
        }
    }
}
