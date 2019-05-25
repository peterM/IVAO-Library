using MalikP.IvaoLibrary.Models.Clients;

namespace MalikP.IvaoLibrary.Common.Parsers
{
    public interface ICLientFactory<TClient> : ICLientFactory
        where TClient : Client
    {
        TClient Create(string[] rowData);
    }
}
