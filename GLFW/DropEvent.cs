using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal unsafe delegate void DropCallback(nint window, int count, sbyte** paths);

public delegate void DropEventHandler(object? sender, DropEventArgs args);

public sealed class DropEventArgs : EventArgs
{
	public string[] Paths { get; }

	public DropEventArgs(string[] paths) => this.Paths = paths;
}
