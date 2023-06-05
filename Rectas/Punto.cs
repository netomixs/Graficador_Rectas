using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectas
{
    public class Punto
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int xEnter { get; set;}

        public Punto(double x, double y)
        {
            X = x;
            Y = y;
            xEnter = (int)X;
        }
        public Punto()
        {
            xEnter = (int)X;

        }
        public int getX()
        {
            return (int)X;
        }
        public int getY()
        {
            return (int)Y;
        }
    }
}
