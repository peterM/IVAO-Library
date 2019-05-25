using System;

using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Models.Clients
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
        protected DateTime connectionTime;
        protected string softwareName;
        protected string softwareVersion;
        protected AdministrativeRating administrativeVersion;
        protected int clientRating;

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

        public TBuilder WithConnectionTime(DateTime connectionTime)
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

        public TBuilder WithAdministrativeVersion(AdministrativeRating administrativeVersion)
        {
            this.administrativeVersion = administrativeVersion;
            return GetBuilder();
        }

        public TBuilder WithClientRating(int clientRating)
        {
            this.clientRating = clientRating;
            return GetBuilder();
        }

        protected abstract TBuilder GetBuilder();
    }
}
