using System.Collections.Generic;
using System.Linq;

using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models.Clients;
using MalikP.IVAO.Library.Models.DataHolders;

namespace MalikP.IVAO.Library.Providers
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
