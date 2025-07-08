using static GLFW.Constants;

namespace GLFW;

public enum KeyState : int
{
	Release = GLFW_RELEASE,
	Press = GLFW_PRESS,
	Repeat = GLFW_REPEAT,
}
