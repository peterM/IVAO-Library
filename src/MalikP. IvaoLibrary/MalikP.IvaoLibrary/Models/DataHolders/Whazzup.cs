namespace MalikP.IvaoLibrary.Models.DataHolders
{
    public sealed class Whazzup : AbstractDataHolder<string[]>, IWhazzup
    {
        public Whazzup(string[] data)
            : base(data)
        {
        }
    }
}
