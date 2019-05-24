using MalikP.IvaoLibrary.Common.Parsers;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.Clients;

namespace MalikP.IvaoLibrary.Providers
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
