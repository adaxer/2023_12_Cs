using System.Windows;
using System.Windows.Media;

namespace ShapeUI.Lib;

public sealed class Circle : ShapeBase
{
    public Circle() : this(100)
    {
    }

    public Circle(double radius) : base() 
    {
        Radius = radius;
    }

    public double Radius { get; set; }

    protected override void OnRender(DrawingContext drawingContext)
    {
        PrepareDraw();
        drawingContext.DrawEllipse(_brush, _pen, new Point(ActualWidth / 2, ActualHeight / 2), Radius, Radius);
    }
}
