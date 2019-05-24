using MalikP.IvaoLibrary.Common.Parsers;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.Clients;

namespace MalikP.IvaoLibrary.Providers
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
