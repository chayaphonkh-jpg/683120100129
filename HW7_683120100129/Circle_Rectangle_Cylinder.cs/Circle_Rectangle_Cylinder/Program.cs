namespace Circle_Rectangle_Cylinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle m1 = new Circle(4.6);
            Console.WriteLine(m1.Info());

            Rectangle h1 = new Rectangle(4.6, 3.2);
            Console.WriteLine(h1.Info());

            Cylinder c1 = new Cylinder(3.0, 10.0);
            Console.WriteLine(c1.Info());
        }
    }
}

///////////////////         Circle                  /////////////////////////////////
class Circle
{
    private double _radius;

    public Circle(double radius = 1.0)
    {
        Radius = radius;
    }

    public double Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }

    public virtual double Area()
    {
        return Math.PI * _radius * _radius;
    }

    public virtual string Info()
    {
        return $"Circle [radius: {Radius:F2}, area: {Area():F2}]";
    }
}
///////////            Rectangle    //////////////////////
class Rectangle
{
    private double _width;
    private double _height;

    public Rectangle(double width = 1.0, double height = 1.0)
    {
        _width = width;
        _height = height;
    }

    public double Width
    {
        get { return _width; }
    }

    public double Height
    {
        get { return _height; }
    }

    public double Area()
    {
        return _width * _height;
    }

    public string Info()
    {
        return $"Rectangle [width: {Width:F2}, height: {Height:F2}, area: {Area():F2}]";
    }
}
/////////////////////////////        Cylinder  ////////////////////////////////
class Cylinder : Circle
{
    private double _length;

    public Cylinder(double radius = 1.0, double length = 1.0)
        : base(radius)
    {
        Length = length;
    }

    public double Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public override double Area()
    {
        return 2 * Math.PI * Radius * (Radius + _length);
    }

    public double Volume()
    {
        return Math.PI * Radius * Radius * _length;
    }

    public override string Info()
    {
        return $"Cylinder [radius: {Radius:F2}, length: {Length:F2}, area: {Area():F2}, volume: {Volume():F2}]";
    }
}