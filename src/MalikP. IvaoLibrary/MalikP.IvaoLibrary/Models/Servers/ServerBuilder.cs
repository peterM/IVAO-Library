namespace MalikP.IvaoLibrary.Models.Servers
{
    public sealed class ServerBuilder
    {
        private string _hostname;
        private string _ip;
        private string _location;
        private string _name;
        private bool _connectionsAllowed;
        private int _maximumConnections;

        private ServerBuilder()
        {
        }

        public static ServerBuilder Create()
        {
            return new ServerBuilder();
        }

        public ServerBuilder WithHostname(string hostname)
        {
            _hostname = hostname;
            return this;
        }

        public ServerBuilder WithIP(string ip)
        {
            _ip = ip;
            return this;
        }

        public ServerBuilder WithLocation(string location)
        {
            _location = location;
            return this;
        }

        public ServerBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public ServerBuilder WithConnectionsAllowed(bool connectionsAllowed)
        {
            _connectionsAllowed = connectionsAllowed;
            return this;
        }

        public ServerBuilder WithMaximumConnections(int maximumConnections)
        {
            _maximumConnections = maximumConnections;
            return this;
        }

        public Server Build()
        {
            return new Server(
                _hostname,
                _ip,
                _location,
                _name,
                _connectionsAllowed,
                _maximumConnections);
        }
    }
}
