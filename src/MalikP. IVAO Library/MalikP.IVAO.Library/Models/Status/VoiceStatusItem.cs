using System.Runtime.Serialization;

namespace MalikP.IVAO.Library.Models.Status
{
    [DataContract]
    public sealed class VoiceStatusItem : AbstractStatusItem
    {
        private VoiceStatusItem()
        {
        }

        public VoiceStatusItem(string value)
            : base("url1", value)
        {
        }
    }
}
