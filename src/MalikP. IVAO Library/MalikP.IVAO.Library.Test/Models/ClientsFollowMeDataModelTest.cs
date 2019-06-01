using System;

using MalikP.IVAO.Library.Common.Enums;
using MalikP.IVAO.Library.Common.Extensions;
using MalikP.IVAO.Library.Models.Clients;
using MalikP.IVAO.Library.Test.Common;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Test.Models
{
    [Category(Categories.ModelClientsData)]
    [Category(Categories.ModelClientsFollowMetData)]
    public class ClientsFollowMeDataModelTest : ModelAbstractTest
    {
        [Test]
        public void Equals_WhenTwoSameInstancesAreCreated_ThenInstancesAreEqual()
        {
            // arrange
            FollowMeBuilder builder = FollowMeBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Administrator)
                .WithCallsign("LZKZ_FOLLOW")
                .WithClientRating(2)
                .WithConnectionTime(DateTime.Now)
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("3.2.1.3")
                .WithVID("1234567");

            FollowMe instance0 = builder.Build();
            FollowMe instance1 = builder.Build();

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
            FollowMeBuilder builder = FollowMeBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Administrator)
                .WithCallsign("LZKZ_FOLLOW")
                .WithClientRating(2)
                .WithConnectionTime(DateTime.Now)
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("3.2.1.3")
                .WithVID("1234567");

            FollowMeBuilder builder1 = FollowMeBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Administrator)
                .WithCallsign("LZKZ_FOLLOW")
                .WithName("name")
                .WithProtocol("protocol")
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("3.2.1.3")
                .WithVID("1234567");

            FollowMe instance0 = builder.Build();
            FollowMe instance1 = builder1.Build();

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
            FollowMeBuilder builder = FollowMeBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Administrator)
                .WithCallsign("LZKZ_FOLLOW")
                .WithClientRating(2)
                .WithConnectionTime(DateTime.Now)
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("3.2.1.3")
                .WithVID("1234567");

            FollowMe instance0 = builder.Build();
            FollowMe instance1 = builder.Build();

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
            FollowMeBuilder builder = FollowMeBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Administrator)
                .WithCallsign("LZKZ_FOLLOW")
                .WithClientRating(2)
                .WithConnectionTime(DateTime.Now)
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("3.2.1.3")
                .WithVID("1234567");

            FollowMeBuilder builder1 = FollowMeBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Administrator)
                .WithCallsign("LZKZ_FOLLOW")
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("3.2.1.3")
                .WithVID("1234567");

            FollowMe instance0 = builder.Build();
            FollowMe instance1 = builder1.Build();

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
            FollowMeBuilder builder = FollowMeBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Administrator)
                .WithCallsign("LZKZ_FOLLOW")
                .WithClientRating(2)
                .WithConnectionTime(DateTime.Now)
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("3.2.1.3")
                .WithVID("1234567");

            FollowMe instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            FollowMe instance1 = serializedText.Deserialize<FollowMe>();

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
            FollowMeBuilder builder = FollowMeBuilder.Create()
                .WithAdministrativeVersion(AdministrativeRating.Administrator)
                .WithCallsign("LZKZ_FOLLOW")
                .WithClientRating(2)
                .WithConnectionTime(DateTime.Now)
                .WithLocation(null)
                .WithName("name")
                .WithProtocol("protocol")
                .WithServer("server")
                .WithSoftwareName("IVAC")
                .WithSoftwareVersion("3.2.1.3")
                .WithVID("1234567");

            FollowMe instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            FollowMe instance1 = serializedText.Deserialize<FollowMe>();

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