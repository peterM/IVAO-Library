using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models.Airports;

namespace MalikP.IVAO.Library.Providers
{
    public sealed class AirportsDataProvider : AbstractProvider<Airport, IAirportsSelector>, IAirportsProvider
    {
        public AirportsDataProvider(
            IParserFactory parserFactory,
            IAirportsSelector selector)
            : base(parserFactory,
                  selector)
        {
        }
    }
}
