using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ylesanne3
{
    public class Route
    {
        public Dictionary<int, Point> points = new Dictionary<int, Point>();


        public Route create_route()
        {
            return new Route();
        }

        public void add_point(double x, double y, int index)
        {
            if (index >= 0 && index <= points.Count)
            {
                var point = new Point(x, y);

                if (points.ContainsKey(index))
                {
                    foreach (var p in points)
                    {
                        if (p.Key >= index)
                        {
                            Point val = p.Value;
                            int key = p.Key;
                            points.Remove(key);
                            points.Add(key + 1, val);
                        }
                    }
                }
                points.Add(index, point);


            }
        }

        public void remove_point(int index)
        {
            if ((index >= 0 && index <= points.Count) || index == 1)
            {
                points.Remove(index);
                if (points.ContainsKey(index))
                {
                    foreach (var p in points)
                    {
                        if (p.Key >= index)
                        {
                            Point val = p.Value;
                            int key = p.Key;
                            points.Remove(key);
                            points.Add(key - 1, val);
                        }
                    }
                }
            }
        }

        public double get_length()
        {
            double result = 0;
            if (points.Count > 1)
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    result += points[i].distance(points[i + 1]);
                }
            }

            return result;
        }
    }

}