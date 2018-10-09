using NUnit.Framework;
using ylesanne3;

namespace ylesanne3
{
    public class UnitTest1
    {
        [Test]
        public void AddPointTest()
        {
            Route route = new Route();
            route.add_point(1, 2, 0);
            Assert.IsTrue(route.points.Count > 0);
        }


        [Test]
        public void RemovePointTest()
        {
            Route route = new Route();
            route.add_point(1, 2, 0);
            route.remove_point(0);
            Assert.IsTrue(route.points.Count == 0);
        }

        [Test]
        public void Create_RouteTest()
        {
            Route R = new Route();
            Assert.IsNotNull(R.points);

        }

        [Test]
        public void RouteLength()
        {
            Route route = new Route();
            route.add_point(0, 1, 0);
            route.add_point(0, 2, 1);
            route.add_point(0, 3, 2);

            var length = route.get_length();
            Assert.IsTrue(length == 2.0);
        }

    }
}
