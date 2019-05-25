using System.Collections.Generic;
using System.Linq;

using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Models.General;

namespace MalikP.IVAO.Library.Providers
{
    public sealed class GeneralDataProvider : AbstractProvider<GeneralData, IGeneralSelector>, IGeneralDataProvider
    {
        public GeneralDataProvider(
            IParserFactory parserFactory,
            IGeneralSelector selector)
            : base(parserFactory,
                  selector)
        {
        }

        protected override IEnumerable<GeneralData> GetResult(object data)
        {
            if (data != null && data is GeneralData item)
            {
                return new GeneralData[] { item };
            }

            return Enumerable.Empty<GeneralData>();
        }
    }
}
