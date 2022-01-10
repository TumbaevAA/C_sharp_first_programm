using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тест Triangle
            Point pForTriangle = new Point(0, 0), pForTriangle1 = new Point(0, 1), pForTriangle2 = new Point(1, 0);
            Triangle t;
            try
            {
                t = new Triangle(pForTriangle, null, pForTriangle1);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Catching ArgumentNullException when using Triangle constructor");
            }

            try
            {
                t = new Triangle(pForTriangle, pForTriangle, pForTriangle2);
            }
            catch(Exception)
            {
                Console.WriteLine("Catching Exception when using Triangle constructor " +
                    "with wrong points");
            }
            t = new Triangle(pForTriangle, pForTriangle1, pForTriangle2);
            t.input();


            //Тест Line
            Point pForLine = new Point(0, 0), pForLine1 = new Point(7, 0), pForLine2 = new Point(5, 5);
            Line l = new Line(pForLine, pForLine1), nullLine;
            try
            {
                nullLine = new Line(null, pForLine);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Catching ArgumentNullException when using Line constructor");
            }
            try
            {
                l.isPointOnLine(null);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Catching ArgumentNullException when using isPointOnLine");
            }
            l.input();


            //Тест Point
            try
            {
                Point.distanceToOrigin(null);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Catching ArgumentNullException when using distanceToOrigin");
            }

            Point p = new Point(8, 8);
            try
            {
                p.distance(null);
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Catching ArgumentNullException when using distance");
            }

            p.input();

            Console.ReadLine();
        }
    }
}
