using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ylesanne1_2
{
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point(double x = 0.0, double y = 0.0)
        {
            this.x = x;
            this.y = y;

        }

        public override string ToString()
        {
            return string.Format("x: {0}\n" + "y: {1}\n" + "rho: {2}\n" + "theta: {3}", x, y, rho(), theta());
        }

        //queries
        internal double rho()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        internal double theta()
        {
            return Math.Atan2(y, x);
        }

        internal double distance(Point p)
        {
            return vectorTo(p).rho();
        }

        internal Point vectorTo(Point p)
        {
            return new Point(p.x - x, p.y - y);
        }

        //commands
        internal void translate(double dx, double dy)
        {
            x += dx;
            y += dy;
        }

        internal void scale(double factor)
        {
            x *= factor;
            y *= factor;
        }

        internal void centre_rotate(double angle)
        {
            double temp_x = rho() * Math.Cos(theta() + angle);
            double temp_y = rho() * Math.Sin(theta() + angle);
            x = temp_x;
            y = temp_y;
        }

        internal void rotate(Point p, double angle)
        {
            translate(-p.x, -p.y);
            centre_rotate(angle);
            translate(p.x, p.y);
        }
    }
}
