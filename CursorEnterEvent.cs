using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void CursorEnterCallback(nint window, bool entered);

public delegate void CursorEnterEventHandler(object? sender, CursorEnterEventArgs args);

public sealed class CursorEnterEventArgs : EventArgs
{
	public bool Entered { get; }

	public CursorEnterEventArgs(bool entered) => this.Entered = entered;
}
