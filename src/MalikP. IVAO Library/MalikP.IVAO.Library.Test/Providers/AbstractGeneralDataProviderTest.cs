
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
        protected IGeneralDataProvider testee;

        protected AbstractGeneralDataProviderTest()
        {
            string path = GetPath();
            IIVAOWhazzupDataSource nonCachedLocalDataSource = new LocalIVAOWhazzupDataSource(path);
            ICachedIVAOWhazzupDataSource dataSource = new CachedIVAOWhazzupDataSource(nonCachedLocalDataSource);

            IParserFactory parserFactory = new ParserFactory();

            IGeneralSelector generalSelector = new GeneralSelector();

            testee = new GeneralDataProvider(dataSource, parserFactory, generalSelector);
        }
    }
}