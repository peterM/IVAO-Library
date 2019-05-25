using MalikP.IVAO.Library.Common.Selector;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public sealed class ParserFactory : IParserFactory
    {
        public IParser CreateParser<TSelector>(TSelector selector)
            where TSelector : ISelector
        {
            switch (selector)
            {
                case GeneralSelector generalSelector:
                    return new GeneralParser(generalSelector);

                case ClientsSelector clientsSelector:
                    return new ClientParser(clientsSelector);

                case ServersSelector serverSelector:
                    return new ServerParser(serverSelector);

                case AirportsSelector airportSelector:
                    return new AirportParser(airportSelector);

                default:
                    return default(IParser);
            }
        }
    }
}
