using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using static GLFW.Constants;

namespace GLFW;

public static class Program 
{
	private static unsafe ErrorCallback errorCallback = (code, message) => OnError?.Invoke(null, new(code, new string(message)));
	public static event ErrorEventHandler? OnError;

	public static Platform Platform 
	{
		get 
		{
			return glfwGetPlatform();

			[DllImport(GLFW_LIB)] static extern Platform glfwGetPlatform();
		}
	}
	public static unsafe string Version 
	{
		get 
		{
			return new string(glfwGetVersionString());

			[DllImport(GLFW_LIB)] static extern sbyte* glfwGetVersionString();
		}
	}

	public static unsafe string?[]? RequiredInstanceExtensions 
	{
		get 
		{
			var x = glfwGetRequiredInstanceExtensions(out uint count);

			if (x == default)
				return null;

			string?[] values = new string[count];

			for (int i = 0; i < values.Length; i++)
				values[i] = (x[i] != default) ? new(x[i]) : null;

			return values;

			[DllImport(GLFW_LIB)] static extern sbyte** glfwGetRequiredInstanceExtensions(out uint count);
		}
	}

	public static bool Initialize() 
	{
		bool result = glfwInit();

		if (result)
			glfwSetErrorCallback(Program.errorCallback);

		return result;

		[DllImport(GLFW_LIB)] static extern bool glfwInit();
		[DllImport(GLFW_LIB)] static extern void glfwSetErrorCallback(ErrorCallback callback);
	}

	[DllImport(GLFW_LIB, EntryPoint = "glfwTerminate")]
	public static extern void Terminate();

	[DllImport(GLFW_LIB, EntryPoint = "glfwInitHint")]
	public static extern void InitializeHint(int hint, int value);

	[DllImport(GLFW_LIB, EntryPoint = "glfwGetVersion")]
	public static extern void GetVersion(out int major, out int minor, out int revision);

	[DllImport(GLFW_LIB, EntryPoint = "glfwPlatformSupported")]
	public static extern bool IsSupported(Platform platform);
}
