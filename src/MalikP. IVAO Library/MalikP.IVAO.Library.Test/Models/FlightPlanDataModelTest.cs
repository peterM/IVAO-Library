using MalikP.IVAO.Library.Common.Enums.Custom;
using MalikP.IVAO.Library.Common.Extensions;
using MalikP.IVAO.Library.Models.Other;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Test.Models
{
    public class FlightPlanDataModelTest : ModelAbstractTest
    {
        [Test]
        public void Equals_WhenTwoSameInstancesAreCreated_ThenInstancesAreEqual()
        {
            // arrange
            FlightPlanBuilder builder = FlightPlanBuilder.Create()
                .WithActualDepartureTime(1)
                .WithAircraft("B738")
                .WithAlternateAerodrome(new Aerodrome("LZKZ"))
                .WithCruisingLevel("320")
                .WithCruisingSpeed("250")
                .WithDepartureAerodrome(new Aerodrome("LZKZ"))
                .WithDepartureTime(2)
                .WithDestinationAerodrome(new Aerodrome("LZIB"))
                .WithEETHours(2)
                .WithEETMinutes(0)
                .WithEnduranceHours(5)
                .WithEnduranceMinutes(2)
                .WithFlightRules(FlightRules.IFR)
                .WithOtherInfo("NONE")
                .WithPersonsOnBoard(20)
                .WithRevision(22)
                .WithRoute("route")
                .WithSecondAlternateAerodrome(new Aerodrome("EPWA"))
                .WithTypeOfFlight(FlightType.GeneralAviation);

            FlightPlan instance0 = builder.Build();
            FlightPlan instance1 = builder.Build();

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
            FlightPlanBuilder builder = FlightPlanBuilder.Create()
                .WithActualDepartureTime(1)
                .WithAircraft("B738")
                .WithAlternateAerodrome(new Aerodrome("LZKZ"))
                .WithCruisingLevel("320")
                .WithCruisingSpeed("250")
                .WithDepartureAerodrome(new Aerodrome("LZKZ"))
                .WithDepartureTime(2)
                .WithDestinationAerodrome(new Aerodrome("LZIB"))
                .WithEETHours(2)
                .WithEETMinutes(0)
                .WithEnduranceHours(5)
                .WithEnduranceMinutes(2)
                .WithFlightRules(FlightRules.IFR)
                .WithOtherInfo("NONE")
                .WithPersonsOnBoard(20)
                .WithRevision(22)
                .WithRoute("route")
                .WithSecondAlternateAerodrome(new Aerodrome("EPWA"))
                .WithTypeOfFlight(FlightType.GeneralAviation);

            FlightPlanBuilder builder1 = FlightPlanBuilder.Create()
                .WithActualDepartureTime(1)
                .WithAircraft("B738")
                .WithAlternateAerodrome(new Aerodrome("LKPR"))
                .WithCruisingLevel("320")
                .WithCruisingSpeed("250")
                .WithDepartureAerodrome(new Aerodrome("LZKZ"))
                .WithDepartureTime(2)
                .WithDestinationAerodrome(new Aerodrome("LZIB"))
                .WithEETHours(3)
                .WithEETMinutes(30)
                .WithEnduranceHours(35)
                .WithEnduranceMinutes(32)
                .WithFlightRules(FlightRules.IFR)
                .WithOtherInfo("NONE")
                .WithPersonsOnBoard(20)
                .WithRevision(232)
                .WithRoute("rodute")
                .WithSecondAlternateAerodrome(new Aerodrome("EPdWA"))
                .WithTypeOfFlight(FlightType.GeneralAviation);

            FlightPlan instance0 = builder.Build();
            FlightPlan instance1 = builder1.Build();

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
            FlightPlanBuilder builder = FlightPlanBuilder.Create()
                .WithActualDepartureTime(1)
                .WithAircraft("B738")
                .WithAlternateAerodrome(new Aerodrome("LZKZ"))
                .WithCruisingLevel("320")
                .WithCruisingSpeed("250")
                .WithDepartureAerodrome(new Aerodrome("LZKZ"))
                .WithDepartureTime(2)
                .WithDestinationAerodrome(new Aerodrome("LZIB"))
                .WithEETHours(2)
                .WithEETMinutes(0)
                .WithEnduranceHours(5)
                .WithEnduranceMinutes(2)
                .WithFlightRules(FlightRules.IFR)
                .WithOtherInfo("NONE")
                .WithPersonsOnBoard(20)
                .WithRevision(22)
                .WithRoute("route")
                .WithSecondAlternateAerodrome(new Aerodrome("EPWA"))
                .WithTypeOfFlight(FlightType.GeneralAviation);

            FlightPlan instance0 = builder.Build();
            FlightPlan instance1 = builder.Build();

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
            FlightPlanBuilder builder = FlightPlanBuilder.Create()
                .WithActualDepartureTime(1)
                .WithAircraft("B738")
                .WithAlternateAerodrome(new Aerodrome("LZKZ"))
                .WithCruisingLevel("320")
                .WithCruisingSpeed("250")
                .WithDepartureAerodrome(new Aerodrome("LZKZ"))
                .WithDepartureTime(2)
                .WithDestinationAerodrome(new Aerodrome("LZIB"))
                .WithEETHours(2)
                .WithEETMinutes(0)
                .WithEnduranceHours(5)
                .WithEnduranceMinutes(2)
                .WithFlightRules(FlightRules.IFR)
                .WithOtherInfo("NONE")
                .WithPersonsOnBoard(20)
                .WithRevision(22)
                .WithRoute("route")
                .WithSecondAlternateAerodrome(new Aerodrome("EPWA"))
                .WithTypeOfFlight(FlightType.GeneralAviation);

            FlightPlanBuilder builder1 = FlightPlanBuilder.Create()
                .WithActualDepartureTime(1)
                .WithAircraft("B738")
                .WithAlternateAerodrome(new Aerodrome("LZKZ"))
                .WithCruisingLevel("3230")
                .WithCruisingSpeed("2350")
                .WithDepartureAerodrome(new Aerodrome("LZKZ"))
                .WithDepartureTime(2)
                .WithDestinationAerodrome(new Aerodrome("LKPR"))
                .WithEETHours(2)
                .WithEETMinutes(0)
                .WithEnduranceHours(5)
                .WithEnduranceMinutes(2)
                .WithFlightRules(FlightRules.MVFR)
                .WithOtherInfo("N3ONE")
                .WithPersonsOnBoard(20)
                .WithRevision(22)
                .WithRoute("route")
                .WithSecondAlternateAerodrome(new Aerodrome("EPWA"))
                .WithTypeOfFlight(FlightType.GeneralAviation);

            FlightPlan instance0 = builder.Build();
            FlightPlan instance1 = builder1.Build();

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
            FlightPlanBuilder builder = FlightPlanBuilder.Create()
                .WithActualDepartureTime(1)
                .WithAircraft("B738")
                .WithAlternateAerodrome(new Aerodrome("LZKZ"))
                .WithCruisingLevel("320")
                .WithCruisingSpeed("250")
                .WithDepartureAerodrome(new Aerodrome("LZKZ"))
                .WithDepartureTime(2)
                .WithDestinationAerodrome(new Aerodrome("LZIB"))
                .WithEETHours(2)
                .WithEETMinutes(0)
                .WithEnduranceHours(5)
                .WithEnduranceMinutes(2)
                .WithFlightRules(FlightRules.IFR)
                .WithOtherInfo("NONE")
                .WithPersonsOnBoard(20)
                .WithRevision(22)
                .WithRoute("route")
                .WithSecondAlternateAerodrome(new Aerodrome("EPWA"))
                .WithTypeOfFlight(FlightType.GeneralAviation);

            FlightPlan instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            FlightPlan instance1 = serializedText.Deserialize<FlightPlan>();

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
            FlightPlanBuilder builder = FlightPlanBuilder.Create()
                .WithActualDepartureTime(1)
                .WithAircraft("B738")
                .WithAlternateAerodrome(new Aerodrome("LZKZ"))
                .WithCruisingLevel("320")
                .WithCruisingSpeed("250")
                .WithDepartureAerodrome(new Aerodrome("LZKZ"))
                .WithDepartureTime(2)
                .WithDestinationAerodrome(new Aerodrome("LZIB"))
                .WithEETHours(2)
                .WithEETMinutes(0)
                .WithEnduranceHours(5)
                .WithEnduranceMinutes(2)
                .WithFlightRules(FlightRules.IFR)
                .WithOtherInfo("NONE")
                .WithPersonsOnBoard(20)
                .WithRevision(22)
                .WithRoute("route")
                .WithSecondAlternateAerodrome(new Aerodrome("EPWA"))
                .WithTypeOfFlight(FlightType.GeneralAviation);

            FlightPlan instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            FlightPlan instance1 = serializedText.Deserialize<FlightPlan>();

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
            FlightPlanBuilder builder = FlightPlanBuilder.Create()
                .WithActualDepartureTime(1)
                .WithAircraft("B738")
                .WithAlternateAerodrome(new Aerodrome("LZKZ"))
                .WithCruisingLevel("320")
                .WithCruisingSpeed("250")
                .WithDepartureAerodrome(new Aerodrome("LZKZ"))
                .WithDepartureTime(2)
                .WithDestinationAerodrome(new Aerodrome("LZIB"))
                .WithEETHours(2)
                .WithEETMinutes(0)
                .WithEnduranceHours(5)
                .WithEnduranceMinutes(2)
                .WithFlightRules(FlightRules.IFR)
                .WithOtherInfo("NONE")
                .WithPersonsOnBoard(20)
                .WithRevision(22)
                .WithRoute("route")
                .WithSecondAlternateAerodrome(new Aerodrome("EPWA"))
                .WithTypeOfFlight(FlightType.GeneralAviation);

            FlightPlan instance0 = builder.Build();

            object instance1 = instance0.Clone();

            // act
            int result0 = instance0.GetHashCode();
            int result1 = instance1.GetHashCode();

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(instance1, Is.InstanceOf<FlightPlan>());
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(Equals(result0, result1), Is.True);
        }

        [Test]
        public void Clone_WhenInstanceCloned_ThenInstancesAreEqual()
        {
            // arrange
            FlightPlanBuilder builder = FlightPlanBuilder.Create()
                .WithActualDepartureTime(1)
                .WithAircraft("B738")
                .WithAlternateAerodrome(new Aerodrome("LZKZ"))
                .WithCruisingLevel("320")
                .WithCruisingSpeed("250")
                .WithDepartureAerodrome(new Aerodrome("LZKZ"))
                .WithDepartureTime(2)
                .WithDestinationAerodrome(new Aerodrome("LZIB"))
                .WithEETHours(2)
                .WithEETMinutes(0)
                .WithEnduranceHours(5)
                .WithEnduranceMinutes(2)
                .WithFlightRules(FlightRules.IFR)
                .WithOtherInfo("NONE")
                .WithPersonsOnBoard(20)
                .WithRevision(22)
                .WithRoute("route")
                .WithSecondAlternateAerodrome(new Aerodrome("EPWA"))
                .WithTypeOfFlight(FlightType.GeneralAviation);

            FlightPlan instance0 = builder.Build();

            object instance1 = instance0.Clone();

            // act
            bool result = Equals(instance0, instance1);

            // assert
            Assert.That(instance0, Is.Not.Null);
            Assert.That(instance1, Is.Not.Null);
            Assert.That(instance1, Is.InstanceOf<FlightPlan>());
            Assert.That(ReferenceEquals(instance0, instance1), Is.Not.True);
            Assert.That(result, Is.True);
        }
    }
}