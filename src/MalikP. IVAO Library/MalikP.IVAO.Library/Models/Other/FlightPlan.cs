using MalikP.IVAO.Library.Common.Enums.Custom;

namespace MalikP.IVAO.Library.Models.Other
{
    public sealed class FlightPlan
    {
        public FlightPlan(
            string aircraft,
            string cruisingSpeed,
            Aerodrome departureAerodrome,
            string cruisingLevel,
            Aerodrome destinationAerodrome,
            int revision,
            FlightRules flightRules,
            int departureTime,
            int actualDepartureTime,
            int eetHours,
            int eetMinutes,
            int enduranceHours,
            int enduranceMinutes,
            Aerodrome alternateAerodrome,
            string otherInfo,
            string route,
            Aerodrome secondAlternateAerodrome,
            FlightType typeOfFlight,
            int personsOnBoard)
        {
            Aircraft = aircraft;
            CruisingSpeed = cruisingSpeed;
            DepartureAerodrome = departureAerodrome;
            CruisingLevel = cruisingLevel;
            DestinationAerodrome = destinationAerodrome;
            Revision = revision;
            FlightRules = flightRules;
            DepartureTime = departureTime;
            ActualDepartureTime = actualDepartureTime;
            EETHours = eetHours;
            EETMinutess = eetMinutes;
            EnduranceHours = enduranceHours;
            EnduranceMinutes = enduranceMinutes;
            AlternateAerodrome = alternateAerodrome;
            OtherInfo = otherInfo;
            Route = route;
            SecondAlternateAerodrome = secondAlternateAerodrome;
            TypeOfFlight = typeOfFlight;
            PersonsOnBoard = personsOnBoard;
        }

        public string Aircraft { get; set; }

        // TODO: Create separate model where willbe mach speed, and so on
        public string CruisingSpeed { get; set; }

        public Aerodrome DepartureAerodrome { get; set; }

        public string CruisingLevel { get; set; }

        public Aerodrome DestinationAerodrome { get; set; }

        public int Revision { get; set; }

        public FlightRules FlightRules { get; set; }

        public int DepartureTime { get; set; }

        public int ActualDepartureTime { get; set; }

        public int EETHours { get; set; }

        public int EETMinutess { get; set; }

        public int EnduranceHours { get; set; }

        public int EnduranceMinutes { get; set; }

        public Aerodrome AlternateAerodrome { get; set; }

        public Aerodrome SecondAlternateAerodrome { get; set; }

        public string OtherInfo { get; set; }

        public string Route { get; set; }

        public FlightType TypeOfFlight { get; }

        public int PersonsOnBoard { get; }
    }
}
