import math

class Point:
    "Two-dimensional points"

    def __init__(self, x=0.0, y=0.0):
        self._rho = math.sqrt(x**2 + y**2)
        self._theta = math.atan2(y, x)

    def __str__(self):
        result = "\n".join(["x: %f" % self.x(),
                            "y: %f" % self.y(),
                            "rho: %f" % self.rho(),
                            "theta: %f" % self.theta()])
        return result

# Queries

    def x(self):
        "Abscissa"
        return self.rho()*math.cos(self.theta())

    def y(self):
        "Ordinate"
        return self.rho()*math.sin(self.theta())

    def rho(self):
        "Distance to origin (0, 0)"
        return self._rho

    def theta(self):
        "Angle to horizontal axis"
        return self._theta

    #Precondition: 	    other != none
	#Postcondition:     vectorTo(other).rho()
    def distance(self, other):
        "Distance to other"
        return self.vectorTo(other).rho()

    #Precondition: 	    other != none
	#Postcondition:     x() = other.x() - x()
	#                   y() = other.y() - y()
    def vectorTo(self, other):
        "Returns the Point representing the vector from self to other Point"
        return Point(other.x() - self.x(), other.y() - self.y())

# Commands

	#Precondition: 	    -
	#Postcondition:	    x() = old x() + dx
	#		            y() = old y() + dy 
    def translate(self, dx, dy):
        "Move by dx horizontally, dy vertically"
        x = self.x() + dx
        y = self.y() + dy
        self._rho = math.sqrt(x**2 + y**2)
        self._theta = math.atan2(y, x)

    #Precondition: 	    -
	#Postcondition:	    rho = old Rho() * factor
    def scale(self, factor):
        "Scale by factor"
        self._rho *= factor

    #Precondition:	    angle != none
	#Postcondition:	    theta() = (old theta() + angle) % (2*math.pi)
    def centre_rotate(self, angle):
        "Rotate around origin (0, 0) by angle"
        self._theta = (self._theta + angle) % (2 * math.pi)

    #Precondition:	    p != none
	#		            angle != none
    #Postcondition:	    p.vectorTo(this).theta() = (p.vectorTo(old this).theta() + angle) % (2*math.pi)
    def rotate(self, p, angle):
        "Rotate around p by angle"
        self.translate(-p.x(), -p.y())
        self.centre_rotate(angle)
        self.translate(p.x(), p.y())


#"Invariandid (tingimused, mis kehtivad kogu aeg):"
#x() = rho() * cos(theta())
#y() = rho() * sin(theta())
#rho() = sqrt(x() * x() + y() * y())
#theta() = atan2(y(),x())

