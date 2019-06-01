using MalikP.IVAO.Library.Common.Extensions;
using MalikP.IVAO.Library.Models.Airports;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Test.Models
{
    public class AirportDataModelTest : ModelAbstractTest
    {
        [Test]
        public void Equals_WhenTwoSameInstancesAreCreated_ThenInstancesAreEqual()
        {
            // arrange
            AirportBuilder builder = AirportBuilder.Create()
                .WithATIS("A")
                .WithICAO("LZKZ");

            Airport instance0 = builder.Build();
            Airport instance1 = builder.Build();

            // act
            bool result = Equals(instance0, instance1);

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Equals_WhenTwoDifferentInstancesAreCreated_ThenInstancesAreNotEqual()
        {
            // arrange
            AirportBuilder builder = AirportBuilder.Create()
                .WithATIS("A")
                .WithICAO("LZKZ");

            AirportBuilder builder1 = AirportBuilder.Create()
                .WithATIS("A")
                .WithICAO("LZIB");

            Airport instance0 = builder.Build();
            Airport instance1 = builder1.Build();

            // act
            bool result = Equals(instance0, instance1);

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(result, Is.False);
        }

        [Test]
        public void GetHashCode_WhenTwoSameInstancesAreCreated_ThenInstanceHashCodesAreEqual()
        {
            // arrange
            AirportBuilder builder = AirportBuilder.Create()
                .WithATIS("A")
                .WithICAO("LZKZ");

            Airport instance0 = builder.Build();
            Airport instance1 = builder.Build();

            // act
            int result0 = instance0.GetHashCode();
            int result1 = instance1.GetHashCode();

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(Equals(result0, result1), Is.True);
        }

        [Test]
        public void GetHashCode_WhenTwoDifferentInstancesAreCreated_ThenInstanceHashCodesAreNotEqual()
        {
            // arrange
            AirportBuilder builder = AirportBuilder.Create()
                .WithATIS("A")
                .WithICAO("LZKZ");

            AirportBuilder builder1 = AirportBuilder.Create()
                .WithATIS("B")
                .WithICAO("LZIB");

            Airport instance0 = builder.Build();
            Airport instance1 = builder1.Build();

            // act
            int result0 = instance0.GetHashCode();
            int result1 = instance1.GetHashCode();

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(Equals(result0, result1), Is.False);
        }

        [Test]
        public void Equals_WhenInstanceIsDeseraializeAndSerializedBack_ThenInstancesAreEqual()
        {
            // arrange
            AirportBuilder builder = AirportBuilder.Create()
                .WithATIS("A")
                .WithICAO("LZKZ");

            Airport instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            Airport instance1 = serializedText.Deserialize<Airport>();

            // act
            bool result = Equals(instance0, instance1);

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(result, Is.True);
        }

        [Test]
        public void GetHashCode_WhenInstanceIsDeseraializeAndSerializedBack_ThenInstancesHashCodesAreEqual()
        {
            // arrange
            AirportBuilder builder = AirportBuilder.Create()
                .WithATIS("A")
                .WithICAO("LZKZ");

            Airport instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            Airport instance1 = serializedText.Deserialize<Airport>();

            // act
            int result0 = instance0.GetHashCode();
            int result1 = instance1.GetHashCode();

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(Equals(result0, result1), Is.True);
        }
    }
}