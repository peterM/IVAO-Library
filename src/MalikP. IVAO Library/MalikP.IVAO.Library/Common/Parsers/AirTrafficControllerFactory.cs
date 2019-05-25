using System.Collections.Generic;
using System.Linq;

using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Common.Indexes;
using MalikP.IVAO.Library.Models.Clients;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public sealed class AirTrafficControllerFactory : AbstractClientFactory<AirTrafficController>
    {
        public AirTrafficControllerFactory()
            : base(ClientType.ATC)
        {
        }

        public override AirTrafficController Create(string[] rowData)
        {
            if (rowData.Length != 49)
            {
                List<string> data = rowData.ToList();
                data.Insert(ClientIndex.UNUSED1, string.Empty);
                data.Insert(ClientIndex.UNUSED1, string.Empty);
                rowData = data.ToArray();
            }

            return AssignGeneralData(AirTrafficControllerBuilder.Create(), rowData)
                .WithRating((ATCRating)int.Parse(rowData[ClientIndex.ATC.Version]))
                .WithFrequency(rowData[ClientIndex.ATC.Frequency])
                .WithFacilityType((FacilityType)int.Parse(rowData[ClientIndex.ATC.FacilityType]))
                .WithVisualRange(StringService.IVAO_GetInt(rowData[ClientIndex.ATC.VisualRange]))
                .WithATIS(rowData[ClientIndex.ATC.ATIS])
                .WithATISTime(StringService.IVAO_GetDateTime(rowData[ClientIndex.ATC.ATISTime]))
                .Build();
        }
    }
}
