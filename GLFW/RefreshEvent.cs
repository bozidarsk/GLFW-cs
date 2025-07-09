using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void RefreshCallback(nint window);

public delegate void RefreshEventHandler(object? sender, RefreshEventArgs args);

public sealed class RefreshEventArgs : EventArgs
{
}
