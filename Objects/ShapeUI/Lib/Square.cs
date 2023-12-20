using System.Windows.Media;
using System.Windows;

namespace ShapeUI.Lib;

public class Square : Rectangle
{
    public Square() : this(100)
    {
    }

    public Square(double side) : base(side, side)
    {
    }

    public double Side { get; set; }

    protected override void OnRender(DrawingContext drawingContext)
    {
        PrepareDraw();
        drawingContext.DrawRectangle(_brush, _pen, new Rect(0, 0, Side, Side));
    }
}
