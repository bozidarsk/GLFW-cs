#pragma warning disable CS0649

using System;
using System.Runtime.InteropServices;

using static GLFW.Constants;

namespace GLFW;

public readonly struct Cursor : IDisposable
{
	private readonly nint handle;

	public void Dispose() 
	{
		glfwDestroyCursor(this);

		[DllImport(GLFW_LIB)] static extern void glfwDestroyCursor(Cursor cursor);
	}

	public static bool operator == (Cursor a, Cursor b) => a.handle == b.handle;
	public static bool operator != (Cursor a, Cursor b) => a.handle != b.handle;
	public override bool Equals(object? other) => (other is Cursor x) ? x.handle == handle : false;

	public override string ToString() => handle.ToString();
	public override int GetHashCode() => handle.GetHashCode();

	public Cursor(Image image, int xhot, int yhot) 
	{
		this = glfwCreateCursor(image, xhot, yhot);

		[DllImport(GLFW_LIB)] static extern Cursor glfwCreateCursor(Image image, int xhot, int yhot);
	}

	public Cursor(CursorShape shape) 
	{
		this = glfwCreateStandardCursor(shape);

		[DllImport(GLFW_LIB)] static extern Cursor glfwCreateStandardCursor(CursorShape shape);
	}
}
