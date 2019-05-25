// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: ClientIndex.cs 
// Company: MalikP.
//
// Repository: https://github.com/peterM/IVAO-Net
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
namespace MalikP.IVAO.Library.Common.Indexes
{
    public static class ClientIndex
    {
        public static int UNUSED1 { get; } = 31;

        public static int UNUSED2 { get; } = 32;

        public static int UNUSED3 { get; } = 33;

        public static int UNUSED4 { get; } = 34;

        public static class All
        {
            public static int Callsign { get; } = 0;

            public static int VID { get; } = 1;

            public static int Name { get; } = 2;

            public static int ClientType { get; } = 3;

            public static int Server { get; } = 14;

            public static int Protocol { get; } = 15;

            public static int ClientRating { get; } = 16;

            public static int ConnectionTime { get; } = 37;

            public static int SoftwareName { get; } = 38;

            public static int SoftwareVersion { get; } = 39;

            public static int AdministrativeVersion { get; } = 40;

            public static int AtcPilotVersion { get; } = 41;

            public static class GPS
            {
                public static int Latitude { get; } = 5;

                public static int Longitude { get; } = 6;

                public static int Altitude { get; } = 7;
            }
        }

        public static class ATC
        {
            public static int Frequency { get; } = 4;

            public static int FacilityType { get; } = 18;

            public static int VisualRange { get; } = 19;

            public static int ATIS { get; } = 35;

            public static int ATISTime { get; } = 36;

            public static int Version { get; } = 41;
        }

        public static class Pilot
        {
            public static int Groundspeed { get; } = 8;

            public static int TransponderCode { get; } = 17;

            public static int Version { get; } = 41;

            public static int Heading { get; } = 45;

            public static int IsOnGround { get; } = 46;

            public static int Simulator { get; } = 47;

            public static int PlaneMTL { get; } = 48;

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

                public static int SecondAlternateAerodrome { get; } = 42;

                public static int TypeOfFlight { get; } = 43;

                public static int PersonsOnBoard { get; } = 44;
            }
        }
    }
}