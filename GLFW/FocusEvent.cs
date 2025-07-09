using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void FocusCallback(nint window, bool focused);

public delegate void FocusEventHandler(object? sender, FocusEventArgs args);

public sealed class FocusEventArgs : EventArgs
{
	public bool Focused { get; }

	public FocusEventArgs(bool focused) => this.Focused = focused;
}
