using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab6
{
    abstract class GeometricFigure : IOInterface
    {
        protected string description;

        public GeometricFigure(string description)
        {
            this.description = description;
        }

        public GeometricFigure()
        {
        }

        public string getDescription()
        {
            return description;
        }

        public abstract double area();
        public abstract double perimeter();
        public abstract bool input();
        public abstract void output();
    }
}
