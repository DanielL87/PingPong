using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

    namespace Game.Tests
    {
        [TestClass]
        public class PingPongTest
        {
            [TestMethod]
            public void IsPingPong_NumberDivisibleByThreeAndFive_True()
            {
            // PingPong testPingPong = new PingPong();
            Assert.AreEqual("ping pong", PingPong.IsPingPong(15));
            }

           [TestMethod]
            public void IsPingPong_NumberDivisibleByThree_True()
            {
            // PingPong testPingPong = new PingPong();
            Assert.AreEqual("ping", PingPong.IsPingPong(3));
            }

            [TestMethod]
            public void IsPingPong_NumberDivisibleByFive_True()
            {
            // PingPong testPingPong = new PingPong();
            Assert.AreEqual("pong", PingPong.IsPingPong(5));
            }

            [TestMethod]
            public void IsPingPong_NumberNotDivisibleByThreeOrFive_True()
            {
            // PingPong testPingPong = new PingPong();
            Assert.AreEqual("14", PingPong.IsPingPong(14));
            }

        }
    }