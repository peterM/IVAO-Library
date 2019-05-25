using MalikP.IvaoLibrary.Common.Enums;
using MalikP.IvaoLibrary.Models.Clients;

namespace MalikP.IvaoLibrary.Common.Parsers
{
    public sealed class NullClientFactory : AbstractClientFactory<Client>
    {
        public NullClientFactory()
            : base(ClientType.NotDefined)
        {
        }

        public override Client Create(string[] rowData)
        {
            return null;
        }
    }
}
