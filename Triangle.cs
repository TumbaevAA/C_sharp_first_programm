using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab6
{
    class Triangle
    {
        private Point firstPoint;
        private Point secondPoint;
        private Point thirdPoint;

        public Point FirstPoint { get => firstPoint; }
        public Point SecondPoint { get => secondPoint; }
        public Point ThirdPoint { get => thirdPoint; }

        public Triangle()
        {
        }

        public Triangle (Point first, Point second, Point third)
        {
            double d1 = first.distance(second), d2 = second.distance(third), d3 = third.distance(first);

            if (d1 == 0 || d2 == 0 || d3 == 0 ||                   //Если какие-то точки совпадают - не иницилизируем
                d1 == d2 + d3 || d2 == d1 + d3 || d3 == d1 + d2)   //Если точка лежит на отрезке между двумя другими - не инициализируем
            {}
            else
            {
                this.firstPoint = first;
                this.secondPoint = second;
                this.thirdPoint = third;
            }
        }

        public bool input()
        {
            Point first = new Point(), second = new Point(), third = new Point();

            if (first.input() && second.input() && third.input())
            {
                this.firstPoint = first;
                this.secondPoint = second;
                this.thirdPoint = third;

                return true;
            }
            else
            {
                this.firstPoint = new Point();
                this.secondPoint = new Point();
                this.thirdPoint = new Point();

                return false;
            }
        }

        public void output()
        {
            Console.WriteLine("Triangle\n----------------------------------------------");

            Console.WriteLine("Points");
            Console.WriteLine("first: ");
            this.firstPoint.output();
            Console.WriteLine("second: ");
            this.secondPoint.output();
            Console.WriteLine("third: ");
            this.thirdPoint.output();

            Console.WriteLine("\nLine lengths");
            Console.WriteLine("first = {0}", this.lineLength(1));
            Console.WriteLine("second = {0}", this.lineLength(2));
            Console.WriteLine("third = {0}", this.lineLength(3));

            Console.WriteLine("Perimeter = {0}, area = {1}", this.perimeter, this.area);

            Console.WriteLine("----------------------------------------------");

        }


        public double lineLength(int lineNumber)
        {
            switch (lineNumber)
            {
                case 1:
                    return this.firstPoint.distance(this.secondPoint);
                    break;
                case 2:
                    return this.secondPoint.distance(this.thirdPoint);
                    break;
                case 3:
                    return this.thirdPoint.distance(this.firstPoint);
                    break;
                default:
                    return -1;
            }
        }

        public double perimeter
        {
            get
            {
                double perimeter = 0;
                for (int i = 1; i < 4; i++)
                {
                    perimeter += this.lineLength(i);
                }

                return perimeter;
            }
        }

        public double area
        {
            get
            {
                double semiPerimeter = this.perimeter / 2;
                return Math.Sqrt(semiPerimeter * (semiPerimeter - this.lineLength(1)) * (semiPerimeter - this.lineLength(2)) * (semiPerimeter - this.lineLength(3)));
            }
        }
    }
}
