namespace MalikP.IVAO.Library.Common.Selector
{
    public sealed class ClientsSelector : AbstractSelector, IClientsSelector
    {
        public ClientsSelector()
            : base("!CLIENTS")
        {
        }
    }
}
