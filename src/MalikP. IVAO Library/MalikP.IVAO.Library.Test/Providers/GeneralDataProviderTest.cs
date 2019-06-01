using System.Linq;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Tests.Providers
{
    public class GeneralDataProviderTest : AbstractGeneralDataProviderTest
    {
        [Test]
        public void GetData_WhenStandardFileIsLoaded_ThenOneGeneralDataModelIsCreated()
        {
            // arrange

            // act
            var data = _testee.GetData().ToList();

            // assert
            Assert.That(data, Is.Not.Null);
            Assert.That(data.Count, Is.EqualTo(1));
        }
    }
}