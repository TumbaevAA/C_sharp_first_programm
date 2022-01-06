﻿using System;
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
            Console.WriteLine("Array init test");
            Point[] pointArr = { new Point(0348), new Point(999), new Point(0) };
            foreach(Point point in pointArr)
            {
                Console.WriteLine("\nInput Coordinates of the point");
                point.input();
                point.output();
            }

            Console.WriteLine("\n\n\nCircle constructors test");
            Point center = new Point(0, 0);
            Circle c = new Circle(center, 6), c1 = new Circle();
            c.output();
            Console.WriteLine("Enter radius and center of the circle");
            c1.input();
            c1.output();
                

            Console.WriteLine("\n\n\nSquare constructors test");
            Point pointForSquare = new Point(0, 0), pointForSquare1 = new Point(1, 0),
                pointForSquare2 = new Point(1, 1), pointForSquare3 = new Point(0, 1);
            Square s = new Square(pointForSquare, pointForSquare1, pointForSquare2, pointForSquare3),
                s1 = new Square();
            s.output();
            Console.WriteLine("Enter first, second, third and fourth points of the triangle");
            s1.input();
            s1.output();

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
