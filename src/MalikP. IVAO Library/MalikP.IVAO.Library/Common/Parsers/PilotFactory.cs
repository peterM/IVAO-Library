using System;

using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Common.Indexes;
using MalikP.IVAO.Library.Common.Parsers.DataExtractors.Client.Pilot;
using MalikP.IVAO.Library.Models.Clients;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public sealed class PilotFactory : AbstractClientFactory<Pilot>
    {
        private readonly IFlightPlanExtractor _flightPlanExtractor;
        public PilotFactory()
            : base(ClientType.Pilot)
        {
            _flightPlanExtractor = new FlightPlanExtractor();
        }

        public override Pilot Create(string[] rowData)
        {
            FlightPlan flightPlan = CreateFlightPlan(rowData);

            return AssignGeneralData(PilotBuilder.Create(), rowData)
                .WithRating((PilotRating)StringService.IVAO_GetInt(rowData[ClientIndex.Pilot.Version]))
                .WithGroundSpeed(StringService.IVAO_GetInt(rowData[ClientIndex.Pilot.Groundspeed]))
                .WithTransponderCode(rowData[ClientIndex.Pilot.TransponderCode])
                .WithHeading(StringService.IVAO_GetInt(rowData[ClientIndex.Pilot.Heading]))
                .WithIsOnGround(Convert.ToBoolean(Convert.ToInt16(rowData[ClientIndex.Pilot.IsOnGround])))
                .WithFlightSimulator((FlightSimulator)StringService.IVAO_GetInt(rowData[ClientIndex.Pilot.Simulator]))
                .WithPlaneMTL(rowData[ClientIndex.Pilot.PlaneMTL])
                .WithFlightPlan(flightPlan)
                .Build();
        }

        private FlightPlan CreateFlightPlan(string[] rowData)
        {
            return _flightPlanExtractor.ExtractValue(rowData);
        }
    }
}
