using System.Collections.Generic;
using System.Linq;

using MalikP.IvaoLibrary.Common.Parsers;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models;
using MalikP.IvaoLibrary.Models.DataHolders;

namespace MalikP.IvaoLibrary.Providers
{
    public abstract class AbstractProvider<TResult, TSelector> : IProvider<TResult>
        where TResult : class, IIvaoModel
        where TSelector : ISelector
    {
        protected AbstractProvider(
            IParserFactory parserFactory,
            TSelector selector)
        {
            ParserFactory = parserFactory;
            Selector = selector;
        }

        protected IParserFactory ParserFactory { get; }

        protected TSelector Selector { get; }

        public IEnumerable<TResult> GetData(IWhazzup whazzupData)
        {
            ISelectedData selectedData = Selector.SelectData(whazzupData);

            IParser parser = ParserFactory.CreateParser(Selector);
            object resultData = parser.Parse(selectedData);

            return GetResult(resultData);
        }

        protected virtual IEnumerable<TResult> GetResult(object data)
        {
            if (data is IEnumerable<TResult> castedData)
            {
                return castedData;
            }

            return Enumerable.Empty<TResult>();
        }
    }
}
