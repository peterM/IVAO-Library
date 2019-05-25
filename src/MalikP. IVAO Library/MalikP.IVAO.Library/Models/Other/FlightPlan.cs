// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: FlightPlan.cs 
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
