namespace Shapes.Lib;

public abstract class ShapeBase
{
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
    public abstract void Draw();
	protected void PrepareDraw()
	{
		// Zeichnen vorbereiten
	}
}
