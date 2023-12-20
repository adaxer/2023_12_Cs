using System.Windows.Controls;
using System.Windows.Media;

namespace ShapeUI.Lib;

public abstract class ShapeBase : Control
{
	protected Brush? _brush;
	protected Pen? _pen;

	public ShapeBase()
	{
		Stroke = 0xFF000000; 
		Fill = 0x01FFFFFF;
	}

	private uint _stroke;

	public uint Stroke
	{
		get { return _stroke; }
		set
		{
			_stroke = value;
			if (value < 0x01000000)
			{
				//_color |= 0x01_00_00_00; 
				_stroke |= 0b00000001_00000000_00000000_00000000;
				// Exkurs: decimal x = 1_000_000.0m;
			}
		}
	}

    public uint Fill { get; set; }

	protected void PrepareDraw()
	{
		// Zeichnen vorbereiten
		byte a = (byte) (_stroke >> 24);
		byte r = (byte) (_stroke >> 16);
		byte g = (byte) (_stroke >> 8);
		byte b = (byte) _stroke;
        Color color = Color.FromArgb(a, r, g, b);
		_pen = new Pen(new SolidColorBrush(color), 2);
    
		a = (byte)(Fill >> 24);
        r = (byte)(Fill >> 16);
        g = (byte)(Fill >> 8);
        b = (byte) Fill;
         color = Color.FromArgb(a, r, g, b);
        _brush = new SolidColorBrush(color);
    }
}
