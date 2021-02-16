using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;

namespace UnitTestProject1
{
    [TestClass]
    public class EngineTests
    {
        [TestMethod]
        public void EngineStartUpCheck()
        {
            // Arrange setup
            Engine engine = new Engine();

            // Assert test variables
            Assert.AreEqual(engine.About(), $"{engine.ToString()} is not started");

            // Act modifying class
            engine.Start();

            // Assert
            Assert.IsTrue(engine.IsStarted);

            // Assert
            Assert.AreEqual(engine.About(), $"{engine} is started");

            // act
            engine.Stop();

            Assert.IsFalse(engine.IsStarted);

            Assert.AreEqual(engine.About(), $"{engine} is not started");
        }
    }
}
