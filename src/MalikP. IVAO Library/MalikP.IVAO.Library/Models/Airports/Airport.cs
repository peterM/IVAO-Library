namespace MalikP.IVAO.Library.Models.Airports
{
    public sealed class Airport : IIvaoModel
    {
        public Airport(
            string icao,
            string atis)
        {
            ICAO = icao;
            ATIS = atis;
        }

        public string ICAO { get; }

        public string ATIS { get; }
    }
}
