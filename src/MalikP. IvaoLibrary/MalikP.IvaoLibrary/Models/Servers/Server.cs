namespace MalikP.IvaoLibrary.Models.Servers
{
    public sealed class Server : IIvaoModel
    {
        public Server(
            string hostname,
            string ip,
            string location,
            string name,
            bool connectionsAllowed,
            int maximumConnections)
        {
            Hostname = hostname;
            IP = ip;
            Location = location;
            Name = name;
            ConnectionsAllowed = connectionsAllowed;
            MaximumConnections = maximumConnections;
        }

        public string Hostname { get; }

        public string IP { get; }

        public string Location { get; }

        public string Name { get; }

        public bool ConnectionsAllowed { get; }

        public int MaximumConnections { get; }
    }
}
