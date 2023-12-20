namespace Shapes.Lib;

public class Rectangle : ShapeBase
{
    public Rectangle(double width, double height) : base()
    {
        this.Width = width;
        Height = height;
    }

    public double Width { get; }
    public double Height { get; }

    public override void Draw()
    {
        Console.WriteLine("Zeichne Rechteck");
    }
}
