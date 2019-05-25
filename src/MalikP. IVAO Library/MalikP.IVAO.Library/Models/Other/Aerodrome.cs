namespace MalikP.IVAO.Library.Models.Other
{
    public class Aerodrome
    {
        public Aerodrome(string icao)
        {
            ICAO = icao;
        }

        string ICAO { get; }

        public bool IsEmpty => string.IsNullOrWhiteSpace(ICAO);

        public bool IsValid => !IsEmpty && ICAO.Length == 4;
    }
}
