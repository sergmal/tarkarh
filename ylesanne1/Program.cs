using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ylesanne1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Point(10, 20);
            var p2 = new Point(17, 0);
            var distance = p.distance(p2);
            Console.WriteLine(distance);

            var p3 = new Point(15, 17);
            p3.centre_rotate(Math.PI / 3);
            Console.WriteLine(p3);

            //exit
            Console.ReadKey();
        }
    }
}
