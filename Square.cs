using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab6
{
    class Square : GeometricFigure
    {
        private Point firstPoint;
        private Point secondPoint;
        private Point thirdPoint;
        private Point fourthPoint;

        public Point FirstPoint { get => firstPoint; }
        public Point SecondPoint { get => secondPoint; }
        public Point ThirdPoint { get => thirdPoint; }
        public Point FourthPoint { get => fourthPoint; }

        public Square()
        {
        }

        public Square(Point first, Point second, Point third, Point fourth, string description)
            : base(description)
        {
            if (first == null || second == null || third == null || fourth == null) throw new ArgumentNullException();

            double d1 = first.distance(second), d2 = second.distance(third), d3 = third.distance(fourth), d4 = fourth.distance(first);

            if (d1 == 0 || d2 == 0 || d3 == 0 || d4 == 0 ||                                           //Если какие-то точки совпадают - не инициализируем
                first.distance(third) == 0 || second.distance(fourth) == 0 ||

                d1 != d2 || d1 != d3 || d1 != d4 || d2 != d3 || d2 != d4 || d3 != d4)                 //Если стороны не равны, возвращаем - не инициаилизируем
            { throw new Exception(); }
            else
            {
                this.firstPoint = first;
                this.secondPoint = second;
                this.thirdPoint = third;
                this.fourthPoint = fourth;
            }
        }
        public double lineLength => this.firstPoint.distance(secondPoint);

        public override bool input()
        {
            Point first = new Point(), second = new Point(), third = new Point(), fourth = new Point();

            if (first.input() && second.input() && third.input() && fourth.input())
            {
                this.firstPoint = first;
                this.secondPoint = second;
                this.thirdPoint = third;
                this.fourthPoint = fourth;
                return true;
            }
            else
            {
                this.firstPoint = new Point();
                this.secondPoint = new Point();
                this.thirdPoint = new Point();
                this.fourthPoint = new Point();

                return false;
            }
        }

        public override void output()
        {
            Console.WriteLine("Square\n----------------------------------------------");

            Console.WriteLine("Points");
            Console.WriteLine("first: ");
            this.firstPoint.output();
            Console.WriteLine("second: ");
            this.secondPoint.output();
            Console.WriteLine("third: ");
            this.thirdPoint.output();
            Console.WriteLine("fourth: ");
            this.fourthPoint.output();

            Console.WriteLine("Line length = {0}, perimeter = {1}, area = {2}", this.lineLength, this.perimeter(), this.area());
            Console.WriteLine("----------------------------------------------");

        }

        public override double perimeter() => 4 * this.lineLength;

        public override double area() => this.lineLength * this.lineLength;
    }
}
