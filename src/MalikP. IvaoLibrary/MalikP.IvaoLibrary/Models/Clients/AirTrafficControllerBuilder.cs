using MalikP.IvaoLibrary.Common.Enums;

namespace MalikP.IvaoLibrary.Models.Clients
{
    public sealed class AirTrafficControllerBuilder : AbstractClientBuilder<AirTrafficControllerBuilder>
    {
        private string _frequency;
        private FacilityType _facilityType;
        private string _visualRange;
        private string _atis;
        private string _atisTime;

        private ATCRating _rating;

        private AirTrafficControllerBuilder()
        {
        }

        public static AirTrafficControllerBuilder Create()
        {
            return new AirTrafficControllerBuilder();
        }

        public AirTrafficControllerBuilder WithFrequency(string frequency)
        {
            _frequency = frequency;
            return this;
        }

        public AirTrafficControllerBuilder WithFacilityType(FacilityType facilityType)
        {
            _facilityType = facilityType;
            return this;
        }

        public AirTrafficControllerBuilder WithVisualRange(string visualRange)
        {
            _visualRange = visualRange;
            return this;
        }

        public AirTrafficControllerBuilder WithATIS(string atis)
        {
            _atis = atis;
            return this;
        }

        public AirTrafficControllerBuilder WithATISTime(string atisTime)
        {
            _atisTime = atisTime;
            return this;
        }

        public AirTrafficControllerBuilder WithRating(ATCRating rating)
        {
            _rating = rating;
            return this;
        }

        public AirTrafficController Build()
        {
            return new AirTrafficController(
                callsign,
                vid,
                name,
                clientType,
                location,
                server,
                protocol,
                connectionTime,
                softwareName,
                softwareVersion,
                administrativeVersion,
                version,
                _rating,
                _frequency,
                _facilityType,
                _visualRange,
                _atis,
                _atisTime);
        }

        protected override AirTrafficControllerBuilder GetBuilder()
        {
            return this;
        }
    }
}
