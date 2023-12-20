namespace Shapes.Lib;

public class EmptyShape : ShapeBase
{
    public override void Draw()
    {
        Console.WriteLine("Kann mich nicht zeichnen");
    }
}
