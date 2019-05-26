
using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Common.Selector;
using MalikP.IVAO.Library.Data.Source;
using MalikP.IVAO.Library.Providers;

using NUnit.Framework;

namespace Tests
{
    [Category("General Data")]
    public abstract class AbstractGeneralDataTest : AbstractTest
    {
        protected IGeneralDataProvider testee;

        protected AbstractGeneralDataTest()
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