using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void CursorPositionCallback(nint window, double x, double y);

public delegate void CursorPositionEventHandler(object? sender, CursorPositionEventArgs args);

public sealed class CursorPositionEventArgs : EventArgs
{
	public double x { get; }
	public double y { get; }

	public CursorPositionEventArgs(double x, double y) => (this.x, this.y) = (x, y);
}
