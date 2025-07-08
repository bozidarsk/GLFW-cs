using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void MouseButtonCallback(nint window, KeyCode button, KeyState state, KeyModifier modifiers);

public delegate void MouseButtonEventHandler(object? sender, MouseButtonEventArgs args);

public sealed class MouseButtonEventArgs : EventArgs
{
	public KeyCode Button { get; }
	public KeyState State { get; }
	public KeyModifier Modifiers { get; }

	public MouseButtonEventArgs(KeyCode button, KeyState state, KeyModifier modifiers) => (this.Button, this.State, this.Modifiers) = (button, state, modifiers);
}
