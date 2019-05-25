using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models.Clients;

namespace MalikP.IVAO.Library.Providers
{
    public sealed class ClientsDataProvider : AbstractClientsDataProvider<Client>, IClientsProvider
    {
        public ClientsDataProvider(
            IParserFactory parserFactory,
            IClientsSelector selector)
            : base(parserFactory,
                  selector)
        {
        }
    }
}
