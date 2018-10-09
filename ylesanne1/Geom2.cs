using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ylesanne1_2
{
    class Point2
    {
        public double x { get; set; }
        public double y { get; set; }
        public double _rho { get; set; }
        public double _theta { get; set; }

        public Point2(double x = 0.0, double y = 0.0)
        {
            _rho = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            _theta = Math.Atan2(y, x);


        }
        //queries
        public override string ToString()
        {
            return string.Format("x: {0}\n" + "y: {1}\n" + "rho: {2}\n" + "theta: {3}", getX(), getY(), rho(), theta());
        }

        public double getX()
        {
            return _rho * Math.Cos(_theta);
        }

        public double getY()
        {
            return rho() * Math.Sin(theta());
        }
       
        public double rho()
        {
            return _rho;
        }

        public double theta()
        {
            return _theta;
        }

        public double distance(Point2 p)
        {
            return vectorTo(p).rho();
        }

        public Point2 vectorTo(Point2 p)
        {
            return new Point2(p.getX() - getX(), p.getY() - getY());
        }

        //commands
        public void translate(double dx, double dy)
        {
            x = getX() + dx;
            y = getY() + dy;
            _rho = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            _theta = Math.Atan2(y, x);

        }

        public void scale(double factor)
        {
            _rho *= factor;
        }

        public void centre_rotate(double angle)
        {
            _theta = (_theta + angle) % (2 * Math.PI);
        }

        public void rotate(Point2 p, double angle)
        {
            translate(-p.getX(), -p.getY());
            centre_rotate(angle);
            translate(p.getX(), p.getY());
        }
    }
}
