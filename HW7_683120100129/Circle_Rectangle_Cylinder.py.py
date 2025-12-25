import math
##########################         Circle        #########################################
class Circle:
    def __init__(self, radius: float = 1.0):
        self.radius = radius
        
    @property
    def radius(self):
        return self.__radius
    
    @radius.setter
    def radius(self, radius: float):
        self.__radius = radius
        
    def area(self):
        return math.pi * self.__radius ** 2
    
    def info(self):
        return f"Circle [radius: {self.__radius:.2f}, area: {self.area():.2f}]"

#######################################   Rectangle     #################################################################
class Rectangle:
    def __init__(self, width: float = 1.0, height: float = 1.0):
        self.__width = width
        self.__height = height

    @property 
    def width(self):
        return self.__width

    @property
    def height(self):
        return self.__height

    def area(self):
        return self.__width * self.__height
    
    def info(self):
        return f"Rectangle [width: {self.__width:.2f}, height: {self.__height:.2f}, area: {self.area():.2f}]"

###################################     Cylinder    #############################################
class Cylinder(Circle):
    def __init__(self, radius: float = 1.0, length: float = 1.0):
        super().__init__(radius)
        self.length = length

    @property
    def length(self):
        return self.__length

    @length.setter
    def length(self, length: float):
        self.__length = length

    def area(self):
        return 2 * math.pi * self.radius * (self.radius + self.__length)

    def volume(self):
        return math.pi * self.radius ** 2 * self.__length

    def info(self):
        return (f"Cylinder [radius: {self.radius:.2f}, length: {self.__length:.2f}, "
                f"area: {self.area():.2f}, volume: {self.volume():.2f}]")


m1 = Circle(4.6)
print(m1.info())

h1 = Rectangle(4.6, 3.2)
print(h1.info())

c1 = Cylinder(3.0, 10.0)
print(c1.info())