using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.Clients;

namespace MalikP.IvaoLibrary.Common.Parsers
{
    public sealed class ClientParser : AbstractParser<Client, IClientsSelector>
    {
        public ClientParser(IClientsSelector selector)
            : base(selector)
        {
        }
    }
}
