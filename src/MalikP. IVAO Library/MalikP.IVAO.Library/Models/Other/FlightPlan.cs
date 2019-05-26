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

using System.Runtime.Serialization;

using MalikP.IVAO.Library.Common.Enums.Custom;

namespace MalikP.IVAO.Library.Models.Other
{
    [DataContract]
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

        private FlightPlan()
        {
        }

        [DataMember]
        public string Aircraft { get; private set; }

        // TODO: Create separate model where willbe mach speed, and so on
        [DataMember]
        public string CruisingSpeed { get; private set; }

        [DataMember]
        public Aerodrome DepartureAerodrome { get; private set; }

        [DataMember]
        public string CruisingLevel { get; private set; }

        [DataMember]
        public Aerodrome DestinationAerodrome { get; private set; }

        [DataMember]
        public int Revision { get; private set; }

        [DataMember]
        public FlightRules FlightRules { get; private set; }

        [DataMember]
        public int DepartureTime { get; private set; }

        [DataMember]
        public int ActualDepartureTime { get; private set; }

        [DataMember]
        public int EETHours { get; private set; }

        [DataMember]
        public int EETMinutess { get; private set; }

        [DataMember]
        public int EnduranceHours { get; private set; }

        [DataMember]
        public int EnduranceMinutes { get; private set; }

        [DataMember]
        public Aerodrome AlternateAerodrome { get; private set; }

        [DataMember]
        public Aerodrome SecondAlternateAerodrome { get; private set; }

        [DataMember]
        public string OtherInfo { get; private set; }

        [DataMember]
        public string Route { get; private set; }

        [DataMember]
        public FlightType TypeOfFlight { get; private set; }

        [DataMember]
        public int PersonsOnBoard { get; private set; }
    }
}
