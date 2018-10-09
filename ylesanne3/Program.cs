using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            Route route = new Route();

            Point p1 = new Point(0,1);
            Point p2 = new Point(0,2);
            Point p3 = new Point(0,3);

            route.add_point(p1.x, p1.y, 0);
            route.add_point(p2.x, p2.y, 1);
            route.add_point(p3.x, p3.y, 2);

            var length = route.get_length();
            Console.WriteLine(length);
        }
    }
}
