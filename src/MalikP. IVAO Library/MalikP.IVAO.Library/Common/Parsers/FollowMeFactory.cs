using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Models.Clients;

namespace MalikP.IVAO.Library.Common.Parsers
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
