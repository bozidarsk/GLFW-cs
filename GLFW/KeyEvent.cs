using System;
using System.Runtime.InteropServices;

namespace GLFW;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate void KeyCallback(nint window, KeyCode key, int scancode, KeyState state, KeyModifier modifiers);

public delegate void KeyEventHandler(object? sender, KeyEventArgs args);

public sealed class KeyEventArgs : EventArgs
{
	public KeyCode Key { get; }
	public int Scancode { get; }
	public KeyState State { get; }
	public KeyModifier Modifiers { get; }

	public KeyEventArgs(KeyCode key, int scancode, KeyState state, KeyModifier modifiers) => (this.Key, this.Scancode, this.State, this.Modifiers) = (key, scancode, state, modifiers);
}
