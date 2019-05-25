using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models.Servers;

namespace MalikP.IVAO.Library.Providers
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
