using MalikP.IVAO.Library.Common.Indexes;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Common.Parsers.DataExtractors.Client
{
    public sealed class LocationExtractor : ILocationExtractor
    {
        private readonly IIVAOStringService _ivaoStringService;

        public LocationExtractor()
        {
            _ivaoStringService = new IVAOStringService();
        }

        public GPS ExtractValue(string[] data)
        {
            return GPSBuilder.Create()
                .WithLatitude(_ivaoStringService.IVAO_GetDecimal(data[ClientIndex.All.GPS.Latitude]))
                .WithLongitude(_ivaoStringService.IVAO_GetDecimal(data[ClientIndex.All.GPS.Longitude]))
                .WithAltitude(_ivaoStringService.IVAO_GetInt(data[ClientIndex.All.GPS.Altitude]))
                .Build();
        }
    }
}
