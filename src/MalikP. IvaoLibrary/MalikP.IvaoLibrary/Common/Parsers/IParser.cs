using MalikP.IvaoLibrary.Models.DataHolders;

namespace MalikP.IvaoLibrary.Common.Parsers
{
    public interface IParser
    {
        object Parse(ISelectedData selectedData);
    }
}
