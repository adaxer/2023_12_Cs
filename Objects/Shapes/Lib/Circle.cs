namespace Shapes.Lib;

public sealed class Circle : ShapeBase, IControl
{
    public Circle(double radius) : base() 
    {
        Radius = radius;
    }

    public double Radius { get; }
    public IControl? Parent { get; set; }

    public override void Draw()
    {
        PrepareDraw();
        Console.WriteLine("Zeichne Kreis");
    }

    public void SetPosition(double x, double y)
    {
        Console.WriteLine($"Verschoben auf Position ({x}, {y})");
    }
}

public interface IControl 
{
    IControl? Parent { get; set; }
    void SetPosition(double x, double y);
}
