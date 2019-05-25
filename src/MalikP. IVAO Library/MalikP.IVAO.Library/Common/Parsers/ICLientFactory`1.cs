using MalikP.IVAO.Library.Models.Clients;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public interface ICLientFactory<TClient> : ICLientFactory
        where TClient : Client
    {
        new TClient Create(string[] rowData);
    }
}
