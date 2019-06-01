using System;

using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Common.Extensions;
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
        public void Equals_WhenTwoSameInstancesAreCreated_ThenInstancesAreEqual()
        {
            // arrange
            PilotBuilder builder = PilotBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithCallsign("RYR2WQ")
                .WithClientRating(2)
                .WithConnectionTime(DateTime.Now)
                .WithFlightPlan(null)
                .WithFlightSimulator(FlightSimulator.Fly)
                .WithGroundSpeed(20)
                .WithHeading(222)
                .WithIsOnGround(true)
                .WithLocation(null)
                .WithName("name")
                .WithPlaneMTL("mtl")
                .WithProtocol("protocol")
                .WithRating(PilotRating.AirlineTransportPilot)
                .WithServer("server")
                .WithSoftwareName("sw name")
                .WithSoftwareVersion("1.2.3.4")
                .WithTransponderCode("7200")
                .WithVID("4321");

            Pilot instance0 = builder.Build();
            Pilot instance1 = builder.Build();

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
            PilotBuilder builder = PilotBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithCallsign("RYR2WQ")
                .WithClientRating(2)
                .WithConnectionTime(DateTime.Now)
                .WithFlightPlan(null)
                .WithFlightSimulator(FlightSimulator.Fly)
                .WithGroundSpeed(20)
                .WithHeading(222)
                .WithIsOnGround(true)
                .WithLocation(null)
                .WithName("name")
                .WithPlaneMTL("mtl")
                .WithProtocol("protocol")
                .WithRating(PilotRating.AirlineTransportPilot)
                .WithServer("server")
                .WithSoftwareName("sw name")
                .WithSoftwareVersion("1.2.3.4")
                .WithTransponderCode("7200")
                .WithVID("4321");

            PilotBuilder builder1 = PilotBuilder.Create()
               .WithAdministrativeVersion(AdministrativeRating.Observer)
               .WithCallsign("RYR2WQ")
               .WithClientRating(2)
               .WithConnectionTime(DateTime.Now)
               .WithFlightPlan(null)
               .WithFlightSimulator(FlightSimulator.Fly)
               .WithGroundSpeed(20)
               .WithHeading(222)
               .WithProtocol("protocol")
               .WithRating(PilotRating.AirlineTransportPilot)
               .WithServer("server")
               .WithSoftwareName("sw name")
               .WithSoftwareVersion("1.2.3.4")
               .WithTransponderCode("7200")
               .WithVID("4321");

            Pilot instance0 = builder.Build();
            Pilot instance1 = builder1.Build();

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
            PilotBuilder builder = PilotBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithCallsign("RYR2WQ")
                .WithClientRating(2)
                .WithConnectionTime(DateTime.Now)
                .WithFlightPlan(null)
                .WithFlightSimulator(FlightSimulator.Fly)
                .WithGroundSpeed(20)
                .WithHeading(222)
                .WithIsOnGround(true)
                .WithLocation(null)
                .WithName("name")
                .WithPlaneMTL("mtl")
                .WithProtocol("protocol")
                .WithRating(PilotRating.AirlineTransportPilot)
                .WithServer("server")
                .WithSoftwareName("sw name")
                .WithSoftwareVersion("1.2.3.4")
                .WithTransponderCode("7200")
                .WithVID("4321");

            Pilot instance0 = builder.Build();
            Pilot instance1 = builder.Build();

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
            PilotBuilder builder = PilotBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Observer)
                .WithCallsign("RYR2WQ")
                .WithClientRating(2)
                .WithConnectionTime(DateTime.Now)
                .WithFlightPlan(null)
                .WithFlightSimulator(FlightSimulator.Fly)
                .WithGroundSpeed(20)
                .WithHeading(222)
                .WithIsOnGround(true)
                .WithLocation(null)
                .WithName("name")
                .WithPlaneMTL("mtl")
                .WithProtocol("protocol")
                .WithRating(PilotRating.AirlineTransportPilot)
                .WithServer("server")
                .WithSoftwareName("sw name")
                .WithSoftwareVersion("1.2.3.4")
                .WithTransponderCode("7200")
                .WithVID("4321");

            PilotBuilder builder1 = PilotBuilder.Create()
               .WithAdministrativeVersion(AdministrativeRating.Observer)
               .WithCallsign("RYR2WQ")
               .WithClientRating(2)
               .WithConnectionTime(DateTime.Now)
               .WithFlightPlan(null)
               .WithFlightSimulator(FlightSimulator.Fly)
               .WithGroundSpeed(20)
               .WithHeading(222)
               .WithProtocol("protocol")
               .WithRating(PilotRating.AirlineTransportPilot)
               .WithServer("server")
               .WithSoftwareName("sw name")
               .WithSoftwareVersion("1.2.3.4")
               .WithTransponderCode("7200")
               .WithVID("4321");

            Pilot instance0 = builder.Build();
            Pilot instance1 = builder1.Build();

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
            PilotBuilder builder = PilotBuilder.Create()
                 .WithAdministrativeVersion(AdministrativeRating.Observer)
                 .WithCallsign("RYR2WQ")
                 .WithClientRating(2)
                 .WithConnectionTime(DateTime.Now)
                 .WithFlightPlan(null)
                 .WithFlightSimulator(FlightSimulator.Fly)
                 .WithGroundSpeed(20)
                 .WithHeading(222)
                 .WithIsOnGround(true)
                 .WithLocation(null)
                 .WithName("name")
                 .WithPlaneMTL("mtl")
                 .WithProtocol("protocol")
                 .WithRating(PilotRating.AirlineTransportPilot)
                 .WithServer("server")
                 .WithSoftwareName("sw name")
                 .WithSoftwareVersion("1.2.3.4")
                 .WithTransponderCode("7200")
                 .WithVID("4321");

            Pilot instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            Pilot instance1 = serializedText.Deserialize<Pilot>();

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
            PilotBuilder builder = PilotBuilder.Create()
                 .WithAdministrativeVersion(AdministrativeRating.Observer)
                 .WithCallsign("RYR2WQ")
                 .WithClientRating(2)
                 .WithConnectionTime(DateTime.Now)
                 .WithFlightPlan(null)
                 .WithFlightSimulator(FlightSimulator.Fly)
                 .WithGroundSpeed(20)
                 .WithHeading(222)
                 .WithIsOnGround(true)
                 .WithLocation(null)
                 .WithName("name")
                 .WithPlaneMTL("mtl")
                 .WithProtocol("protocol")
                 .WithRating(PilotRating.AirlineTransportPilot)
                 .WithServer("server")
                 .WithSoftwareName("sw name")
                 .WithSoftwareVersion("1.2.3.4")
                 .WithTransponderCode("7200")
                 .WithVID("4321");

            Pilot instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            Pilot instance1 = serializedText.Deserialize<Pilot>();

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
            PilotBuilder builder = PilotBuilder.Create()
                 .WithAdministrativeVersion(AdministrativeRating.Observer)
                 .WithCallsign("RYR2WQ")
                 .WithClientRating(2)
                 .WithConnectionTime(DateTime.Now)
                 .WithFlightPlan(null)
                 .WithFlightSimulator(FlightSimulator.Fly)
                 .WithGroundSpeed(20)
                 .WithHeading(222)
                 .WithIsOnGround(true)
                 .WithLocation(null)
                 .WithName("name")
                 .WithPlaneMTL("mtl")
                 .WithProtocol("protocol")
                 .WithRating(PilotRating.AirlineTransportPilot)
                 .WithServer("server")
                 .WithSoftwareName("sw name")
                 .WithSoftwareVersion("1.2.3.4")
                 .WithTransponderCode("7200")
                 .WithVID("4321");

            Pilot instance0 = builder.Build();

            object instance1 = instance0.Clone();

            // act
            int result0 = instance0.GetHashCode();
            int result1 = instance1.GetHashCode();

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(instance1, Is.InstanceOf<Pilot>());
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(Equals(result0, result1), Is.True);
        }

        [Test]
        public void Clone_WhenInstanceCloned_ThenInstancesAreEqual()
        {
            // arrange
            PilotBuilder builder = PilotBuilder.Create()
                 .WithAdministrativeVersion(AdministrativeRating.Observer)
                 .WithCallsign("RYR2WQ")
                 .WithClientRating(2)
                 .WithConnectionTime(DateTime.Now)
                 .WithFlightPlan(null)
                 .WithFlightSimulator(FlightSimulator.Fly)
                 .WithGroundSpeed(20)
                 .WithHeading(222)
                 .WithIsOnGround(true)
                 .WithLocation(null)
                 .WithName("name")
                 .WithPlaneMTL("mtl")
                 .WithProtocol("protocol")
                 .WithRating(PilotRating.AirlineTransportPilot)
                 .WithServer("server")
                 .WithSoftwareName("sw name")
                 .WithSoftwareVersion("1.2.3.4")
                 .WithTransponderCode("7200")
                 .WithVID("4321");

            Pilot instance0 = builder.Build();

            object instance1 = instance0.Clone();

            // act
            bool result = Equals(instance0, instance1);

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(instance1, Is.InstanceOf<Pilot>());
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(result, Is.True);
        }
    }
}