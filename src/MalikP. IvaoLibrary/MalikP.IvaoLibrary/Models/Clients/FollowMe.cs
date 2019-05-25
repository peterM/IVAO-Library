using MalikP.IvaoLibrary.Common.Enums;
using MalikP.IvaoLibrary.Models.Other;

namespace MalikP.IvaoLibrary.Models.Clients
{
    public class FollowMe : Client
    {
        public FollowMe(
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
            string version)
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
                   version)
        {
        }
    }
}
