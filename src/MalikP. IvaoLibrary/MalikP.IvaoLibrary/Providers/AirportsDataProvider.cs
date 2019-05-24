using MalikP.IvaoLibrary.Common.Parsers;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.Airports;

namespace MalikP.IvaoLibrary.Providers
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
