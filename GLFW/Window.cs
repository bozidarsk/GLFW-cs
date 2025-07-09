#pragma warning disable CS0649

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

using static GLFW.Constants;

namespace GLFW;

public sealed class Window : IDisposable
{
	private readonly nint handle;

	private readonly KeyCallback keyCallback;
	public event KeyEventHandler? OnKey;

	private readonly CharCallback charCallback;
	public event CharEventHandler? OnChar;

	private readonly MouseButtonCallback mouseButtonCallback;
	public event MouseButtonEventHandler? OnMouseButton;

	private readonly CursorPositionCallback cursorPositionCallback;
	public event CursorPositionEventHandler? OnCursorPosition;

	private readonly CursorEnterCallback cursorEnterCallback;
	public event CursorEnterEventHandler? OnCursorEnter;

	private readonly ScrollCallback scrollCallback;
	public event ScrollEventHandler? OnScroll;

	private readonly DropCallback dropCallback;
	public event DropEventHandler? OnDrop;

	private readonly PositionCallback positionCallback;
	public event PositionEventHandler? OnPosition;

	private readonly SizeCallback sizeCallback;
	public event SizeEventHandler? OnSize;

	private readonly CloseCallback closeCallback;
	public event CloseEventHandler? OnClose;

	private readonly RefreshCallback refreshCallback;
	public event RefreshEventHandler? OnRefresh;

	private readonly FocusCallback focusCallback;
	public event FocusEventHandler? OnFocus;

	private readonly IconifyCallback iconifyCallback;
	public event IconifyEventHandler? OnIconify;

	private readonly MaximizeCallback maximizeCallback;
	public event MaximizeEventHandler? OnMaximize;

	private readonly ContentScaleCallback contentScaleCallback;
	public event ContentScaleEventHandler? OnContentScale;

	private readonly FramebufferSizeCallback framebufferSizeCallback;
	public event FramebufferSizeEventHandler? OnFramebufferSize;

	public string Title 
	{
		set 
		{
			glfwSetWindowTitle(this, value);

			[DllImport(GLFW_LIB)] static extern void glfwSetWindowTitle(nint window, string title);
		}
	}

	public nint UserPointer 
	{
		set 
		{
			glfwSetWindowUserPointer(this, value);

			[DllImport(GLFW_LIB)] static extern void glfwSetWindowUserPointer(nint window, nint pointer);
		}
		get 
		{
			return glfwGetWindowUserPointer(this);

			[DllImport(GLFW_LIB)] static extern nint glfwGetWindowUserPointer(nint window);
		}
	}

	public bool ShouldClose 
	{
		set 
		{
			glfwSetWindowShouldClose(this, value);

			[DllImport(GLFW_LIB)] static extern void glfwSetWindowShouldClose(nint window, bool shouldClose);
		}
		get 
		{
			return glfwWindowShouldClose(this);

			[DllImport(GLFW_LIB)] static extern bool glfwWindowShouldClose(nint window);
		}
	}

	public float Opacity 
	{
		set 
		{
			glfwSetWindowOpacity(this, value);

			[DllImport(GLFW_LIB)] static extern void glfwSetWindowOpacity(nint window, float opacity);
		}
		get 
		{
			return glfwGetWindowOpacity(this);

			[DllImport(GLFW_LIB)] static extern float glfwGetWindowOpacity(nint window);
		}
	}

	public (int, int) Position 
	{
		set 
		{
			(int x, int y) = value;
			glfwSetWindowPos(this, x, y);

			[DllImport(GLFW_LIB)] static extern void glfwSetWindowPos(nint window, int x, int y);
		}
		get 
		{
			glfwGetWindowPos(this, out int x, out int y);
			return (x, y);

			[DllImport(GLFW_LIB)] static extern void glfwGetWindowPos(nint window, out int x, out int y);
		}
	}

	public (int, int) Size 
	{
		set 
		{
			(int width, int height) = value;
			glfwSetWindowSize(this, width, height);

			[DllImport(GLFW_LIB)] static extern void glfwSetWindowSize(nint window, int width, int height);
		}
		get 
		{
			glfwGetWindowSize(this, out int width, out int height);
			return (width, height);

			[DllImport(GLFW_LIB)] static extern void glfwGetWindowSize(nint window, out int width, out int height);
		}
	}

