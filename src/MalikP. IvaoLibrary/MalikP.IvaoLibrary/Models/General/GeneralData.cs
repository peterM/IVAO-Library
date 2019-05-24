using System;

namespace MalikP.IvaoLibrary.Models.General
{
    public sealed class GeneralData : IIvaoModel
    {
        public GeneralData(
            int version,
            int reload,
            DateTime update,
            int connectedClients,
            int connectedServers,
            int connectedAirports)
        {
            Version = version;
            Reload = reload;
            Update = update;
            ConnectedClients = connectedClients;
            ConnectedServers = connectedServers;
            ConnectedAirports = connectedAirports;
        }

        public int Version { get; }

        public int Reload { get; }

        public DateTime Update { get; }

        public int ConnectedClients { get; }

        public int ConnectedServers { get; }

        public int ConnectedAirports { get; }
    }
}