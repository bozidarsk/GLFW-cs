using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void CloseCallback(nint window);

public delegate void CloseEventHandler(object? sender, CloseEventArgs args);

public sealed class CloseEventArgs : EventArgs
{
}
