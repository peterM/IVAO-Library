namespace MalikP.IvaoLibrary.Models.DataHolders
{
    public abstract class AbstractDataHolder<TData> : IDataHolder<TData>
    {
        public AbstractDataHolder(TData data)
        {
            Data = data;
        }

        public TData Data { get; }
    }
}
