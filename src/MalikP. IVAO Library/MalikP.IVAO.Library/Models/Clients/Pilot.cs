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
