using GeometryLibrary;

namespace GeometryLibraryTestProject
{
    [TestClass]
    public class CircleTests
    {
        const double threshold = 1e-3;

        [TestMethod]
        public void Ctor_ThrowsException_IfRadiusNegative()
        {
            const double invalidValue = -12.2;
            Assert.ThrowsException<ArgumentException>(() => new Circle(invalidValue));
        }

        [TestMethod]
        public void Area_Return113097_IfRadius6()
        {
            const double radius = 6.0;
            var test = new Circle(radius);
            Assert.IsTrue(Math.Abs(test.Area() - 113.097) < threshold);
        }

        [TestMethod]
        public void Area_Return0_IfRadius0()
        {
            const double radius = 0.0;
            var test = new Circle(radius);
            Assert.IsTrue(Math.Abs(test.Area() - 0.0) < threshold);
        }
    }
}