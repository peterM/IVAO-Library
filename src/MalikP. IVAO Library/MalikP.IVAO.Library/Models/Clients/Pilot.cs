// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: Pilot.cs 
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
using System;

using MalikP.IVAO.Library.Common.Annotation;
using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Models.Clients
{
    public class Pilot : ClientWithRating<PilotRating>
    {
        public Pilot(
            string callsign,
            string vid,
            string name,
            ClientType clientType,
            GPS location,
            string server,
            string protocol,
            DateTime connectionTime,
            string softwareName,
            string softwareVersion,
            AdministrativeRating administrativeVersion,
            int clientRating,
            PilotRating rating,
            int groundSpeed,
            string transponderCode,
            int heading,
            bool isOnGround,
            FlightSimulator flightSimulator,
            string Mtl,
            FlightPlan flightPlan)
            : base(callsign,
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
                   rating)
        {
            GroundSpeed = groundSpeed;
            TransponderCode = transponderCode;
            Heading = heading;
            IsOnGround = isOnGround;
            Simulator = flightSimulator;
            PlaneMTL = Mtl;
            FlightPlan = flightPlan;
        }

        [Unit("Knots")]
        public int GroundSpeed { get; set; }

        public string TransponderCode { get; set; }

        [Unit("Degrees")]
        public int Heading { get; set; }

        public bool IsOnGround { get; set; }

        public FlightSimulator Simulator { get; set; }

        public string PlaneMTL { get; set; }

        public FlightPlan FlightPlan { get; set; }
    }
}
