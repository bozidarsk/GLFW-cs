using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void PositionCallback(nint window, int x, int y);

public delegate void PositionEventHandler(object? sender, PositionEventArgs args);

public sealed class PositionEventArgs : EventArgs
{
	public int x { get; }
	public int y { get; }

	public PositionEventArgs(int x, int y) => (this.x, this.y) = (x, y);
}
