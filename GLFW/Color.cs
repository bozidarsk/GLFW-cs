using System.Runtime.InteropServices;

namespace GLFW;

[StructLayout(LayoutKind.Sequential)]
public struct Color 
{
	public float r, g, b, a;

	public static readonly Color Black = new Color(0f, 0f, 0f, 1f);
	public static readonly Color White = new Color(1f, 1f, 1f, 1f);

	public static Color operator * (Color a, float x) => new Color(a.r * x, a.g * x, a.b * x, a.a * x);
	public static Color operator / (Color a, float x) => new Color(a.r / x, a.g / x, a.b / x, a.a / x);
	public static Color operator * (float x, Color a) => new Color(a.r * x, a.g * x, a.b * x, a.a * x);
	public static Color operator / (float x, Color a) => new Color(a.r / x, a.g / x, a.b / x, a.a / x);
	public static Color operator + (Color a, Color b) => new Color(a.r + b.r, a.g + b.g, a.b + b.b, a.a + b.a);
	public static Color operator - (Color a, Color b) => new Color(a.r - b.r, a.g - b.g, a.b - b.b, a.a - b.a);

	public static explicit operator uint(Color color) 
	{
		uint result = 0;

		result <<= 8;
		result |= (uint)(color.r * 255f) & 0xff;

		result <<= 8;
		result |= (uint)(color.g * 255f) & 0xff;

		result <<= 8;
		result |= (uint)(color.b * 255f) & 0xff;

		result <<= 8;
		result |= (uint)(color.a * 255f) & 0xff;

		return result;
	}

	public static explicit operator Color(uint color) 
	{
		Color result = new();

		result.r = (float)((color >> 3 * 8) & 0xff) / 255f;
		result.g = (float)((color >> 2 * 8) & 0xff) / 255f;
		result.b = (float)((color >> 1 * 8) & 0xff) / 255f;
		result.a = (float)((color >> 0 * 8) & 0xff) / 255f;

		return result;
	}

	public override string ToString() => $"({r}, {g}, {b}, {a})";

	public Color(float r, float g, float b, float a = 1f) => (this.r, this.g, this.b, this.a) = (r, g, b, a);
}
