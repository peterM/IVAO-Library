using MalikP.IvaoLibrary.Common.Enums;
using MalikP.IvaoLibrary.Common.Indexes;
using MalikP.IvaoLibrary.Models.Clients;

namespace MalikP.IvaoLibrary.Common.Parsers
{
    public sealed class AirTrafficControllerFactory : AbstractClientFactory<AirTrafficController>
    {
        public AirTrafficControllerFactory()
            : base(ClientType.ATC)
        {
        }

        public override AirTrafficController Create(string[] rowData)
        {
            return AssignGeneralData(AirTrafficControllerBuilder.Create(), rowData)
                .WithRating((ATCRating)int.Parse(rowData[ClientIndex.All.Rating]))
                .WithFrequency(rowData[ClientIndex.ATC.Frequency])
                .WithFacilityType((FacilityType)int.Parse(rowData[ClientIndex.ATC.FacilityType]))
                .WithVisualRange(rowData[ClientIndex.ATC.VisualRange])
                .WithATIS(rowData[ClientIndex.ATC.ATIS])
                .WithATISTime(rowData[ClientIndex.ATC.ATISTime])
                .Build();
        }
    }
}
