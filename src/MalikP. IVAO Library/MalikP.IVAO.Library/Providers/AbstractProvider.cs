using System.Collections.Generic;
using System.Linq;

using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models;
using MalikP.IVAO.Library.Models.DataHolders;

namespace MalikP.IVAO.Library.Providers
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
