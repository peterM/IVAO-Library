using System.IO;
using System.Reflection;
using MalikP.IVAO.Library.Common.Parsers;
using MalikP.IVAO.Library.Data.Source;
using MalikP.IVAO.Library.Test.Common;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Tests.Abstracts
{
    [Category(Categories.Providers)]
    public abstract class AbstractProviderTest : AbstractTest
    {
        protected const string fileName = "testData.txt";

        protected readonly IParserFactory _parserFactory;
        protected readonly IIVAOWhazzupDataSource _datasource;

        protected AbstractProviderTest()
        {
            string path = GetPath();

            _parserFactory = CreateParserFactory();
            _datasource = GetDataSource(path);
        }

        private IParserFactory CreateParserFactory()
        {
            return new ParserFactory();
        }

        protected string GetPath()
        {
            string path = Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            return Path.Combine(path, fileName);
        }

        protected abstract IIVAOWhazzupDataSource GetDataSource(string path);
    }
}