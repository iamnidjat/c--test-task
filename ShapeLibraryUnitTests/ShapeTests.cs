using ShapeLibrary; 

namespace ShapeLibraryUnitTests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void CircleArea_ShouldBeCalculatedCorrectly()
        {
            var circle = new Circle(5);
            var area = circle.CalculateArea();
            Assert.AreEqual(Math.PI * 25, area, 0.0001, "Area of circle with radius 5 should be 25π");
        }

        [TestMethod]
        public void TriangleArea_ShouldBeCalculatedCorrectly()
        {
            var triangle = new Triangle(3, 4, 5);
            var area = triangle.CalculateArea();
            Assert.AreEqual(6, area, 0.0001, "Area of triangle with sides 3, 4, 5 should be 6");
        }

        [TestMethod]
        public void Triangle_ShouldBeRight()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle(), "Triangle with sides 3, 4, 5 should be a right triangle");
        }

        [TestMethod]
        public void Triangle_ShouldNotBeRight()
        {
            var triangle = new Triangle(2, 3, 4);
            Assert.IsFalse(triangle.IsRightTriangle(), "Triangle with sides 2, 3, 4 should not be a right triangle");
        }
    }
}
