namespace MalikP.IvaoLibrary.Common.Indexes
{
    public static class ClientIndex
    {
        public static class All
        {
            public static int Callsign { get; } = 0;
            public static int VID { get; } = 1;
            public static int Name { get; } = 2;
            public static int ClientType { get; } = 3;

            public static class GPS
            {
                public static int Latitude { get; } = 5;
                public static int Longitude { get; } = 6;
                public static int Altitude { get; } = 7;
            }

            public static int Server { get; } = 14;
            public static int Protocol { get; } = 15;
            public static int Rating { get; } = 16;
            public static int ConnectionTime { get; } = 35;
            public static int SoftwareName { get; } = 36;
            public static int SoftwareVersion { get; } = 37;
            public static int AdministrativeVersion { get; } = 38;
            public static int AtcPilotVersion { get; } = 39;
        }

        public static class ATC
        {
            public static int Frequency { get; } = 4;
            //public static int FrequencyCont { get; } = 5;
            public static int FacilityType { get; } = 18;
            public static int VisualRange { get; } = 19;
            public static int ATIS { get; } = 33;
            public static int ATISTime { get; } = 34;
        }

        public static class Pilot
        {
            public static int Groundspeed { get; } = 8;

            public static class FPL
            {
                public static int Aircraft { get; } = 9;
                public static int CruisingSpeed { get; } = 10;
                public static int DepartureAerodrome { get; } = 11;
                public static int CruisingLevel { get; } = 12;
                public static int DestinationAerodrome { get; } = 13;
                public static int Revision { get; } = 20;
                public static int FlightRules { get; } = 21;
                public static int DepartureTime { get; } = 22;
                public static int ActualDepartureTime { get; } = 23;
                public static int EET_Hours { get; } = 24;
                public static int EET_Minutes { get; } = 25;
                public static int Endurance_Hours { get; } = 26;
                public static int Endurance_Minutes { get; } = 27;
                public static int AlternateAerodrome { get; } = 28;
                public static int OtherInfo { get; } = 29;
                public static int Route { get; } = 30;
                public static int SecondAlternateAerodrome { get; } = 40;
                public static int TypeOfFlight { get; } = 41;
                public static int PersonsOnBoard { get; } = 42;
            }

            public static int TransponderCode { get; } = 17;
            public static int Heading { get; } = 43;
            public static int OnGround { get; } = 44;
            public static int Simulator { get; } = 45;
            public static int Plane { get; } = 46;
        }

        public static int UNUSED1 { get; } = 31;
        public static int UNUSED2 { get; } = 32;
    }
}

