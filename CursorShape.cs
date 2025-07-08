using static GLFW.Constants;

namespace GLFW;

public enum CursorShape : int
{
	Arrow = GLFW_ARROW_CURSOR,
	IBeam = GLFW_IBEAM_CURSOR,
	Crosshair = GLFW_CROSSHAIR_CURSOR,
	PointingHand = GLFW_POINTING_HAND_CURSOR,
	ResizeEW = GLFW_RESIZE_EW_CURSOR,
	ResizeNS = GLFW_RESIZE_NS_CURSOR,
	ResizeNWSE = GLFW_RESIZE_NWSE_CURSOR,
	ResizeNESW = GLFW_RESIZE_NESW_CURSOR,
	ResizeAll = GLFW_RESIZE_ALL_CURSOR,
	NotAllowed = GLFW_NOT_ALLOWED_CURSOR,
	HResize = ResizeEW,
	VResize = ResizeNS,
	Hand = PointingHand,
}
