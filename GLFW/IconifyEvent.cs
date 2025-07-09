using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void IconifyCallback(nint window, bool iconified);

public delegate void IconifyEventHandler(object? sender, IconifyEventArgs args);

public sealed class IconifyEventArgs : EventArgs
{
	public bool Iconified { get; }

	public IconifyEventArgs(bool iconified) => this.Iconified = iconified;
}
