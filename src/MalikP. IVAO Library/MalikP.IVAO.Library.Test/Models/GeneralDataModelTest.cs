using MalikP.IVAO.Library.Models.General;
using MalikP.IVAO.Library.Test.Common;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Test.Models
{
    [Category(Categories.ModelGeneralData)]
    public class GeneralDataModelTest : ModelAbstractTest
    {
        [Test]
        public void Equals_WhenTwoSameInstancesAreCreated_ThenInstancesAreEquals()
        {
            // arrange
            var generalDataBuilder = GeneralDataBuilder.Create();

            // act
            GeneralData generalData = generalDataBuilder.Build();
            GeneralData generalData1 = generalDataBuilder.Build();

            // assert
            Assert.That(generalData, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData, generalData1), Is.Not.True);
            Assert.That(Equals(generalData, generalData1), Is.True);
        }
    }
}
