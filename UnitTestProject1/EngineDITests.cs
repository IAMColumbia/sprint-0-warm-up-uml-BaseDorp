using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;
using Ninject;
using Sprint_0_Warm_Up.NinjectModules;

namespace UnitTestProject1
{
    [TestClass]
    public class EngineDITests
    {
        [TestMethod]
        public void EngineTests()
        {
            IKernel kernal = new StandardKernel();
            kernal.Load(new EngineModule());


            Airplane airplane = kernal.Get<Airplane>();
            Helicopter heli = kernal.Get<Helicopter>();
            ToyPlane toyPlane = kernal.Get<ToyPlane>();
            Drone drone = kernal.Get<Drone>();


            Assert.IsInstanceOfType(airplane, typeof(JetEngine));
            Assert.IsInstanceOfType(heli, typeof(ReciprocatingEngine));
            Assert.IsInstanceOfType(toyPlane, typeof(RubberBandEngine));
            Assert.IsInstanceOfType(drone, typeof(UAVEngine));
        }
    }
}
