using System.Runtime.Serialization;

namespace MalikP.IVAO.Library.Models.Status
{
    [DataContract]
    public sealed class GZippedWhazzupStatusItem : AbstractStatusItem
    {
        private GZippedWhazzupStatusItem()
        {
        }

        public GZippedWhazzupStatusItem(string value)
            : base("gzurl0", value)
        {
        }
    }
}
