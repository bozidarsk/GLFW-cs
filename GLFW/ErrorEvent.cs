using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
internal unsafe delegate void ErrorCallback(int code, sbyte* message);

public delegate void ErrorEventHandler(object? sender, ErrorEventArgs args);

public sealed class ErrorEventArgs : EventArgs
{
	public int Code { get; }
	public string Message { get; }

	public ErrorEventArgs(int code, string message) => (this.Code, this.Message) = (code, message);
}
