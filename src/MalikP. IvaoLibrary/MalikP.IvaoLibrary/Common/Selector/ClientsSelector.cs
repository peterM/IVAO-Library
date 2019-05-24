namespace MalikP.IvaoLibrary.Common.Selector
{
    public sealed class ClientsSelector : AbstractSelector, IClientsSelector
    {
        public ClientsSelector()
            : base("!CLIENTS")
        {
        }
    }
}
