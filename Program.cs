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

            //Тест Point
            Console.WriteLine("Point test\nEnter the coordinates of the first point");
            Point p = new Point(), p1 = new Point();
            p.input();
            p.output();

            Console.WriteLine("Enter the coordinates of the second point");
            p1.input();
            p1.output();

            Console.WriteLine("Distance between points: {0}", p.distance(p1));
            

            //Тест Line
            Console.WriteLine("\n\n\nLine test\nEnter the start and the end coordinates of the line");
            Line l = new Line();
            l.input();
            l.output();

            if (l.isPointOnLine(p))
            {
                Console.WriteLine("First point is on the line");
            }
            else
            {
                Console.WriteLine("First point isn't on the line");
            }

            //Тест Triangle
            Console.WriteLine("\n\n\nTriangle test\nEnter coordinates of the first, second and third points");
            Triangle t = new Triangle();
            t.input();
            t.output();

            //Тест Square
            Console.WriteLine("\n\n\nSquare test\nEnter coordinates of the first, second, third and fourth points");
            Square s = new Square();
            s.input();
            s.output();

            //Тест Circle 
            Console.WriteLine("\n\n\nCircle test\nEnter radius and coordinates of the center");
            Circle c = new Circle();
            c.input();
            c.output();


            Console.ReadLine();  
        }
    }
}
