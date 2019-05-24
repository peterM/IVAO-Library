namespace MalikP.IvaoLibrary.Models.DataHolders
{
    public interface IDataHolder<TDataType> : IDataHolder
    {
        TDataType Data { get; }
    }
}
