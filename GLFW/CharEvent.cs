using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void CharCallback(nint window, uint codepoint);

public delegate void CharEventHandler(object? sender, CharEventArgs args);

public sealed class CharEventArgs : EventArgs
{
	public uint CodePoint { get; }

	public char Char => (char)CodePoint;

	public CharEventArgs(uint codepoint) => this.CodePoint = codepoint;
}
