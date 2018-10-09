using NUnit.Framework;

namespace ylesanne1_2
{
    public class UnitTest1
    {
        [Test]
        public void TestPointNotNull()
        {
            var p = new Point2(10, 20);
            Assert.IsNotNull(p);
            Assert.AreEqual(p.getX(), 10.0, 0.1);
            Assert.AreEqual(p.getY(), 20.0, 0.1);
            Assert.AreEqual(p.rho(), 22.360679774997898);
            Assert.AreEqual(p.theta(), 1.1071487177940904);

        }
        [Test]
        public void TestDistance()
        {
            var p1 = new Point2(10, 10);
            var p2 = new Point2(2, 3);
            Assert.AreEqual(p1.distance(p2), 10.63014581273465);

        }

        [Test]
        public void TestRotate()
        {
            var p1 = new Point2(10, 3);
            var p2 = new Point2(5, 5);

            var p3 = new Point2(10, 3);
            var p4 = new Point2(5, 5);

            p1.rotate(p2, 20.0);

            p3.translate(-p4.getX(), -p4.getY());
            p3.centre_rotate(20.0);
            p3.translate(p4.getX(), p4.getY());

            Assert.AreEqual(p1.ToString(), p3.ToString());
            Assert.AreEqual(p1.getX(), p3.getX());
            Assert.AreEqual(p1.getY(), p3.getY());
            Assert.AreEqual(p1.rho(), p3.rho());
            Assert.AreEqual(p1.theta(), p3.theta());

        }


    }
}
