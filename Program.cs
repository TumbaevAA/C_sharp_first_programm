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
            Console.WriteLine("\n\n\nTriangle constructors test");
            Point pointForTriangle = new Point(0, 0), pointForTriangle1 = new Point(1, 0), 
                pointForTriangle2 = new Point(0, 1);
            Triangle t = new Triangle(pointForTriangle, pointForTriangle1, pointForTriangle2),
                t1 = new Triangle();
            t.output();
            Console.WriteLine("Enter first, second and third points of the triangle");
            t1.input();
            t1.output();



            Console.WriteLine("\n\n\nPoint constructors test");
            Point p = new Point(3, 4), p1 = new Point(1234), p2 = new Point();
            p.output();
            Console.WriteLine("Enter coordinates of the second point");
            p1.input();
            p1.output();
            Console.WriteLine("Enter coordinates of the third point");
            p2.input();
            p2.output();


            Console.WriteLine("\n\n\nLine constructors test");
            Line l = new Line(p, p1), l1 = new Line();
            l.output();
            Console.WriteLine("Enter start and end points of the line");
            l1.input();
            l1.output();
            Console.ReadLine();
        }
    }
}
