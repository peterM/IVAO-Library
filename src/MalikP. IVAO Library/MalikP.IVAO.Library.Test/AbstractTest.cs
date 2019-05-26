using System.IO;
using System.Reflection;

using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public abstract class AbstractTest
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