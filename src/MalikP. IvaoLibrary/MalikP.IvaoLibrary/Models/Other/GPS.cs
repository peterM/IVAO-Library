namespace MalikP.IvaoLibrary.Models.Other
{
    public class GPS
    {
        public GPS(
            double latitude,
            double longitude,
            int altitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Altitude = altitude;
        }

        public double Latitude { get; }

        public double Longitude { get; }

        public int Altitude { get; }
    }
}
