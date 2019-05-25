using System.Collections.Generic;
using System.Linq;

using MalikP.IvaoLibrary.Common.Parsers;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.Clients;
using MalikP.IvaoLibrary.Models.DataHolders;

namespace MalikP.IvaoLibrary.Providers
{
    public sealed class AirTrafficControllersDataProvider
        : AbstractClientsDataProvider<AirTrafficController>, IAirTrafficControllersProvider, IClientsProvider
    {
        public AirTrafficControllersDataProvider(
            IParserFactory parserFactory,
            IClientsSelector selector)
            : base(parserFactory,
                  selector)
        {
        }

        protected override IEnumerable<AirTrafficController> GetResult(object data)
        {
            if (data is IEnumerable<object> castedData)
            {
                return castedData.OfType<AirTrafficController>().ToList();
            }

            return Enumerable.Empty<AirTrafficController>();
        }

        IEnumerable<Client> IProvider<Client>.GetData(IWhazzup whazzupData)
        {
            return base.GetData(whazzupData);
        }
    }
}