	public (double, double) CursorPosition 
	{
		set 
		{
			(double x, double y) = value;
			glfwSetCursorPos(this, x, y);

			[DllImport(GLFW_LIB)] static extern void glfwSetCursorPos(nint window, double x, double y);
		}
		get 
		{
			glfwGetCursorPos(this, out double x, out double y);
			return (x, y);

			[DllImport(GLFW_LIB)] static extern void glfwGetCursorPos(nint window, out double x, out double y);
		}
	}

	public (int, int) FramebufferSize 
	{
		get 
		{
			glfwGetFramebufferSize(this, out int width, out int height);
			return (width, height);

			[DllImport(GLFW_LIB)] static extern void glfwGetFramebufferSize(nint window, out int width, out int height);
		}
	}

	public (float, float) ContentScale 
	{
		get 
		{
			glfwGetWindowContentScale(this, out float x, out float y);
			return (x, y);

			[DllImport(GLFW_LIB)] static extern void glfwGetWindowContentScale(nint window, out float x, out float y);
		}
	}

	public unsafe string ClipboardText 
	{
		set 
		{
			glfwSetClipboardString(this, value);

			[DllImport(GLFW_LIB)] static extern void glfwSetClipboardString(nint window, string text);
		}
		get 
		{
			return new(glfwGetClipboardString(this));

			[DllImport(GLFW_LIB)] static extern sbyte* glfwGetClipboardString(nint window);
		}
	}

	public Image Icon 
	{
		set 
		{
			glfwSetWindowIcon(this, 1, value);

			[DllImport(GLFW_LIB)] static extern void glfwSetWindowIcon(nint window, int count, Image image);
		}
	}

	public Cursor Cursor 
	{
		set 
		{
			glfwSetCursor(this, value);

			[DllImport(GLFW_LIB)] static extern void glfwSetCursor(nint window, Cursor cursor);
		}
	}

	public Monitor Monitor 
	{
		get 
		{
			return glfwGetWindowMonitor(this);

			[DllImport(GLFW_LIB)] static extern Monitor glfwGetWindowMonitor(nint window);
		}
	}

	public void SetMonitor(Monitor monitor, int x, int y, int width, int height, int refreshRate) 
	{
		glfwSetWindowMonitor(this, monitor, x, y, width, height, refreshRate);

		[DllImport(GLFW_LIB)] static extern void glfwSetWindowMonitor(nint window, Monitor monitor, int x, int y, int width, int height, int refreshRate);
	}

	public bool GetKey(KeyCode key) 
	{
		return glfwGetKey(this, key);

		[DllImport(GLFW_LIB)] static extern bool glfwGetKey(nint window, KeyCode key);
	}

	public bool GetMouseButton(KeyCode button) 
	{
		return glfwGetKey(this, button);

		[DllImport(GLFW_LIB)] static extern bool glfwGetKey(nint window, KeyCode button);
	}

	public void SetInputMode(InputMode mode, int value) 
	{
		glfwSetInputMode(this, mode, value);

		[DllImport(GLFW_LIB)] static extern void glfwSetInputMode(nint window, InputMode mode, int value);
	}

	public int GetInputMode(InputMode mode) 
	{
		return glfwGetInputMode(this, mode);

		[DllImport(GLFW_LIB)] static extern int glfwGetInputMode(nint window, InputMode mode);
	}

	public void SwapBuffers() 
	{
		glfwSwapBuffers(this);

		[DllImport(GLFW_LIB)] static extern void glfwSwapBuffers(nint window);
	}

	public void MakeCurrentContext() 
	{
		glfwMakeContextCurrent(this);

		[DllImport(GLFW_LIB)] static extern void glfwMakeContextCurrent(nint window);
	}

	public void Iconify() 
	{
		glfwIconifyWindow(this);

		[DllImport(GLFW_LIB)] static extern void glfwIconifyWindow(nint window);
	}

