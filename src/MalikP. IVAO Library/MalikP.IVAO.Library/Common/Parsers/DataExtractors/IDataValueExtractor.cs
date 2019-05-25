namespace MalikP.IVAO.Library.Common.Parsers.DataExtractors
{
    public interface IDataValueExtractor<T>
    {
        T ExtractValue(string[] data);
    }
}
