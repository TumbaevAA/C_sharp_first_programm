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
            Console.WriteLine("Distance to origin = " + Point.distanceToOrigin(p));


            Console.ReadLine();  
        }
    }
}
