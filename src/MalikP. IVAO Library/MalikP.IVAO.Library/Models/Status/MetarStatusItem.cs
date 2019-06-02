using System.Runtime.Serialization;

namespace MalikP.IVAO.Library.Models.Status
{
    [DataContract]
    public sealed class MetarStatusItem : AbstractStatusItem
    {
        private MetarStatusItem()
        {
        }

        public MetarStatusItem(string value)
            : base("metar0", value)
        {
        }
    }
}
