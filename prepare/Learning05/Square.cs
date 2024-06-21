public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    // Notice the use of the override keyword here
    // override: used to extend and modify a virtual or abstract method
    // creates a new execution of inherited method with teh same name as the base class method
    public override double GetArea()
    {
        return _side * _side;
    }
}