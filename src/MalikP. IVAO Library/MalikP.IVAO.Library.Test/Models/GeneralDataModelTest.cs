using System;

using MalikP.IVAO.Library.Models.General;
using MalikP.IVAO.Library.Test.Common;
using MalikP.IVAO.Library.Test.Framework;

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

            GeneralData generalData0 = generalDataBuilder.Build();
            GeneralData generalData1 = generalDataBuilder.Build();

            // act
            bool result = Equals(generalData0, generalData1);

            // assert
            Assert.That(generalData0, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData0, generalData1), Is.Not.True);
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

            GeneralData generalData0 = generalDataBuilder.Build();
            GeneralData generalData1 = generalDataBuilder1.Build();

            // act
            bool result = Equals(generalData0, generalData1);

            // assert
            Assert.That(generalData0, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData0, generalData1), Is.Not.True);
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

            GeneralData generalData0 = generalDataBuilder.Build();
            GeneralData generalData1 = generalDataBuilder.Build();

            // act
            int result1 = generalData0.GetHashCode();
            int result2 = generalData1.GetHashCode();

            // assert
            Assert.That(generalData0, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData0, generalData1), Is.Not.True);
            Assert.That(Equals(result1, result2), Is.True);
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

            GeneralData generalData0 = generalDataBuilder.Build();
            GeneralData generalData1 = generalDataBuilder1.Build();

            // act
            int result1 = generalData0.GetHashCode();
            int result2 = generalData1.GetHashCode();

            // assert
            Assert.That(generalData0, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData0, generalData1), Is.Not.True);
            Assert.That(Equals(result1, result2), Is.False);
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

            GeneralData generalData0 = generalDataBuilder.Build();

            string serializedText = generalData0.Serialize();

            GeneralData generalData1 = serializedText.Deserialize<GeneralData>();

            // act
            bool result = Equals(generalData0, generalData1);

            // assert
            Assert.That(generalData0, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData0, generalData1), Is.Not.True);
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

            GeneralData generalData0 = generalDataBuilder.Build();

            string serializedText = generalData0.Serialize();

            GeneralData generalData1 = serializedText.Deserialize<GeneralData>();

            // act

            int result1 = generalData0.GetHashCode();
            int result2 = generalData1.GetHashCode();

            // assert
            Assert.That(generalData0, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData0, generalData1), Is.Not.True);
            Assert.That(Equals(result1, result2), Is.True);
        }
    }
}
