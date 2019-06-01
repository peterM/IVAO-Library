using MalikP.IVAO.Library.Models.Clients;
using MalikP.IVAO.Library.Test.Common;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Test.Models
{
    [Category(Categories.ModelClientsData)]
    [Category(Categories.ModelClientsPilotData)]
    public class ClientsPilotDataModelTest : ModelAbstractTest
    {
        [Test]
        public void Equals_WhenTwoSameInstancesAreCreated_ThenInstancesAreEquals()
        {
            // arrange
            var builder = PilotBuilder.Create();

            // act
            Pilot pilot0 = builder.Build();
            Pilot pilot1 = builder.Build();

            // assert
            Assert.That(pilot0, Is.Not.Null);
            Assert.That(pilot1, Is.Not.Null);
            Assert.That(ReferenceEquals(pilot0, pilot1), Is.Not.True);
            Assert.That(Equals(pilot0, pilot1), Is.True);
        }
    }
}
