using MalikP.IVAO.Library.Common.Annotation;

namespace MalikP.IVAO.Library.Models.Other
{
    public class GPS
    {
        public GPS(
            decimal latitude,
            decimal longitude,
            int altitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Altitude = altitude;
        }

        [Unit("degree")]
        public decimal Latitude { get; }

        [Unit("degree")]
        public decimal Longitude { get; }

        [Unit("Feet")]
        public int Altitude { get; }
    }
}
