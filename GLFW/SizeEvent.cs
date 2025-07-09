using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void SizeCallback(nint window, int width, int height);

public delegate void SizeEventHandler(object? sender, SizeEventArgs args);

public sealed class SizeEventArgs : EventArgs
{
	public int Width { get; }
	public int Height { get; }

	public SizeEventArgs(int width, int height) => (this.Width, this.Height) = (width, height);
}
