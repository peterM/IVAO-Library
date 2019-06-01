// MIT License
//
// Copyright (c) 2019 Peter Malik. (MalikP.)
// 
// File: Pilot.cs 
// Company: MalikP.
//
// Repository: https://github.com/peterM/IVAO-Library
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
using System.Runtime.Serialization;

using MalikP.IVAO.Library.Common.Annotation;
using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Models.Clients
{
    [DataContract]
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
            string planeMTL,
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
            TransponderCode = transponderCode ?? string.Empty;
            Heading = heading;
            IsOnGround = isOnGround;
            Simulator = flightSimulator;
            PlaneMTL = planeMTL ?? string.Empty;
            FlightPlan = flightPlan;
        }

        public Pilot()
        {
        }

        [Unit("Knots")]
        [DataMember]
        public int GroundSpeed { get; private set; }

        [DataMember]
        public string TransponderCode { get; private set; }

        [Unit("Degrees")]
        [DataMember]
        public int Heading { get; private set; }

        [DataMember]
        public bool IsOnGround { get; private set; }

        [DataMember]
        public FlightSimulator Simulator { get; private set; }

        [DataMember]
        public string PlaneMTL { get; private set; }

        [DataMember]
        public FlightPlan FlightPlan { get; private set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            Pilot casted = obj as Pilot;
            if (casted == null)
            {
                return false;
            }

            return base.Equals(obj)
                && Equals(casted.GroundSpeed, GroundSpeed)
                && string.Equals(casted.TransponderCode, TransponderCode, StringComparison.InvariantCultureIgnoreCase)
                && Equals(casted.Heading, Heading)
                && Equals(casted.IsOnGround, IsOnGround)
                && Equals(casted.Simulator, Simulator)
                && string.Equals(casted.PlaneMTL, PlaneMTL, StringComparison.InvariantCultureIgnoreCase)
                && Equals(casted.FlightPlan, FlightPlan);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return base.GetHashCode()
                    + (GroundSpeed.GetHashCode() * 3)
                    + (TransponderCode.ToUpper().GetHashCode() * 3)
                    + (Heading.GetHashCode() * 3)
                    + (IsOnGround.GetHashCode() * 3)
                    + (Simulator.GetHashCode() * 3)
                    + (PlaneMTL.ToUpper().GetHashCode() * 3)
                    + (GetItemHashCode(FlightPlan) * 3) * 17;
            }
        }

        public static PilotBuilder Builder => PilotBuilder.Create();
    }
}
