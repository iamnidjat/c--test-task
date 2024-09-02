namespace ShapeLibrary
{
    public class ShapeAreaCalculator
    {
        // Можем использовать полиморфизм для вычисления площади фигуры без знания типа фигуры в compile-time
        public double GetShapeArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
