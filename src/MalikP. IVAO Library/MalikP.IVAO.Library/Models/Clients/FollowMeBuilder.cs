namespace MalikP.IVAO.Library.Models.Clients
{
    public sealed class FollowMeBuilder : AbstractClientBuilder<FollowMeBuilder>
    {
        private FollowMeBuilder()
        {
        }

        public static FollowMeBuilder Create()
        {
            return new FollowMeBuilder();
        }

        public FollowMe Build()
        {
            return new FollowMe(
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
                clientRating);
        }

        protected override FollowMeBuilder GetBuilder()
        {
            return this;
        }
    }
}
