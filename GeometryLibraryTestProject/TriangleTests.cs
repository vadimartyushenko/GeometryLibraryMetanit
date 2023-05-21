using GeometryLibrary;

namespace GeometryLibraryTestProject
{
    [TestClass]
    public class TriangleTests
    {
        const double threshold = 1e-3;

        [TestMethod]
        public void Ctor_ThrowsException_IfSideLengthNegative()
        {
            const double invalidValue = -1.1;
            Assert.ThrowsException<ArgumentException>(() => new Triangle(invalidValue, 10, 5));
        }

        [TestMethod]
        public void Ctor_ThrowsException_IfItIsNotTriangle()
        {
            var a = 5.0;
            var c = 3*a;
            Assert.ThrowsException<ArgumentException>(() => new Triangle(a, a, c));
        }

        [TestMethod]
        public void IsRight_False_IfSides_2_2_3()
        {
            var test = new Triangle(2, 2, 3); 
            Assert.IsFalse(test.IsRight());
        }

        [TestMethod]
        public void IsRight_True_IfSides_3_4_5()
        {
            var test = new Triangle(3, 5, 4);
            Assert.IsTrue(test.IsRight());
        }

        [TestMethod]
        public void Area_Return6_IfSides_3_4_5()
        {
            var test = new Triangle(3,4,5);
            Assert.IsTrue(Math.Abs(test.Area() - 6.0) < threshold);
        }
    }
}
