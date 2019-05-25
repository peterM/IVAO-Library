using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Models.Clients;

namespace MalikP.IVAO.Library.Common.Parsers
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
