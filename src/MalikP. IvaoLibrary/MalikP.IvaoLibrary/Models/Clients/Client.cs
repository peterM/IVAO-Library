using MalikP.IvaoLibrary.Common.Enums;
using MalikP.IvaoLibrary.Models.Other;

namespace MalikP.IvaoLibrary.Models.Clients
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
            string connectionTime,
            string softwareName,
            string softwareVersion,
            string administrativeVersion,
            string version)
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
            SoftwareVersion = softwareVersion;
            AdministrativeVersion = administrativeVersion;
            Version = version;
        }

        public string Callsign { get; }

        public string VID { get; }

        public string Name { get; }

        public ClientType ClientType { get; }

        public GPS Location { get; }

        public string Server { get; }

        public string Protocol { get; }

        public string ConnectionTime { get; }

        public string SoftwareName { get; }

        public string SoftwareVersion { get; }

        public string AdministrativeVersion { get; }

        // todo: extract to separate models
        public string Version { get; }
    }
}
