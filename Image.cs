#pragma warning disable CS0649

using System;

namespace GLFW;

public readonly struct Image 
{
	private readonly nint handle;

	public unsafe int Width => ((int*)handle)[0];
	public unsafe int Height => ((int*)handle)[1];

	public unsafe Color this[int x, int y] 
	{
		set => ((uint*)handle)[x + y * Width] = (x < 0 || x > Width || y < 0 || y > Height) ? throw new ArgumentOutOfRangeException() : (uint)value;
		get => (x < 0 || x > Width || y < 0 || y > Height) ? throw new ArgumentOutOfRangeException() : (Color)(((uint*)handle)[x + y * Width]);
	}

	public static bool operator == (Image a, Image b) => a.handle == b.handle;
	public static bool operator != (Image a, Image b) => a.handle != b.handle;
	public override bool Equals(object? other) => (other is Image x) ? x.handle == handle : false;

	public override string ToString() => handle.ToString();
	public override int GetHashCode() => handle.GetHashCode();
}
