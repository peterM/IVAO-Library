using MalikP.IVAO.Library.Common.Extensions;
using MalikP.IVAO.Library.Models.Other;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Test.Models
{
    public class GPSDataModelTest : ModelAbstractTest
    {
        [Test]
        public void Equals_WhenTwoSameInstancesAreCreated_ThenInstancesAreEqual()
        {
            // arrange
            GPSBuilder builder = GPSBuilder.Create()
                .WithAltitude(100)
                .WithLatitude(123.3m)
                .WithLongitude(180.11m);

            GPS instance0 = builder.Build();
            GPS instance1 = builder.Build();

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
            GPSBuilder builder = GPSBuilder.Create()
                .WithAltitude(100)
                .WithLatitude(123.3m)
                .WithLongitude(180.11m);

            GPSBuilder builder1 = GPSBuilder.Create()
                .WithAltitude(1020)
                .WithLatitude(1223.3m)
                .WithLongitude(1280.11m);

            GPS instance0 = builder.Build();
            GPS instance1 = builder1.Build();

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
            GPSBuilder builder = GPSBuilder.Create()
                .WithAltitude(100)
                .WithLatitude(123.3m)
                .WithLongitude(180.11m);

            GPS instance0 = builder.Build();
            GPS instance1 = builder.Build();

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
            GPSBuilder builder = GPSBuilder.Create()
                .WithAltitude(100)
                .WithLatitude(123.3m)
                .WithLongitude(180.11m);

            GPSBuilder builder1 = GPSBuilder.Create()
                .WithAltitude(1030)
                .WithLatitude(1233.3m)
                .WithLongitude(180.131m);

            GPS instance0 = builder.Build();
            GPS instance1 = builder1.Build();

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
            GPSBuilder builder = GPSBuilder.Create()
                .WithAltitude(100)
                .WithLatitude(123.3m)
                .WithLongitude(180.11m);

            GPS instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            GPS instance1 = serializedText.Deserialize<GPS>();

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
            GPSBuilder builder = GPSBuilder.Create()
                .WithAltitude(100)
                .WithLatitude(123.3m)
                .WithLongitude(180.11m);

            GPS instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            GPS instance1 = serializedText.Deserialize<GPS>();

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
        public void Clone_WhenInstanceCloned_ThenInstancesHashCodesAreEqual()
        {
            // arrange
            GPSBuilder builder = GPSBuilder.Create()
                .WithAltitude(100)
                .WithLatitude(123.3m)
                .WithLongitude(180.11m);

            GPS instance0 = builder.Build();

            object instance1 = instance0.Clone();

            // act
            int result0 = instance0.GetHashCode();
            int result1 = instance1.GetHashCode();

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(instance1, Is.InstanceOf<GPS>());
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(Equals(result0, result1), Is.True);
        }

        [Test]
        public void Clone_WhenInstanceCloned_ThenInstancesAreEqual()
        {
            // arrange
            GPSBuilder builder = GPSBuilder.Create()
                .WithAltitude(100)
                .WithLatitude(123.3m)
                .WithLongitude(180.11m);

            GPS instance0 = builder.Build();

            object instance1 = instance0.Clone();

            // act
            bool result = Equals(instance0, instance1);

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(instance1, Is.InstanceOf<GPS>());
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(result, Is.True);
        }
    }
}