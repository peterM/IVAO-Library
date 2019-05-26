using System.IO;
using System.Reflection;

using MalikP.IVAO.Library.Test.Common;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Tests.Abstracts
{
    [Category(Categories.Providers)]
    public abstract class AbstractProviderTest : AbstractTest
    {
        protected const string fileName = "testData.txt";

        protected string GetPath()
        {
            string path = Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            return Path.Combine(path, fileName);
        }
    }
}