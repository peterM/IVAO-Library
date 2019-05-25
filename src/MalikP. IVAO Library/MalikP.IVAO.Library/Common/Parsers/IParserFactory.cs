using MalikP.IVAO.Library.Common.Selector;

namespace MalikP.IVAO.Library.Common.Parsers
{
    public interface IParserFactory
    {
        IParser CreateParser<TSelector>(TSelector selector)
            where TSelector : ISelector;
    }
}
