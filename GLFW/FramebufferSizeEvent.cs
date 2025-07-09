using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void FramebufferSizeCallback(nint window, int width, int height);

public delegate void FramebufferSizeEventHandler(object? sender, FramebufferSizeEventArgs args);

public sealed class FramebufferSizeEventArgs : EventArgs
{
	public int Width { get; }
	public int Height { get; }

	public FramebufferSizeEventArgs(int width, int height) => (this.Width, this.Height) = (width, height);
}
