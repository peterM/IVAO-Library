using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models.Clients;

namespace MalikP.IVAO.Library.Providers
{
    public abstract class AbstractClientsDataProvider<TModel> : AbstractProvider<TModel, IClientsSelector>
        where TModel : Client
    {
        protected AbstractClientsDataProvider(
            IParserFactory parserFactory,
            IClientsSelector selector)
            : base(parserFactory,
                  selector)
        {
        }
    }
}
