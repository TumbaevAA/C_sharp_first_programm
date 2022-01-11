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
            Point[,] twoDimensionalPointArr = new Point[2, 3];
            for (int i = 0; i < twoDimensionalPointArr.GetLength(0); i++)
                for (int j = 0; j < twoDimensionalPointArr.GetLength(1); j++)
                {
                    twoDimensionalPointArr[i, j] = new Point();
                    Console.WriteLine("Enter coordinates of the {0} point in the {1} row", j, i);
                    twoDimensionalPointArr[i, j].input();
                    twoDimensionalPointArr[i, j].output();
                }


            Point[] pointArr = new Point[3];

            for (int i = 0; i < pointArr.Length; i++) {
   
                pointArr[i] = new Point();
                Console.WriteLine("Enter coordinates of the {0} point", i);
                pointArr[i].input();
                pointArr[i].output();
            }

            Console.ReadLine();
        }
    }
}
