// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: PilotBuilder.cs 
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
using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Models.Clients
{
    public sealed class PilotBuilder : AbstractClientBuilder<PilotBuilder>
    {
        private PilotRating _rating;
        private int _groundSpeed;
        private string _transponderCode;
        private int _heading;
        private bool _isOnGround;
        private FlightSimulator _flightSimulator;
        private string _planeMtl;
        private FlightPlan _flightPlan;

        private PilotBuilder()
        {
        }

        public static PilotBuilder Create()
        {
            return new PilotBuilder();
        }

        public PilotBuilder WithRating(PilotRating rating)
        {
            _rating = rating;
            return this;
        }

        public PilotBuilder WithGroundSpeed(int groundSpeed)
        {
            _groundSpeed = groundSpeed;
            return this;
        }

        public PilotBuilder WithTransponderCode(string transponderCode)
        {
            _transponderCode = transponderCode;
            return this;
        }

        public PilotBuilder WithHeading(int heading)
        {
            _heading = heading;
            return this;
        }

        public PilotBuilder WithIsOnGround(bool isOnGround)
        {
            _isOnGround = isOnGround;
            return this;
        }

        public PilotBuilder WithFlightSimulator(FlightSimulator flightSimulator)
        {
            _flightSimulator = flightSimulator;
            return this;
        }

        public PilotBuilder WithPlaneMTL(string plane)
        {
            _planeMtl = plane;
            return this;
        }

        public PilotBuilder WithFlightPlan(FlightPlan flightPlan)
        {
            _flightPlan = flightPlan;
            return this;
        }

        public Pilot Build()
        {
            return new Pilot(
                callsign,
                vid,
                name,
                clientType,
                location,
                server,
                protocol,
                connectionTime,
                softwareName,
                softwareVersion,
                administrativeVersion,
                clientRating,
                _rating,
                _groundSpeed,
                _transponderCode,
                _heading,
                _isOnGround,
                _flightSimulator,
                _planeMtl,
                _flightPlan);
        }

        protected override PilotBuilder GetBuilder()
        {
            return this;
        }
    }
}
