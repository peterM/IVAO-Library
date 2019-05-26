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
            var generalData = testee.GetData().ToList();

            // assert
            Assert.That(generalData, Is.Not.Null);
            Assert.That(generalData.Count, Is.EqualTo(1));
        }
    }
}