using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab6
{
    class Square
    {
        private Point firstPoint;
        private Point secondPoint;
        private Point thirdPoint;
        private Point fourthPoint;

        public Square()
        {
        }

        private Point getFirstPoint()
        {
            return firstPoint;
        }
        private Point getSecondPoint()
        {
            return secondPoint;
        }
        private Point getThirdPoint()
        {
            return thirdPoint;
        }
        private Point getFourthPoint()
        {
            return fourthPoint;
        }
        public bool init(Point first, Point second, Point third, Point fourth)
        {
            if (first == null || second == null || third == null || fourth == null) return false;

            double d1 = first.distance(second), d2 = second.distance(third), d3 = third.distance(fourth), d4 = fourth.distance(first);

            if (d1 == 0 || d2 == 0 || d3 == 0 || d4 == 0 ||                                           //Если какие-то точки совпадают, возвращаем false
                first.distance(third) == 0 || second.distance(fourth) == 0 ||

                d1 != d2 || d1 != d3 || d1 != d4 || d2 != d3 || d2 != d4 || d3 != d4)                 //Если стороны не равны, возвращаем false
            {                
                return false;
            }
            else
            {
                this.firstPoint = first;
                this.secondPoint = second;
                this.thirdPoint = third;
                this.fourthPoint = fourth;

                return true;
            }
        }

        public bool input()
        {
            Point first = new Point(), second = new Point(), third = new Point(), fourth = new Point();

            if (first.input() && second.input() && third.input() && fourth.input())
            {
                return this.init(first, second, third, fourth);
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

        public void output()
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

            Console.WriteLine("Line length = {0}, perimeter = {1}, area = {2}", this.lineLength(), this.perimeter(), this.area());

            Console.WriteLine("----------------------------------------------");

        }

        public double lineLength()
        {
            return this.firstPoint.distance(secondPoint);
        }

        public double perimeter()
        {
            return 4 * this.lineLength();
        }

        public double area()
        {
            return this.lineLength() * this.lineLength();
        }
    }
}
