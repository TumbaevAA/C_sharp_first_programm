using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab6
{
    class Point
    {
        private double x;
        private double y;

        public double X { get => x; }
        public double Y { get => y; }

        public Point()
        {
        }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public bool input()
        {
            try
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());

                this.x = x;
                this.y = y;
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public void output()
        {
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
        public double distance(Point end)
        {
            if (end == null) return -1;

            double d1 = end.x - this.x, d2 = end.y - this.y;
            return Math.Sqrt(d1 * d1 + d2 * d2);
        }

        public static Point operator ++(Point p)
        {
            p.x++;
            p.y++;
            return p;
        }

        public static Point operator +(Point p1, Point p2)
        {
            Point p = new Point();

            p.x = p1.x + p2.y;
            p.y = p1.y + p2.y;

            return p;
        }

    }
}
