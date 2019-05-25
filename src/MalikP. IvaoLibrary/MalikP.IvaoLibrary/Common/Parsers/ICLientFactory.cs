using MalikP.IvaoLibrary.Common.Enums;
using MalikP.IvaoLibrary.Models.Clients;

namespace MalikP.IvaoLibrary.Common.Parsers
{
    public interface ICLientFactory
    {
        Client Create(string[] rowData);

        ClientType TargetClientType { get; }
    }
}
