using System.Runtime.InteropServices;

using static GLFW.Constants;

namespace GLFW;

public static class Input 
{
	public static bool IsRawMouseMotionSupported 
	{
		get 
		{
			return glfwRawMouseMotionSupported();

			[DllImport(GLFW_LIB)] static extern bool glfwRawMouseMotionSupported();
		}
	}

	public static ulong TimerValue 
	{
		get 
		{
			return glfwGetTimerValue();

			[DllImport(GLFW_LIB)] static extern ulong glfwGetTimerValue();
		}
	}
	public static ulong TimerFrequency 
	{
		get 
		{
			return glfwGetTimerFrequency();

			[DllImport(GLFW_LIB)] static extern ulong glfwGetTimerFrequency();
		}
	}

	public static double Time 
	{
		set 
		{
			glfwSetTime(value);

			[DllImport(GLFW_LIB)] static extern void glfwSetTime(double time);
		}
		get 
		{
			return glfwGetTime();

			[DllImport(GLFW_LIB)] static extern double glfwGetTime();
		}
	}

	public static unsafe string GetJoystickName(int jid) 
	{
		return new string(glfwGetJoystickName(jid));

		[DllImport(GLFW_LIB)] static extern sbyte* glfwGetJoystickName(int jid);
	}
	public static unsafe string GetJoystickGUID(int jid) 
	{
		return new string(glfwGetJoystickGUID(jid));

		[DllImport(GLFW_LIB)] static extern sbyte* glfwGetJoystickGUID(int jid);
	}
	public static unsafe string GetGamepadName(int jid) 
	{
		return new string(glfwGetGamepadName(jid));

		[DllImport(GLFW_LIB)] static extern sbyte* glfwGetGamepadName(int jid);
	}

	[DllImport(GLFW_LIB, EntryPoint = "glfwSetJoystickUserPointer")]
	public static extern void SetJoystickUserPointer(int jid, nint value);

	[DllImport(GLFW_LIB, EntryPoint = "glfwGetJoystickUserPointer")]
	public static extern nint GetJoystickUserPointer(int jid);

	[DllImport(GLFW_LIB, EntryPoint = "glfwJoystickPresent")]
	public static extern bool IsJoystickPresent(int jid);

	[DllImport(GLFW_LIB, EntryPoint = "glfwJoystickIsGamepad")]
	public static extern bool IsJoystickGamepad(int jid);

	[DllImport(GLFW_LIB, EntryPoint = "glfwUpdateGamepadMappings")]
	public static extern bool TryUpdateGamepadMappings(string mappings);

	[DllImport(GLFW_LIB, EntryPoint = "glfwPostEmptyEvent")]
	public static extern void PostEmptyEvent();

	[DllImport(GLFW_LIB, EntryPoint = "glfwPollEvents")]
	public static extern void PollEvents();

	[DllImport(GLFW_LIB, EntryPoint = "glfwWaitEvents")]
	public static extern void WaitForEvents();

	[DllImport(GLFW_LIB, EntryPoint = "glfwWaitEventsTimeout")]
	public static extern void WaitForEventsTimeout(double time);

	[DllImport(GLFW_LIB, EntryPoint = "glfwGetKeyScancode")]
	public static extern int GetScancode(this KeyCode key);

	public static unsafe string GetKeyName(KeyCode key, int scancode) 
	{
		return new string(glfwGetKeyName(key, scancode));

		[DllImport(GLFW_LIB)] static extern sbyte* glfwGetKeyName(KeyCode key, int scancode);
	}

	// // [DllImport(GLFW_LIB)] private static extern float* glfwGetJoystickAxes(int jid, int* count);
	// // [DllImport(GLFW_LIB)] private static extern byte* glfwGetJoystickButtons(int jid, int* count);
	// // [DllImport(GLFW_LIB)] private static extern byte* glfwGetJoystickHats(int jid, int* count);
	// // [DllImport(GLFW_LIB)] private static extern GLFWjoystickfun glfwSetJoystickCallback(GLFWjoystickfun callback);
	// // [DllImport(GLFW_LIB)] private static extern int glfwGetGamepadState(int jid, GLFWgamepadstate* state);
}
