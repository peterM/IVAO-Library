namespace MalikP.IVAO.Library.Models.Other
{
    public sealed class GPSBuilder
    {
        private decimal _latitude;
        private decimal _longitude;
        private int _altitude;

        private GPSBuilder()
        {
        }

        public static GPSBuilder Create()
        {
            return new GPSBuilder();
        }

        public GPSBuilder WithLatitude(decimal latitude)
        {
            _latitude = latitude;
            return this;
        }

        public GPSBuilder WithLongitude(decimal longitude)
        {
            _longitude = longitude;
            return this;
        }

        public GPSBuilder WithAltitude(int altitude)
        {
            _altitude = altitude;
            return this;
        }

        public GPS Build()
        {
            return new GPS(_latitude, _longitude, _altitude);
        }
    }
}
