using MalikP.IVAO.Library.Models.DataHolders;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public interface IParser
    {
        object Parse(ISelectedData selectedData);
    }
}
