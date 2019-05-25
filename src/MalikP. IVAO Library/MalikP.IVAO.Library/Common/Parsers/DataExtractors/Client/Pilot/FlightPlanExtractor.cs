using MalikP.IVAO.Library.Common.Annotation;
using MalikP.IVAO.Library.Common.Enums.Custom;
using MalikP.IVAO.Library.Common.Indexes;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Common.Parsers.DataExtractors.Client.Pilot
{
    public sealed class FlightPlanExtractor : IFlightPlanExtractor
    {
        private readonly IIVAOStringService _ivaoStringService;

        public FlightPlanExtractor()
        {
            _ivaoStringService = new IVAOStringService();
        }

        public FlightPlan ExtractValue(string[] data)
        {
            return FlightPlanBuilder.Create()
                 .WithAircraft(data[ClientIndex.Pilot.FPL.Aircraft])
                 .WithCruisingSpeed(data[ClientIndex.Pilot.FPL.CruisingSpeed])
                 .WithDepartureAerodrome(new Aerodrome(data[ClientIndex.Pilot.FPL.DepartureAerodrome]))
                 .WithCruisingLevel(data[ClientIndex.Pilot.FPL.CruisingLevel])
                 .WithDestinationAerodrome(new Aerodrome(data[ClientIndex.Pilot.FPL.DestinationAerodrome]))
                 .WithRevision(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.Revision]))
                 .WithFlightRules(AnnotationExtensions.GetFromMap<FlightRules>(data[ClientIndex.Pilot.FPL.FlightRules]))
                 .WithDepartureTime(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.DepartureTime]))
                 .WithActualDepartureTime(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.ActualDepartureTime]))
                 .WithEETHours(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.EET_Hours]))
                 .WithEETMinutes(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.EET_Minutes]))
                 .WithEnduranceHours(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.Endurance_Hours]))
                 .WithEnduranceMinutes(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.Endurance_Minutes]))
                 .WithAlternateAerodrome(new Aerodrome(data[ClientIndex.Pilot.FPL.AlternateAerodrome]))
                 .WithOtherInfo(data[ClientIndex.Pilot.FPL.OtherInfo])
                 .WithRoute(data[ClientIndex.Pilot.FPL.Route])
                 .WithSecondAlternateAerodrome(new Aerodrome(data[ClientIndex.Pilot.FPL.SecondAlternateAerodrome]))
                 .WithTypeOfFlight(AnnotationExtensions.GetFromMap<FlightType>(data[ClientIndex.Pilot.FPL.TypeOfFlight]))
                 .WithPersonsOnBoard(_ivaoStringService.IVAO_GetInt(data[ClientIndex.Pilot.FPL.PersonsOnBoard]))
                 .Build();
        }
    }
}
