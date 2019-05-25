using System;

using MalikP.IVAO.Library.Common.Annotation;
using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Models.Clients
{
    public abstract class Client : IIvaoModel
    {
        public Client(
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
            int clientRating)
        {
            Callsign = callsign;
            VID = vid;
            Name = name;
            ClientType = clientType;
            Location = location;
            Server = server;
            Protocol = protocol;
            ConnectionTime = connectionTime;
            SoftwareName = softwareName;

            // TODO: Possible to use 'Version' type
            SoftwareVersion = softwareVersion;
            AdministrativeVersion = administrativeVersion;
            ClientRating = clientRating;
        }

        public string Callsign { get; }

        public string VID { get; }

        public string Name { get; }

        public ClientType ClientType { get; }

        [Unit("N/A")]
        public GPS Location { get; }

        public string Server { get; }

        public string Protocol { get; }

        public DateTime ConnectionTime { get; }

        public string SoftwareName { get; }

        public string SoftwareVersion { get; }

        public AdministrativeRating AdministrativeVersion { get; }

        public int ClientRating { get; }
    }
}
