using MalikP.IvaoLibrary.Common.Enums;

namespace MalikP.IvaoLibrary.Models.Clients
{
    public sealed class PilotBuilder : AbstractClientBuilder<PilotBuilder>
    {
        private PilotRating _rating;

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
                version,
                _rating);
        }

        protected override PilotBuilder GetBuilder()
        {
            return this;
        }
    }
}
