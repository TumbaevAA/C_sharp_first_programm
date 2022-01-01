using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab6
{
    struct Line
    {
        private Point startPoint;
        private Point endPoint;

        public Point StartPoint { get => startPoint; }
        public Point EndPoint { get => endPoint; }

        public double length => this.startPoint.distance(this.endPoint); 

        public bool init(Point start, Point end)
        {
            if (start == null || end == null) return false;
            else
            {
                this.startPoint = start;
                this.endPoint = end;

                return true;
            }               
        }

        public bool input()
        {
            Point start = new Point(), end = new Point();

            if (start.input() && end.input())
            {
                return this.init(start, end);    
            }
            else
            {
                this.startPoint = new Point();
                this.endPoint = new Point();
                return false;
            }
        }

        public void output()
        {
            Console.WriteLine("Start of the line: ");
            this.startPoint.output();

            Console.WriteLine("End of the line: ");
            this.endPoint.output();

            Console.WriteLine("Lenght of the line: {0}", this.length);
        }

        public bool isPointOnLine(Point point)
        {
            if (point == null) return false;

            if (this.startPoint.distance(point) + 
                this.endPoint.distance(point) == this.length) 
                return true;

            return false;
        }
    }
}
