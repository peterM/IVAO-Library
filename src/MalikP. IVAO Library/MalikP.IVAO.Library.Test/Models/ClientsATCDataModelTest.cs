using System;

using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Common.Extensions;
using MalikP.IVAO.Library.Models.Clients;
using MalikP.IVAO.Library.Test.Common;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Test.Models
{
    [Category(Categories.ModelClientsData)]
    [Category(Categories.ModelClientsAtcData)]
    public class ClientsATCDataModelTest : ModelAbstractTest
    {
        [Test]
        public void Equals_WhenTwoSameInstancesAreCreated_ThenInstancesAreEqual()
        {
            // arrange
            AirTrafficControllerBuilder builder = AirTrafficControllerBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithATIS("atis")
                .WithATISTime(null)
                .WithCallsign("LZKZ_CTR")
                .WithClientRating(1)
                .WithConnectionTime(DateTime.Now)
                .WithFacilityType(FacilityType.Observer)
                .WithFrequency("123.33")
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithRating(ATCRating.SeniorController)
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("1.2.3")
                .WithVID("123456")
                .WithVisualRange(200);

            AirTrafficController instance0 = builder.Build();
            AirTrafficController instance1 = builder.Build();

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
            AirTrafficControllerBuilder builder = AirTrafficControllerBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithATIS("atis")
                .WithATISTime(null)
                .WithCallsign("LZKZ_CTR")
                .WithClientRating(1)
                .WithConnectionTime(DateTime.Now)
                .WithFacilityType(FacilityType.Observer)
                .WithFrequency("123.33")
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithRating(ATCRating.SeniorController)
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("1.2.3")
                .WithVID("123456")
                .WithVisualRange(200);

            AirTrafficControllerBuilder builder1 = AirTrafficControllerBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithATIS("atis")
                .WithATISTime(null)
                .WithCallsign("LZKZ_CTR")
                .WithClientRating(1)
                .WithName("name")
                .WithProtocol("protocol")
                .WithRating(ATCRating.SeniorController)
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("1.2.3")
                .WithVID("123456")
                .WithVisualRange(200);

            AirTrafficController instance0 = builder.Build();
            AirTrafficController instance1 = builder1.Build();

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
            AirTrafficControllerBuilder builder = AirTrafficControllerBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithATIS("atis")
                .WithATISTime(null)
                .WithCallsign("LZKZ_CTR")
                .WithClientRating(1)
                .WithConnectionTime(DateTime.Now)
                .WithFacilityType(FacilityType.Observer)
                .WithFrequency("123.33")
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithRating(ATCRating.SeniorController)
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("1.2.3")
                .WithVID("123456")
                .WithVisualRange(200);

            AirTrafficController instance0 = builder.Build();
            AirTrafficController instance1 = builder.Build();

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
            AirTrafficControllerBuilder builder = AirTrafficControllerBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithATIS("atis")
                .WithATISTime(null)
                .WithCallsign("LZKZ_CTR")
                .WithClientRating(1)
                .WithConnectionTime(DateTime.Now)
                .WithFacilityType(FacilityType.Observer)
                .WithFrequency("123.33")
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithRating(ATCRating.SeniorController)
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("1.2.3")
                .WithVID("123456")
                .WithVisualRange(200);

            AirTrafficControllerBuilder builder1 = AirTrafficControllerBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithATIS("atis")
                .WithATISTime(null)
                .WithCallsign("LZKZ_CTR")
                .WithClientRating(1)
                .WithName("name")
                .WithProtocol("protocol")
                .WithRating(ATCRating.SeniorController)
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("1.2.3")
                .WithVID("123456")
                .WithVisualRange(200);

            AirTrafficController instance0 = builder.Build();
            AirTrafficController instance1 = builder1.Build();

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
            AirTrafficControllerBuilder builder = AirTrafficControllerBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithATIS("atis")
                .WithATISTime(null)
                .WithCallsign("LZKZ_CTR")
                .WithClientRating(1)
                .WithConnectionTime(DateTime.Now)
                .WithFacilityType(FacilityType.Observer)
                .WithFrequency("123.33")
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithRating(ATCRating.SeniorController)
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("1.2.3")
                .WithVID("123456")
                .WithVisualRange(200);

            AirTrafficController instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            AirTrafficController instance1 = serializedText.Deserialize<AirTrafficController>();

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
            AirTrafficControllerBuilder builder = AirTrafficControllerBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithATIS("atis")
                .WithATISTime(null)
                .WithCallsign("LZKZ_CTR")
                .WithClientRating(1)
                .WithConnectionTime(DateTime.Now)
                .WithFacilityType(FacilityType.Observer)
                .WithFrequency("123.33")
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithRating(ATCRating.SeniorController)
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("1.2.3")
                .WithVID("123456")
                .WithVisualRange(200);

            AirTrafficController instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            AirTrafficController instance1 = serializedText.Deserialize<AirTrafficController>();

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
            AirTrafficControllerBuilder builder = AirTrafficControllerBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithATIS("atis")
                .WithATISTime(null)
                .WithCallsign("LZKZ_CTR")
                .WithClientRating(1)
                .WithConnectionTime(DateTime.Now)
                .WithFacilityType(FacilityType.Observer)
                .WithFrequency("123.33")
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithRating(ATCRating.SeniorController)
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("1.2.3")
                .WithVID("123456")
                .WithVisualRange(200);

            AirTrafficController instance0 = builder.Build();

            object instance1 = instance0.Clone();

            // act
            int result0 = instance0.GetHashCode();
            int result1 = instance1.GetHashCode();

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(instance1, Is.InstanceOf<AirTrafficController>());
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(Equals(result0, result1), Is.True);
        }

        [Test]
        public void Clone_WhenInstanceCloned_ThenInstancesAreEqual()
        {
            // arrange
            AirTrafficControllerBuilder builder = AirTrafficControllerBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithATIS("atis")
                .WithATISTime(null)
                .WithCallsign("LZKZ_CTR")
                .WithClientRating(1)
                .WithConnectionTime(DateTime.Now)
                .WithFacilityType(FacilityType.Observer)
                .WithFrequency("123.33")
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithRating(ATCRating.SeniorController)
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("1.2.3")
                .WithVID("123456")
                .WithVisualRange(200);

            AirTrafficController instance0 = builder.Build();

            object instance1 = instance0.Clone();

            // act
            bool result = Equals(instance0, instance1);

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(instance1, Is.InstanceOf<AirTrafficController>());
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(result, Is.True);
        }
    }
}