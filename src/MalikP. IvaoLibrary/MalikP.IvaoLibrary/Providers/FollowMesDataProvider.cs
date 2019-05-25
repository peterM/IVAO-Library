using System.Collections.Generic;
using System.Linq;

using MalikP.IvaoLibrary.Common.Parsers;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.Clients;
using MalikP.IvaoLibrary.Models.DataHolders;

namespace MalikP.IvaoLibrary.Providers
{
    public sealed class FollowMesDataProvider
        : AbstractClientsDataProvider<FollowMe>, IFollowMesProvider, IClientsProvider
    {
        public FollowMesDataProvider(
            IParserFactory parserFactory,
            IClientsSelector selector)
            : base(parserFactory,
                  selector)
        {
        }

        protected override IEnumerable<FollowMe> GetResult(object data)
        {
            if (data is IEnumerable<object> castedData)
            {
                return castedData.OfType<FollowMe>().ToList();
            }

            return Enumerable.Empty<FollowMe>();
        }

        IEnumerable<Client> IProvider<Client>.GetData(IWhazzup whazzupData)
        {
            return base.GetData(whazzupData);
        }
    }
}
