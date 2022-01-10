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
            try
            {
                Point.distanceToOrigin(null);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Catching ArgumntNullException when using distanceToOrigin");
            }

            Point p = new Point(8, 8);
            try
            {
                p.distance(null);
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Catching ArgumntNullException when using distance");
            }

            p.input();

            Console.ReadLine();
        }
    }
}
