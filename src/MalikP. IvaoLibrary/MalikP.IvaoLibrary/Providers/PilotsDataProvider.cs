using MalikP.IvaoLibrary.Common.Parsers;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.Clients;

namespace MalikP.IvaoLibrary.Providers
{
    public sealed class PilotsDataProvider
        : AbstractClientsDataProvider<Pilot>, IPilotsProvider
    {
        public PilotsDataProvider(
            IParserFactory parserFactory,
            IClientsSelector selector)
            : base(parserFactory,
                  selector)
        {
        }
    }
}
