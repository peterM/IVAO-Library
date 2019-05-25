namespace MalikP.IvaoLibrary.Models.Other
{
    public sealed class GPSBuilder
    {
        private double _latitude;
        private double _longitude;
        private int _altitude;

        private GPSBuilder()
        {
        }

        public static GPSBuilder Create()
        {
            return new GPSBuilder();
        }

        public GPSBuilder WithLatitude(double latitude)
        {
            _latitude = latitude;
            return this;
        }

        public GPSBuilder WithLongitude(double longitude)
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
