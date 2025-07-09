using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void MaximizeCallback(nint window, bool maximized);

public delegate void MaximizeEventHandler(object? sender, MaximizeEventArgs args);

public sealed class MaximizeEventArgs : EventArgs
{
	public bool Maximized { get; }

	public MaximizeEventArgs(bool maximized) => this.Maximized = maximized;
}
