using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Models.Other;

namespace MalikP.IVAO.Library.Models.Clients
{
    public sealed class PilotBuilder : AbstractClientBuilder<PilotBuilder>
    {
        private PilotRating _rating;
        private int _groundSpeed;
        private string _transponderCode;
        private int _heading;
        private bool _isOnGround;
        private FlightSimulator _flightSimulator;
        private string _planeMtl;
        private FlightPlan _flightPlan;

        private PilotBuilder()
        {
        }

        public static PilotBuilder Create()
        {
            return new PilotBuilder();
        }

        public PilotBuilder WithRating(PilotRating rating)
        {
            _rating = rating;
            return this;
        }

        public PilotBuilder WithGroundSpeed(int groundSpeed)
        {
            _groundSpeed = groundSpeed;
            return this;
        }

        public PilotBuilder WithTransponderCode(string transponderCode)
        {
            _transponderCode = transponderCode;
            return this;
        }

        public PilotBuilder WithHeading(int heading)
        {
            _heading = heading;
            return this;
        }

        public PilotBuilder WithIsOnGround(bool isOnGround)
        {
            _isOnGround = isOnGround;
            return this;
        }

        public PilotBuilder WithFlightSimulator(FlightSimulator flightSimulator)
        {
            _flightSimulator = flightSimulator;
            return this;
        }

        public PilotBuilder WithPlaneMTL(string plane)
        {
            _planeMtl = plane;
            return this;
        }

        public PilotBuilder WithFlightPlan(FlightPlan flightPlan)
        {
            _flightPlan = flightPlan;
            return this;
        }

        public Pilot Build()
        {
            return new Pilot(
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
                clientRating,
                _rating,
                _groundSpeed,
                _transponderCode,
                _heading,
                _isOnGround,
                _flightSimulator,
                _planeMtl,
                _flightPlan);
        }

        protected override PilotBuilder GetBuilder()
        {
            return this;
        }
    }
}
