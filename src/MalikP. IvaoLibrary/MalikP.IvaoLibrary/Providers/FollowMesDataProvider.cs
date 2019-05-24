using MalikP.IvaoLibrary.Common.Parsers;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.Clients;

namespace MalikP.IvaoLibrary.Providers
{
    public sealed class FollowMesDataProvider
        : AbstractClientsDataProvider<FollowMe>, IFollowMesProvider
    {
        public FollowMesDataProvider(
            IParserFactory parserFactory,
            IClientsSelector selector)
            : base(parserFactory,
                  selector)
        {
        }
    }
}
