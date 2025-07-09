using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void ContentScaleCallback(nint window, float x, float y);

public delegate void ContentScaleEventHandler(object? sender, ContentScaleEventArgs args);

public sealed class ContentScaleEventArgs : EventArgs
{
	public float x { get; }
	public float y { get; }

	public ContentScaleEventArgs(float x, float y) => (this.x, this.y) = (x, y);
}
