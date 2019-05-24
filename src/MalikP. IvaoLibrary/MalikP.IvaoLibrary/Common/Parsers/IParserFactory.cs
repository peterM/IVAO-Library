using MalikP.IvaoLibrary.Common.Selector;

namespace MalikP.IvaoLibrary.Common.Parsers
{
    public interface IParserFactory
    {
        IParser CreateParser<TSelector>(TSelector selector)
            where TSelector : ISelector;
    }
}
