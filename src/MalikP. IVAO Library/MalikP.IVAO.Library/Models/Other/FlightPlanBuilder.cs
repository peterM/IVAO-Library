// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: FlightPlanBuilder.cs 
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
    public sealed class FlightPlanBuilder
    {
        private string _aircraft;
        private string _cruisingSpeed;
        private Aerodrome _departureAerodrome;
        private string _cruisingLevel;
        private Aerodrome _destinationAerodrome;
        private int _revision;
        private FlightRules _flightRules;
        private int _departureTime;
        private int _actualDepartureTime;
        private int _eetHours;
        private int _eetMinutes;
        private int _enduranceHours;
        private int _enduranceMinutes;
        private Aerodrome _alternateAerodrome;
        private string _otherInfo;
        private string _route;
        private Aerodrome _secondAlternateAerodrome;
        private FlightType _typeOfFlight;
        private int _personsOnBoard;

        private FlightPlanBuilder()
        {
        }

        public static FlightPlanBuilder Create()
        {
            return new FlightPlanBuilder();
        }

        public FlightPlanBuilder WithAircraft(string aircraft)
        {
            _aircraft = aircraft;
            return this;
        }

        public FlightPlanBuilder WithCruisingSpeed(string cruisingSpeed)
        {
            _cruisingSpeed = cruisingSpeed;
            return this;
        }

        public FlightPlanBuilder WithDepartureAerodrome(Aerodrome departureAerodrome)
        {
            _departureAerodrome = departureAerodrome;
            return this;
        }

        public FlightPlanBuilder WithCruisingLevel(string cruisingLevel)
        {
            _cruisingLevel = cruisingLevel;
            return this;
        }

        public FlightPlanBuilder WithDestinationAerodrome(Aerodrome destinationAerodrome)
        {
            _destinationAerodrome = destinationAerodrome;
            return this;
        }

        public FlightPlanBuilder WithRevision(int revision)
        {
            _revision = revision;
            return this;
        }

        public FlightPlanBuilder WithFlightRules(FlightRules flightRules)
        {
            _flightRules = flightRules;
            return this;
        }

        public FlightPlanBuilder WithDepartureTime(int departureTime)
        {
            _departureTime = departureTime;
            return this;
        }

        public FlightPlanBuilder WithActualDepartureTime(int actualDepartureTime)
        {
            _actualDepartureTime = actualDepartureTime;
            return this;
        }

        public FlightPlanBuilder WithEETHours(int eetHours)
        {
            _eetHours = eetHours;
            return this;
        }

        public FlightPlanBuilder WithEETMinutes(int eetMinutes)
        {
            _eetMinutes = eetMinutes;
            return this;
        }

        public FlightPlanBuilder WithEnduranceHours(int enduranceHours)
        {
            _enduranceHours = enduranceHours;
            return this;
        }

        public FlightPlanBuilder WithEnduranceMinutes(int enduranceMinutes)
        {
            _enduranceMinutes = enduranceMinutes;
            return this;
        }

        public FlightPlanBuilder WithAlternateAerodrome(Aerodrome alternateAerodrome)
        {
            _alternateAerodrome = alternateAerodrome;
            return this;
        }

        public FlightPlanBuilder WithOtherInfo(string otherInfo)
        {
            _otherInfo = otherInfo;
            return this;
        }

        public FlightPlanBuilder WithRoute(string route)
        {
            _route = route;
            return this;
        }

        public FlightPlanBuilder WithSecondAlternateAerodrome(Aerodrome secondAlternateAerodrome)
        {
            _secondAlternateAerodrome = secondAlternateAerodrome;
            return this;
        }

        public FlightPlanBuilder WithTypeOfFlight(FlightType typeOfFlight)
        {
            _typeOfFlight = typeOfFlight;
            return this;
        }

        public FlightPlanBuilder WithPersonsOnBoard(int personsOnBoard)
        {
            _personsOnBoard = personsOnBoard;
            return this;
        }

        public FlightPlan Build()
        {
            return new FlightPlan(
                _aircraft,
                _cruisingSpeed,
                _departureAerodrome,
                _cruisingLevel,
                _destinationAerodrome,
                _revision,
                _flightRules,
                _departureTime,
                _actualDepartureTime,
                _eetHours,
                _eetMinutes,
                _enduranceHours,
                _enduranceMinutes,
                _alternateAerodrome,
                _otherInfo,
                _route,
                _secondAlternateAerodrome,
                _typeOfFlight,
                _personsOnBoard);
        }
    }
}
