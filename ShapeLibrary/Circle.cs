namespace ShapeLibrary
{
    public class Circle
    {
        private double _radius;

        public double Radius {
            get => _radius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be greater than zero.");
                }
                    
                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
