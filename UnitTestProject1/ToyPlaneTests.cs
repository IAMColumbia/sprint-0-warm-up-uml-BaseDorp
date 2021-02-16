using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint_0_Warm_Up;

namespace UnitTestProject1
{
    [TestClass]
    public class ToyPlaneTests
    {
        [TestMethod]
        public void ToyPlaneWoundUpTest()
        {
            // Arrage
            ToyPlane toyPlane = new ToyPlane();

            Assert.IsFalse(toyPlane.isWoundUp);
            //Assert.AreEqual(toyPlane.About(), $"{toyPlane} has a max altitude of {toyPlane.MaxAltitude} ft\n It's current altitude is {toyPlane.CurrentAltitude} ft\n is not started{toyPlane} is wound up");

            toyPlane.StartEngine();

            Assert.IsTrue(toyPlane.isWoundUp);
            Assert.AreEqual(toyPlane.getWindUpString(), $"{toyPlane} is winding up");

            toyPlane.TakeOff();

            Assert.AreEqual(toyPlane.CurrentAltitude, 10f);

            toyPlane.UnWind();

            Assert.IsFalse(toyPlane.isWoundUp);
        }
    }
}