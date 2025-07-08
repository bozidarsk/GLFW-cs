#pragma warning disable CS0649

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using static GLFW.Constants;

namespace GLFW;

public readonly struct Monitor 
{
	private readonly nint handle;

	public unsafe string Name 
	{
		get 
		{
			return new(glfwGetMonitorName(this));

			[DllImport(GLFW_LIB)] static extern sbyte* glfwGetMonitorName(Monitor monitor);
		}
	}

	public (int, int) Position 
	{
		get 
		{
			glfwGetMonitorPos(this, out int x, out int y);
			return (x, y);

			[DllImport(GLFW_LIB)] static extern void glfwGetMonitorPos(Monitor monitor, out int x, out int y);
		}
	}

	public (int, int) PhysicalSize 
	{
		get 
		{
			glfwGetMonitorPhysicalSize(this, out int x, out int y);
			return (x, y);

			[DllImport(GLFW_LIB)] static extern void glfwGetMonitorPhysicalSize(Monitor monitor, out int x, out int y);
		}
	}

	public (float, float) ContentSize 
	{
		get 
		{
			glfwGetMonitorContentSize(this, out float x, out float y);
			return (x, y);

			[DllImport(GLFW_LIB)] static extern void glfwGetMonitorContentSize(Monitor monitor, out float x, out float y);
		}
	}

	public (int, int, int, int) WorkArea 
	{
		get 
		{
			glfwGetMonitorWorkarea(this, out int x, out int y, out int width, out int height);
			return (x, y, width, height);

			[DllImport(GLFW_LIB)] static extern void glfwGetMonitorWorkarea(Monitor monitor, out int x, out int y, out int width, out int height);
		}
	}

	public nint UserPointer 
	{
		set 
		{
			glfwSetMonitorUserPointer(this, value);

			[DllImport(GLFW_LIB)] static extern void glfwSetMonitorUserPointer(Monitor monitor, nint pointer);
		}
		get 
		{
			return glfwGetMonitorUserPointer(this);

			[DllImport(GLFW_LIB)] static extern nint glfwGetMonitorUserPointer(Monitor monitor);
		}
	}

	public static Monitor PrimaryMonitor 
	{
		get 
		{
			return glfwGetPrimaryMonitor();

			[DllImport(GLFW_LIB)] static extern Monitor glfwGetPrimaryMonitor();
		}
	}

	public static unsafe Monitor[] AllMonitors 
	{
		get 
		{
			Monitor* src = glfwGetMonitors(out int count);
			var dest = new Monitor[count];

			for (int i = 0; i < count; i++)
				dest[i] = src[i];

			return dest;

			[DllImport(GLFW_LIB)] static extern Monitor* glfwGetMonitors(out int count);
		}
	}

	public static bool operator == (Monitor a, Monitor b) => a.handle == b.handle;
	public static bool operator != (Monitor a, Monitor b) => a.handle != b.handle;
	public override bool Equals(object? other) => (other is Monitor x) ? x.handle == handle : false;

	public override string ToString() => this.Name;
	public override int GetHashCode() => handle.GetHashCode();
}
