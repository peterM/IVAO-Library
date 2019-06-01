using MalikP.IVAO.Library.Common.Extensions;
using MalikP.IVAO.Library.Models.Servers;

using NUnit.Framework;

namespace MalikP.IVAO.Library.Test.Models
{
    public class ServerDataModelTest : ModelAbstractTest
    {
        [Test]
        public void Equals_WhenTwoSameInstancesAreCreated_ThenInstancesAreEqual()
        {
            // arrange
            ServerBuilder builder = ServerBuilder.Create()
                .WithConnectionsAllowed(true)
                .WithHostname("server.domain.local")
                .WithIP("127.0.0.1")
                .WithLocation("location")
                .WithMaximumConnections(250)
                .WithName("name");

            Server instance0 = builder.Build();
            Server instance1 = builder.Build();

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
            ServerBuilder builder = ServerBuilder.Create()
                .WithConnectionsAllowed(true)
                .WithHostname("server.domain.local")
                .WithIP("127.0.0.1")
                .WithLocation("location")
                .WithMaximumConnections(250)
                .WithName("name");

            ServerBuilder builder1 = ServerBuilder.Create()
                .WithConnectionsAllowed(true)
                .WithHostname("server.domain.local1")
                .WithIP("127.0.0.2")
                .WithLocation("location1")
                .WithMaximumConnections(250)
                .WithName("name1");

            Server instance0 = builder.Build();
            Server instance1 = builder1.Build();

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
            ServerBuilder builder = ServerBuilder.Create()
                .WithConnectionsAllowed(true)
                .WithHostname("server.domain.local")
                .WithIP("127.0.0.1")
                .WithLocation("location")
                .WithMaximumConnections(250)
                .WithName("name");

            Server instance0 = builder.Build();
            Server instance1 = builder.Build();

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
            ServerBuilder builder = ServerBuilder.Create()
                .WithConnectionsAllowed(true)
                .WithHostname("server.domain.local")
                .WithIP("127.0.0.1")
                .WithLocation("location")
                .WithMaximumConnections(250)
                .WithName("name");

            ServerBuilder builder1 = ServerBuilder.Create()
                .WithConnectionsAllowed(true)
                .WithHostname("server.domain.local1")
                .WithIP("127.0.0.11")
                .WithLocation("location1")
                .WithMaximumConnections(250)
                .WithName("name1");

            Server instance0 = builder.Build();
            Server instance1 = builder1.Build();

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
            ServerBuilder builder = ServerBuilder.Create()
                .WithConnectionsAllowed(true)
                .WithHostname("server.domain.local")
                .WithIP("127.0.0.1")
                .WithLocation("location")
                .WithMaximumConnections(250)
                .WithName("name");

            Server instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            Server instance1 = serializedText.Deserialize<Server>();

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
            ServerBuilder builder = ServerBuilder.Create()
                .WithConnectionsAllowed(true)
                .WithHostname("server.domain.local")
                .WithIP("127.0.0.1")
                .WithLocation("location")
                .WithMaximumConnections(250)
                .WithName("name");

            Server instance0 = builder.Build();

            string serializedText = instance0.Serialize();

            Server instance1 = serializedText.Deserialize<Server>();

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