	public void Restore() 
	{
		glfwRestoreWindow(this);

		[DllImport(GLFW_LIB)] static extern void glfwRestoreWindow(nint window);
	}

	public void Maximize() 
	{
		glfwMaximizeWindow(this);

		[DllImport(GLFW_LIB)] static extern void glfwMaximizeWindow(nint window);
	}

	public void Show() 
	{
		glfwShowWindow(this);

		[DllImport(GLFW_LIB)] static extern void glfwShowWindow(nint window);
	}

	public void Hide() 
	{
		glfwHideWindow(this);

		[DllImport(GLFW_LIB)] static extern void glfwHideWindow(nint window);
	}

	public void Focus() 
	{
		glfwFocusWindow(this);

		[DllImport(GLFW_LIB)] static extern void glfwFocusWindow(nint window);
	}

	public void RequestAttention() 
	{
		glfwRequestWindowAttention(this);

		[DllImport(GLFW_LIB)] static extern void glfwRequestWindowAttention(nint window);
	}


	public static void ResetHints() 
	{
		glfwDefaultWindowHints();

		[DllImport(GLFW_LIB)] static extern void glfwDefaultWindowHints();
	}

	public static void SetHint(Hint hint, int value) 
	{
		glfwWindowHint(hint, value);

		[DllImport(GLFW_LIB)] static extern void glfwWindowHint(Hint hint, int value);
	}

	public static void SetHint(Hint hint, string value) 
	{
		glfwWindowHintString(hint, value);

		[DllImport(GLFW_LIB)] static extern void glfwWindowHintString(Hint hint, string value);
	}

	public void Dispose() 
	{
		glfwSetKeyCallback(this, null);
		glfwSetCharCallback(this, null);
		glfwSetMouseButtonCallback(this, null);
		glfwSetCursorPosCallback(this, null);
		glfwSetCursorEnterCallback(this, null);
		glfwSetScrollCallback(this, null);
		glfwSetDropCallback(this, null);
		glfwSetWindowPosCallback(this, null);
		glfwSetWindowSizeCallback(this, null);
		glfwSetWindowCloseCallback(this, null);
		glfwSetWindowRefreshCallback(this, null);
		glfwSetWindowFocusCallback(this, null);
		glfwSetWindowIconifyCallback(this, null);
		glfwSetWindowMaximizeCallback(this, null);
		glfwSetWindowContentScaleCallback(this, null);
		glfwSetFramebufferSizeCallback(this, null);

		glfwDestroyWindow(this);

		[DllImport(GLFW_LIB)] static extern void glfwDestroyWindow(nint window);
	}

	public static bool operator == (Window a, Window b) => a.handle == b.handle;
	public static bool operator != (Window a, Window b) => a.handle != b.handle;
	public override bool Equals(object? other) => (other is Window x) ? x.handle == handle : false;

	public static implicit operator nint (Window x) => x.handle;

	public override string ToString() => handle.ToString();
	public override int GetHashCode() => handle.GetHashCode();

