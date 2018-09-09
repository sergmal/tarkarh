from Geom import Point
import math

#xpetus
p = Point()
p.translate(42,11)
p.theta()
print(p)

#leia kaugus
p1 = Point(10,20)
p2= Point(17,0)
dist = p1.distance(p2)
print(dist)

#keera ymber alguspunkti
p3 = Point(15,17)
p3.centre_rotate(math.pi/3)
print(p3)
