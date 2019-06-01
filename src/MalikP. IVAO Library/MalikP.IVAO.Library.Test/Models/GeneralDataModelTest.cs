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
        public void Equals_WhenTwoSameInstancesAreCreated_ThenInstancesAreEquals()
        {
            // arrange
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                            .WithConnectedAirports(20)
                            .WithConnectedClients(23)
                            .WithConnectedServers(22)
                            .WithReload(2)
                            .WithUpdate(DateTime.Now)
                            .WithVersion(222);
            GeneralData generalData = generalDataBuilder.Build();
            GeneralData generalData1 = generalDataBuilder.Build();

            // act
            bool result = Equals(generalData, generalData1);

            // assert
            Assert.That(generalData, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData, generalData1), Is.Not.True);
            Assert.That(result, Is.True);
        }

        [Test]
        public void GetHashCode_WhenTwoSameInstancesAreCreated_ThenInstancesHashCodesAreEquals()
        {
            // arrange
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                            .WithConnectedAirports(20)
                            .WithConnectedClients(23)
                            .WithConnectedServers(22)
                            .WithReload(2)
                            .WithUpdate(DateTime.Now)
                            .WithVersion(222);

            GeneralData generalData = generalDataBuilder.Build();
            GeneralData generalData1 = generalDataBuilder.Build();

            // act
            int result1 = generalData.GetHashCode();
            int result2 = generalData1.GetHashCode();

            // assert
            Assert.That(generalData, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData, generalData1), Is.Not.True);
            Assert.That(Equals(result1, result2), Is.True);
        }

        [Test]
        public void Equals_WhenInstanceIsDeseraializeAndSerializedBack_ThenInstancesAreEquals()
        {
            // arrange
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                .WithConnectedAirports(20)
                .WithConnectedClients(23)
                .WithConnectedServers(22)
                .WithReload(2)
                .WithUpdate(DateTime.Now)
                .WithVersion(222);

            GeneralData generalData = generalDataBuilder.Build();

            string serializedText = generalData.Serialize();

            GeneralData generalData1 = serializedText.Deserialize<GeneralData>();

            // act
            bool result = Equals(generalData, generalData1);

            // assert
            Assert.That(generalData, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData, generalData1), Is.Not.True);
            Assert.That(result, Is.True);
        }

        [Test]
        public void GetHashCode_WhenInstanceIsDeseraializeAndSerializedBack_ThenInstancesHashCodesAreEquals()
        {
            // arrange
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                .WithConnectedAirports(20)
                .WithConnectedClients(23)
                .WithConnectedServers(22)
                .WithReload(2)
                .WithUpdate(DateTime.Now)
                .WithVersion(222);

            GeneralData generalData = generalDataBuilder.Build();

            string serializedText = generalData.Serialize();

            GeneralData generalData1 = serializedText.Deserialize<GeneralData>();

            // act

            int result1 = generalData.GetHashCode();
            int result2 = generalData1.GetHashCode();

            // assert
            Assert.That(generalData, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData, generalData1), Is.Not.True);
            Assert.That(Equals(result1, result2), Is.True);
        }
    }
}
