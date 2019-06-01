
using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Data.Source;
using MalikP.IVAO.Library.Providers;
using MalikP.IVAO.Library.Test.Common;
using MalikP.IVAO.Library.Tests.Abstracts;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Tests.Providers
{
    [Category(Categories.GeneralDataProvider)]
    public abstract class AbstractGeneralDataProviderTest : AbstractProviderTest
    {
        protected IGeneralDataProvider _testee;

        [OneTimeSetUp]
        protected virtual void Setup()
        {
            IGeneralSelector generalSelector = new GeneralSelector();

            _testee = new GeneralDataProvider(_datasource, _parserFactory, generalSelector);
        }

        protected override IIVAOWhazzupDataSource GetDataSource(string path)
        {
            return new LocalIVAOWhazzupDataSource(path);
        }
    }
}