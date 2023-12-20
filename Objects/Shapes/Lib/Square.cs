namespace Shapes.Lib;

public class Square : Rectangle
{
    public Square() : this(10)
    {
    }

    public Square(double side) : base(side, side)
    {
    }

    public double Side => Width; // ctor gibt es nur für Seitenlänge

    //public override void Draw()
    //{
    //    Console.WriteLine("Zeichne Rechteck");
    //}
}
