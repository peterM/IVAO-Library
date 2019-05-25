using MalikP.IvaoLibrary.Common.Enums;
using MalikP.IvaoLibrary.Models.Other;

namespace MalikP.IvaoLibrary.Models.Clients
{
    public abstract class ClientWithRating<TRating> : Client
    {
        public ClientWithRating(
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
            TRating rating)
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
            Rating = rating;
        }

        public TRating Rating { get; }
    }
}
