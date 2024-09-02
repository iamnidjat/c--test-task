namespace ShapeLibrary
{
    public class Triangle
    {
        private double _sideA;

        public double SideA
        {
            get => _sideA;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("All sides must be greater than zero.");
                }

                _sideA = value;
            }
        }

        private double _sideB;

        public double SideB
        {
            get => _sideB;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("All sides must be greater than zero.");
                }               

                _sideB = value;
            }
        }

        private double _sideC;

        public double SideC
        {
            get => _sideC;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("All sides must be greater than zero.");
                }

                _sideC = value;
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
           
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Invalid triangle sides.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            // Используем формулу Герона.
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        public bool IsRightTriangle()
        {
            double a = SideA;
            double b = SideB;
            double c = SideC;

            // Находим максимальную сторону (гипотенузу)
            double max = Math.Max(a, Math.Max(b, c));

            if (max == a)
            {
                return Math.Abs(a * a - (b * b + c * c)) < 0.0001;
            }
            else if (max == b)
            {
                return Math.Abs(b * b - (a * a + c * c)) < 0.0001;
            }
            else
            {
                return Math.Abs(c * c - (a * a + b * b)) < 0.0001;
            }

            // Для проверки равенства чисел с плавающей точкой лучше использовать сравнение с некоторым допустимым отклонением (точностью), чтобы избежать ошибок, связанных с особенностями работы с числами с плавающей точкой в памяти.
        }
    }
}
