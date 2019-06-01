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
            // act
            GeneralData generalData = generalDataBuilder.Build();
            GeneralData generalData1 = generalDataBuilder.Build();

            // assert
            Assert.That(generalData, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData, generalData1), Is.Not.True);
            Assert.That(Equals(generalData, generalData1), Is.True);
        }

        [Test]
        public void GetHashCode_WhenTwoSameInstancesAreCreated_ThenInstancesAreEquals()
        {
            // arrange
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                            .WithConnectedAirports(20)
                            .WithConnectedClients(23)
                            .WithConnectedServers(22)
                            .WithReload(2)
                            .WithUpdate(DateTime.Now)
                            .WithVersion(222);
            // act
            GeneralData generalData = generalDataBuilder.Build();
            GeneralData generalData1 = generalDataBuilder.Build();

            // assert
            Assert.That(generalData, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData, generalData1), Is.Not.True);
            Assert.That(Equals(generalData.GetHashCode(), generalData1.GetHashCode()), Is.True);
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

            // act
            GeneralData generalData = generalDataBuilder.Build();

            string serializedText = generalData.Serialize();

            GeneralData generalData1 = serializedText.Deserialize<GeneralData>();

            // assert
            Assert.That(generalData, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData, generalData1), Is.Not.True);
            Assert.That(Equals(generalData, generalData1), Is.True);
        }

        [Test]
        public void GetHashCode_WhenInstanceIsDeseraializeAndSerializedBack_ThenInstancesAreEquals()
        {
            // arrange
            GeneralDataBuilder generalDataBuilder = GeneralDataBuilder.Create()
                .WithConnectedAirports(20)
                .WithConnectedClients(23)
                .WithConnectedServers(22)
                .WithReload(2)
                .WithUpdate(DateTime.Now)
                .WithVersion(222);

            // act
            GeneralData generalData = generalDataBuilder.Build();

            string serializedText = generalData.Serialize();

            GeneralData generalData1 = serializedText.Deserialize<GeneralData>();

            // assert
            Assert.That(generalData, Is.Not.Null);
            Assert.That(generalData1, Is.Not.Null);
            Assert.That(ReferenceEquals(generalData, generalData1), Is.Not.True);
            Assert.That(Equals(generalData.GetHashCode(), generalData1.GetHashCode()), Is.True);
        }
    }
}
