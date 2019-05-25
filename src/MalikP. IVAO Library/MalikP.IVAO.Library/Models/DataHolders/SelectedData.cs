namespace MalikP.IVAO.Library.Models.DataHolders
{
    public sealed class SelectedData : AbstractDataHolder<string[]>, ISelectedData
    {
        public SelectedData(string[] data)
            : base(data)
        {
        }
    }
}
