using MalikP.IvaoLibrary.Common.Enums;
using MalikP.IvaoLibrary.Models.Clients;

namespace MalikP.IvaoLibrary.Common.Parsers
{
    public sealed class FollowMeFactory : AbstractClientFactory<FollowMe>
    {
        public FollowMeFactory()
            : base(ClientType.FollowMeCar)
        {
        }

        public override FollowMe Create(string[] rowData)
        {
            return AssignGeneralData(FollowMeBuilder.Create(), rowData)
                .Build();
        }
    }
}
