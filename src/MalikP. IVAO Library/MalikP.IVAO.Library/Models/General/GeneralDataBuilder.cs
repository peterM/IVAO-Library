using System;

namespace MalikP.IVAO.Library.Models.General
{
    public sealed class GeneralDataBuilder
    {
        private int _version;
        private int _reload;
        private DateTime _update;
        private int _connectedClients;
        private int _connectedServers;
        private int _connectedAirports;

        private GeneralDataBuilder()
        {
        }

        public static GeneralDataBuilder Create()
        {
            return new GeneralDataBuilder();
        }

        public GeneralDataBuilder WithVersion(int version)
        {
            _version = version;
            return this;
        }

        public GeneralDataBuilder WithReload(int reload)
        {
            _reload = reload;
            return this;
        }

        public GeneralDataBuilder WithUpdate(DateTime update)
        {
            _update = update;
            return this;
        }

        public GeneralDataBuilder WithConnectedClients(int connectedClients)
        {
            _connectedClients = connectedClients;
            return this;
        }

        public GeneralDataBuilder WithConnectedServers(int connectedServers)
        {
            _connectedServers = connectedServers;
            return this;
        }

        public GeneralDataBuilder WithConnectedAirports(int connectedAirports)
        {
            _connectedAirports = connectedAirports;
            return this;
        }

        public GeneralData Build()
        {
            return new GeneralData(
                _version,
                _reload,
                _update,
                _connectedClients,
                _connectedServers,
                _connectedAirports);
        }
    }
}