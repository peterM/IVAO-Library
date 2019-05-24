namespace MalikP.IvaoLibrary.Models.Airports
{
    public sealed class AirportBuilder
    {
        private string _icao;
        private string _atis;

        private AirportBuilder()
        {
        }

        public static AirportBuilder Create()
        {
            return new AirportBuilder();
        }

        public AirportBuilder WithICAO(string icao)
        {
            _icao = icao;
            return this;
        }

        public AirportBuilder WithATIS(string atis)
        {
            _atis = atis;
            return this;
        }

        public Airport Build()
        {
            return new Airport(
                _icao,
                _atis);
        }
    }
}
