using MalikP.IvaoLibrary.Common.Enums;
using MalikP.IvaoLibrary.Models.Other;

namespace MalikP.IvaoLibrary.Models.Clients
{
    public abstract class AbstractClientBuilder<TBuilder>
    {
        protected string callsign;
        protected string vid;
        protected string name;
        protected ClientType clientType;
        protected GPS location;
        protected string server;
        protected string protocol;
        protected string connectionTime;
        protected string softwareName;
        protected string softwareVersion;
        protected string administrativeVersion;
        protected string version;

        public TBuilder WithCallsign(string callsign)
        {
            this.callsign = callsign;
            return GetBuilder();
        }

        public TBuilder WithVID(string vid)
        {
            this.vid = vid;
            return GetBuilder();
        }

        public TBuilder WithName(string name)
        {
            this.name = name;
            return GetBuilder();
        }

        public TBuilder WithClientType(ClientType clientType)
        {
            this.clientType = clientType;
            return GetBuilder();
        }

        public TBuilder WithLocation(GPS location)
        {
            this.location = location;
            return GetBuilder();
        }

        public TBuilder WithServer(string server)
        {
            this.server = server;
            return GetBuilder();
        }

        public TBuilder WithProtocol(string protocol)
        {
            this.protocol = protocol;
            return GetBuilder();
        }

        public TBuilder WithConnectionTime(string connectionTime)
        {
            this.connectionTime = connectionTime;
            return GetBuilder();
        }

        public TBuilder WithSoftwareName(string softwareName)
        {
            this.softwareName = softwareName;
            return GetBuilder();
        }

        public TBuilder WithSoftwareVersion(string softwareVersion)
        {
            this.softwareVersion = softwareVersion;
            return GetBuilder();
        }

        public TBuilder WithAdministrativeVersion(string administrativeVersion)
        {
            this.administrativeVersion = administrativeVersion;
            return GetBuilder();
        }

        public TBuilder WithVersion(string version)
        {
            this.version = version;
            return GetBuilder();
        }

        protected abstract TBuilder GetBuilder();
    }
}
