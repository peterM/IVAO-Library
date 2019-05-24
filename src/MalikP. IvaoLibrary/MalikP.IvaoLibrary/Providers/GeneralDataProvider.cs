using System.Collections.Generic;
using System.Linq;

using MalikP.IvaoLibrary.Common.Parsers;
using MalikP.IvaoLibrary.Common.Selector;
using MalikP.IvaoLibrary.Models.General;

namespace MalikP.IvaoLibrary.Providers
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
