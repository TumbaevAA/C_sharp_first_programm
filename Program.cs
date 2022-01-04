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
            Console.WriteLine("Determining the distance to the origin\nEnter coordinates of the point");
            Point p = new Point();
            p.input();
            p.output();
            Console.WriteLine("Distance to origin = " + Point.distanceToOrigin(p));


            Console.WriteLine("Id generartion with static field");
            Point p1 = new Point(1, 1), p2 = new Point(2, 2), p3 = new Point(3, 3);
            p1.output();
            p2.output();
            p3.output();

            
            Console.ReadLine();  
        }
    }
}
