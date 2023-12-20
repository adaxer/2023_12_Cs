using System.Windows;
using System.Windows.Media;

namespace ShapeUI.Lib;

public class Rectangle : ShapeBase
{
    public Rectangle() : this(200, 100)
    {
    }

    public Rectangle(double width, double height) : base()
    {
        this.Width = width;
        Height = height;
    }

    protected override void OnRender(DrawingContext drawingContext)
    {
        PrepareDraw();
        drawingContext.DrawRectangle(_brush, _pen, new Rect(0,0, ActualWidth, ActualHeight));
    }
}
