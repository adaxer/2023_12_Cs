using Shapes.Lib;

namespace Shapes;

internal class Program
{
    static void Main(string[] args)
    {
        //ShapeBase aShape = new ShapeBase();
       
        Circle circle = new Circle(20);
        circle.Stroke = 0x00000000;
        //circle.PrepareDraw();
        circle.Draw();

        Rectangle rectangle = new Rectangle(10,20);
        rectangle.Stroke = 0xFFFF0000;
        rectangle.Draw();

        var shapes = new ShapeBase[]
        {
            circle,
            rectangle,
            new EmptyShape(),
            new Square()
        };

        foreach (var shape in shapes)
        {
            //if(shape is Circle circle1)
            //{
            //    circle1.Draw();
            //}
            //else if(shape is Rectangle rectangle1)
            //{
            //    rectangle1.Draw();
            //}
            shape.Draw();
        }

        Console.ReadLine();
    }
}
