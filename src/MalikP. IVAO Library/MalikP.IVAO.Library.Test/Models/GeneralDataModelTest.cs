using System;

using MalikP.IVAO.Library.Common.Extensions;
using MalikP.IVAO.Library.Models.General;
using MalikP.IVAO.Library.Test.Common;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Test.Models
{
    [Category(Categories.ModelGeneralData)]
    public class GeneralDataModelTest : ModelAbstractTest
    {
        [Test]
        public void Equals_WhenTwoSameInstancesAreCreated_ThenInstancesAreEqual()
        {
            // arrange
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                .WithConnectedAirports(20)
                .WithConnectedClients(23)
                .WithConnectedServers(22)
                .WithReload(2)
                .WithUpdate(DateTime.Now)
                .WithVersion(222);

            GeneralData instance0 = generalDataBuilder.Build();
            GeneralData instance1 = generalDataBuilder.Build();

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
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                .WithConnectedAirports(20)
                .WithConnectedClients(23)
                .WithConnectedServers(22)
                .WithReload(2)
                .WithUpdate(DateTime.Now)
                .WithVersion(222);

            GeneralDataBuilder generalDataBuilder1 = GeneralDataBuilder.Create()
                .WithConnectedServers(22)
                .WithReload(2)
                .WithUpdate(DateTime.Now)
                .WithVersion(222);

            GeneralData instance0 = generalDataBuilder.Build();
            GeneralData instance1 = generalDataBuilder1.Build();

            // act
            bool result = Equals(instance0, instance1);

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(result, Is.False);
        }

        [Test]
        public void GetHashCode_WhenTwoSameInstancesAreCreated_ThenInstancesHashCodesAreEqual()
        {
            // arrange
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                .WithConnectedAirports(20)
                .WithConnectedClients(23)
                .WithConnectedServers(22)
                .WithReload(2)
                .WithUpdate(DateTime.Now)
                .WithVersion(222);

            GeneralData instance0 = generalDataBuilder.Build();
            GeneralData instance1 = generalDataBuilder.Build();

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
        public void GetHashCode_WhenTwoDifferentInstancesAreCreated_ThenInstancesHashCodesAreNotEqual()
        {
            // arrange
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                .WithConnectedAirports(20)
                .WithConnectedClients(23)
                .WithConnectedServers(22)
                .WithReload(2)
                .WithUpdate(DateTime.Now)
                .WithVersion(222);

            GeneralDataBuilder generalDataBuilder1 = GeneralDataBuilder.Create()
                .WithConnectedAirports(20)
                .WithReload(2)
                .WithUpdate(DateTime.Now)
                .WithVersion(222);

            GeneralData instance0 = generalDataBuilder.Build();
            GeneralData instance1 = generalDataBuilder1.Build();

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
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                .WithConnectedAirports(20)
                .WithConnectedClients(23)
                .WithConnectedServers(22)
                .WithReload(2)
                .WithUpdate(DateTime.Now)
                .WithVersion(222);

            GeneralData instance0 = generalDataBuilder.Build();

            string serializedText = instance0.Serialize();

            GeneralData instance1 = serializedText.Deserialize<GeneralData>();

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
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                .WithConnectedAirports(20)
                .WithConnectedClients(23)
                .WithConnectedServers(22)
                .WithReload(2)
                .WithUpdate(DateTime.Now)
                .WithVersion(222);

            GeneralData instance0 = generalDataBuilder.Build();

            string serializedText = instance0.Serialize();

            GeneralData instance1 = serializedText.Deserialize<GeneralData>();

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
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                .WithConnectedAirports(20)
                .WithConnectedClients(23)
                .WithConnectedServers(22)
                .WithReload(2)
                .WithUpdate(DateTime.Now)
                .WithVersion(222);

            GeneralData instance0 = generalDataBuilder.Build();

            object instance1 = instance0.Clone();

            // act
            int result0 = instance0.GetHashCode();
            int result1 = instance1.GetHashCode();

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(instance1, Is.InstanceOf<GeneralData>());
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(Equals(result0, result1), Is.True);
        }

        [Test]
        public void Clone_WhenInstanceCloned_ThenInstancesAreEqual()
        {
            // arrange
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                .WithConnectedAirports(20)
                .WithConnectedClients(23)
                .WithConnectedServers(22)
                .WithReload(2)
                .WithUpdate(DateTime.Now)
                .WithVersion(222);

            GeneralData instance0 = generalDataBuilder.Build();

            object instance1 = instance0.Clone();

            // act
            bool result = Equals(instance0, instance1);

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(instance1, Is.InstanceOf<GeneralData>());
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(result, Is.True);
        }
    }
}
