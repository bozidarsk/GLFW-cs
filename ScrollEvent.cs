using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void ScrollCallback(nint window, double x, double y);

public delegate void ScrollEventHandler(object? sender, ScrollEventArgs args);

public sealed class ScrollEventArgs : EventArgs
{
	public double x { get; }
	public double y { get; }

	public ScrollEventArgs(double x, double y) => (this.x, this.y) = (x, y);
}
