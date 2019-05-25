using MalikP.IvaoLibrary.Common.Enums;
using MalikP.IvaoLibrary.Common.Indexes;
using MalikP.IvaoLibrary.Models.Clients;

namespace MalikP.IvaoLibrary.Common.Parsers
{
    public sealed class PilotFactory : AbstractClientFactory<Pilot>
    {
        public PilotFactory()
            : base(ClientType.Pilot)
        {
        }

        public override Pilot Create(string[] rowData)
        {
            return AssignGeneralData(PilotBuilder.Create(), rowData)
                .WithRating((PilotRating)int.Parse(rowData[ClientIndex.All.Rating]))
                .Build();
        }
    }
}
