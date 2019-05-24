
using MalikP.IvaoLibrary.Common.Indexes;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.Airports;

namespace MalikP.IvaoLibrary.Common.Parsers
{
    public sealed class AirportParser : AbstractParser<Airport, IAirportsSelector>
    {
        public AirportParser(IAirportsSelector selector)
            : base(selector)
        {
        }

        protected override Airport CreateItem(string data)
        {
            string[] dataItems = Split(data);

            return AirportBuilder.Create()
                .WithICAO(dataItems[(int)AirportIndex.ICAO])
                .WithATIS(dataItems[(int)AirportIndex.ATIS])
                .Build();
        }
    }
}