	public unsafe Window(int width, int height, string title = "Managed GLFW Window", Monitor? monitor = null, Window? share = null) 
	{
		handle = glfwCreateWindow(
			width,
			height,
			title,
			(monitor is Monitor m) ? m : default,
			(share is Window w) ? (nint)w : default
		);

		keyCallback = (window, key, scancode, state, modifiers) => OnKey?.Invoke(this, new(key, scancode, state, modifiers));
		charCallback = (window, codepoint) => OnChar?.Invoke(this, new(codepoint));
		mouseButtonCallback = (window, button, state, modifiers) => OnMouseButton?.Invoke(this, new(button, state, modifiers));
		cursorPositionCallback = (window, x, y) => OnCursorPosition?.Invoke(this, new(x, y));
		cursorEnterCallback = (window, entered) => OnCursorEnter?.Invoke(this, new(entered));
		scrollCallback = (window, x, y) => OnScroll?.Invoke(this, new(x, y));
		dropCallback = (window, count, paths) => OnDrop?.Invoke(this, new(new ReadOnlySpan<nint>(paths, count).ToImmutableArray().Select(x => new string((sbyte*)x)).ToArray()));
		positionCallback = (window, x, y) => OnPosition?.Invoke(this, new(x, y));
		sizeCallback = (window, width, height) => OnSize?.Invoke(this, new(width, height));
		closeCallback = (window) => OnClose?.Invoke(this, new());
		refreshCallback = (window) => OnRefresh?.Invoke(this, new());
		focusCallback = (window, focused) => OnFocus?.Invoke(this, new(focused));
		iconifyCallback = (window, iconified) => OnIconify?.Invoke(this, new(iconified));
		maximizeCallback = (window, maximized) => OnMaximize?.Invoke(this, new(maximized));
		contentScaleCallback = (window, x, y) => OnContentScale?.Invoke(this, new(x, y));
		framebufferSizeCallback = (window, width, height) => OnFramebufferSize?.Invoke(this, new(width, height));

		glfwSetKeyCallback(this, keyCallback);
		glfwSetCharCallback(this, charCallback);
		glfwSetMouseButtonCallback(this, mouseButtonCallback);
		glfwSetCursorPosCallback(this, cursorPositionCallback);
		glfwSetCursorEnterCallback(this, cursorEnterCallback);
		glfwSetScrollCallback(this, scrollCallback);
		glfwSetDropCallback(this, dropCallback);
		glfwSetWindowPosCallback(this, positionCallback);
		glfwSetWindowSizeCallback(this, sizeCallback);
		glfwSetWindowCloseCallback(this, closeCallback);
		glfwSetWindowRefreshCallback(this, refreshCallback);
		glfwSetWindowFocusCallback(this, focusCallback);
		glfwSetWindowIconifyCallback(this, iconifyCallback);
		glfwSetWindowMaximizeCallback(this, maximizeCallback);
		glfwSetWindowContentScaleCallback(this, contentScaleCallback);
		glfwSetFramebufferSizeCallback(this, framebufferSizeCallback);

		[DllImport(GLFW_LIB)] static extern nint glfwCreateWindow(int width, int height, string title, Monitor monitor, nint share);
	}

	[DllImport(GLFW_LIB)] static extern void glfwSetKeyCallback(nint window, KeyCallback? callback);
	[DllImport(GLFW_LIB)] static extern void glfwSetCharCallback(nint window, CharCallback? callback);
	[DllImport(GLFW_LIB)] static extern void glfwSetMouseButtonCallback(nint window, MouseButtonCallback? callback);
	[DllImport(GLFW_LIB)] static extern void glfwSetCursorPosCallback(nint window, CursorPositionCallback? callback);
	[DllImport(GLFW_LIB)] static extern void glfwSetCursorEnterCallback(nint window, CursorEnterCallback? callback);
	[DllImport(GLFW_LIB)] static extern void glfwSetScrollCallback(nint window, ScrollCallback? callback);
	[DllImport(GLFW_LIB)] static extern void glfwSetDropCallback(nint window, DropCallback? callback);
	[DllImport(GLFW_LIB)] static extern	void glfwSetWindowPosCallback(nint window, PositionCallback? callback);
	[DllImport(GLFW_LIB)] static extern	void glfwSetWindowSizeCallback(nint window, SizeCallback? callback);
	[DllImport(GLFW_LIB)] static extern	void glfwSetWindowCloseCallback(nint window, CloseCallback? callback);
	[DllImport(GLFW_LIB)] static extern	void glfwSetWindowRefreshCallback(nint window, RefreshCallback? callback);
	[DllImport(GLFW_LIB)] static extern	void glfwSetWindowFocusCallback(nint window, FocusCallback? callback);
	[DllImport(GLFW_LIB)] static extern	void glfwSetWindowIconifyCallback(nint window, IconifyCallback? callback);
	[DllImport(GLFW_LIB)] static extern	void glfwSetWindowMaximizeCallback(nint window, MaximizeCallback? callback);
	[DllImport(GLFW_LIB)] static extern	void glfwSetWindowContentScaleCallback(nint window, ContentScaleCallback? callback);
	[DllImport(GLFW_LIB)] static extern	void glfwSetFramebufferSizeCallback(nint window, FramebufferSizeCallback? callback);
}
