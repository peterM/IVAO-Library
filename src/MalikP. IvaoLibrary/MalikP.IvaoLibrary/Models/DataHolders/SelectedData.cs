namespace MalikP.IvaoLibrary.Models.DataHolders
{
    public sealed class SelectedData : AbstractDataHolder<string[]>, ISelectedData
    {
        public SelectedData(string[] data)
            : base(data)
        {
        }
    }
}
