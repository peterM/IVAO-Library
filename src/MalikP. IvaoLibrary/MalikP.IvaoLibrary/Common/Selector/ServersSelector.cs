namespace MalikP.IvaoLibrary.Common.Selector
{
    public sealed class ServersSelector : AbstractSelector, IServersSelector
    {
        public ServersSelector()
            : base("!SERVERS")
        {
        }
    }
}
