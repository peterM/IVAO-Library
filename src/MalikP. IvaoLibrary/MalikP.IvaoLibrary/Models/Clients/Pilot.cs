using MalikP.IvaoLibrary.Common.Enums;
using MalikP.IvaoLibrary.Models.Other;

namespace MalikP.IvaoLibrary.Models.Clients
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
            string connectionTime,
            string softwareName,
            string softwareVersion,
            string administrativeVersion,
            string version,
            PilotRating rating)
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
                   version,
                   rating)
        {
        }

        public string Groundspeed { get; set; }
        public string TransponderCode { get; set; }
        public string TypeOfFlight { get; set; }
        public int PersonsOnBoard { get; set; }
        public int Heading { get; set; }
        public bool OnGround { get; set; }
        public FlightSimulator Simulator { get; set; }
        public string Plane { get; set; }

        public FlightPlan FlightPlan { get; set; }
    }
}
