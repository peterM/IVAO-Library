using System.Runtime.Serialization;

namespace MalikP.IVAO.Library.Models.Status
{
    [DataContract]
    public sealed class UserStatusItem : AbstractStatusItem
    {
        private UserStatusItem()
        {
        }

        public UserStatusItem(string value)
            : base("user0", value)
        {
        }
    }
}
