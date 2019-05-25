namespace MalikP.IVAO.Library.Models.DataHolders
{
    public interface IDataHolder<TDataType> : IDataHolder
    {
        TDataType Data { get; }
    }
}
