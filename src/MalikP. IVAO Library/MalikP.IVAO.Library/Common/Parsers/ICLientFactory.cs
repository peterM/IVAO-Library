using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Models.Clients;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public interface ICLientFactory
    {
        Client Create(string[] rowData);

        ClientType TargetClientType { get; }
    }
}
