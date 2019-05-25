
using MalikP.IVAO.Library.Common.Indexes;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models.Airports;

namespace MalikP.IVAO.Library.Common.Parsers
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
