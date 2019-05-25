using System.Collections.Generic;
using System.Linq;

using MalikP.IvaoLibrary.Common.Parsers;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.Clients;
using MalikP.IvaoLibrary.Models.DataHolders;

namespace MalikP.IvaoLibrary.Providers
{
    public sealed class PilotsDataProvider
        : AbstractClientsDataProvider<Pilot>, IPilotsProvider, IClientsProvider
    {
        public PilotsDataProvider(
            IParserFactory parserFactory,
            IClientsSelector selector)
            : base(parserFactory,
                  selector)
        {
        }

        protected override IEnumerable<Pilot> GetResult(object data)
        {
            if (data is IEnumerable<object> castedData)
            {
                return castedData.OfType<Pilot>().ToList();
            }

            return Enumerable.Empty<Pilot>();
        }

        IEnumerable<Client> IProvider<Client>.GetData(IWhazzup whazzupData)
        {
            return base.GetData(whazzupData);
        }
    }
}
