using MalikP.IvaoLibrary.Common.Parsers;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.Servers;

namespace MalikP.IvaoLibrary.Providers
{
    public sealed class ServersDataProvider : AbstractProvider<Server, IServersSelector>, IServersProvider
    {
        public ServersDataProvider(
            IParserFactory parserFactory,
            IServersSelector selector)
            : base(parserFactory,
                  selector)
        {
        }
    }
}
