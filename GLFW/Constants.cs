namespace GLFW;

internal static class Constants 
{
	public const string GLFW_LIB = 
	#if WINDOWS
	"glfw3"
	#elif LINUX
	"glfw"
	#elif MAC
	#error Not implemented. (MAC)
	#else
	#error Unknown os.
	#endif
	;
	
	/*! @name GLFW version macros
	 *  @{ */
	/*! @brief The major version number of the GLFW header.
	 *
	 *  The major version number of the GLFW header.  This is incremented when the
	 *  API is changed in non-compatible ways.
	 *  @ingroup init
	 */
	public const int GLFW_VERSION_MAJOR =          3;
	/*! @brief The minor version number of the GLFW header.
	 *
	 *  The minor version number of the GLFW header.  This is incremented when
	 *  features are added to the API but it remains backward-compatible.
	 *  @ingroup init
	 */
	public const int GLFW_VERSION_MINOR =          5;
	/*! @brief The revision number of the GLFW header.
	 *
	 *  The revision number of the GLFW header.  This is incremented when a bug fix
	 *  release is made that does not contain any API changes.
	 *  @ingroup init
	 */
	public const int GLFW_VERSION_REVISION =       0;
	/*! @} */

	/*! @brief One.
	 *
	 *  This is only semantic sugar for the number 1.  You can instead use `1` or
	 *  `true` or `_True` or `GL_TRUE` or `VK_TRUE` or anything else that is equal
	 *  to one.
	 *
	 *  @ingroup init
	 */
	public const int GLFW_TRUE =                   1;
	/*! @brief Zero.
	 *
	 *  This is only semantic sugar for the number 0.  You can instead use `0` or
	 *  `false` or `_False` or `GL_FALSE` or `VK_FALSE` or anything else that is
	 *  equal to zero.
	 *
	 *  @ingroup init
	 */
	public const int GLFW_FALSE =                  0;

	/*! @name Key and button actions
	 *  @{ */
	/*! @brief The key or mouse button was released.
	 *
	 *  The key or mouse button was released.
	 *
	 *  @ingroup input
	 */
	public const int GLFW_RELEASE =                0;
	/*! @brief The key or mouse button was pressed.
	 *
	 *  The key or mouse button was pressed.
	 *
	 *  @ingroup input
	 */
	public const int GLFW_PRESS =                  1;
	/*! @brief The key was held down until it repeated.
	 *
	 *  The key was held down until it repeated.
	 *
	 *  @ingroup input
	 */
	public const int GLFW_REPEAT =                 2;
	/*! @} */

	/*! @defgroup hat_state Joystick hat states
	 *  @brief Joystick hat states.
	 *
	 *  See [joystick hat input](@ref joystick_hat) for how these are used.
	 *
	 *  @ingroup input
	 *  @{ */
	public const int GLFW_HAT_CENTERED =           0;
	public const int GLFW_HAT_UP =                 1;
	public const int GLFW_HAT_RIGHT =              2;
	public const int GLFW_HAT_DOWN =               4;
	public const int GLFW_HAT_LEFT =               8;
	public const int GLFW_HAT_RIGHT_UP =           (GLFW_HAT_RIGHT | GLFW_HAT_UP);
	public const int GLFW_HAT_RIGHT_DOWN =         (GLFW_HAT_RIGHT | GLFW_HAT_DOWN);
	public const int GLFW_HAT_LEFT_UP =            (GLFW_HAT_LEFT  | GLFW_HAT_UP);
	public const int GLFW_HAT_LEFT_DOWN =          (GLFW_HAT_LEFT  | GLFW_HAT_DOWN);

	/*! @ingroup input
	 */
	public const int GLFW_KEY_UNKNOWN =            -1;

	/*! @} */

	/*! @defgroup keys Keyboard key tokens
	 *  @brief Keyboard key tokens.
	 *
	 *  See [key input](@ref input_key) for how these are used.
	 *
	 *  These key codes are inspired by the _USB HID Usage Tables v1.12_ (p. 53-60),
	 *  but re-arranged to map to 7-bit ASCII for printable keys (function keys are
	 *  put in the 256+ range).
	 *
	 *  The naming of the key codes follow these rules:
	 *   - The US keyboard layout is used
	 *   - Names of printable alphanumeric characters are used (e.g. "A", "R",
	 *     "3", etc.)
	 *   - For non-alphanumeric characters, Unicode:ish names are used (e.g.
	 *     "COMMA", "LEFT_SQUARE_BRACKET", etc.). Note that some names do not
	 *     correspond to the Unicode standard (usually for brevity)
	 *   - Keys that lack a clear US mapping are named "WORLD_x"
	 *   - For non-printable keys, custom names are used (e.g. "F4",
	 *     "BACKSPACE", etc.)
	 *
	 *  @ingroup input
	 *  @{
	 */

	/* Printable keys */
	public const int GLFW_KEY_SPACE =              32;
	public const int GLFW_KEY_APOSTROPHE =         39  /* ' */;
	public const int GLFW_KEY_COMMA =              44  /* , */;
	public const int GLFW_KEY_MINUS =              45  /* - */;
	public const int GLFW_KEY_PERIOD =             46  /* . */;
	public const int GLFW_KEY_SLASH =              47  /* / */;
	public const int GLFW_KEY_0 =                  48;
	public const int GLFW_KEY_1 =                  49;
	public const int GLFW_KEY_2 =                  50;
	public const int GLFW_KEY_3 =                  51;
	public const int GLFW_KEY_4 =                  52;
	public const int GLFW_KEY_5 =                  53;
	public const int GLFW_KEY_6 =                  54;
	public const int GLFW_KEY_7 =                  55;
	public const int GLFW_KEY_8 =                  56;
	public const int GLFW_KEY_9 =                  57;
	public const int GLFW_KEY_SEMICOLON =          59  /* ; */;
	public const int GLFW_KEY_EQUAL =              61  /* = */;
	public const int GLFW_KEY_A =                  65;
	public const int GLFW_KEY_B =                  66;
	public const int GLFW_KEY_C =                  67;
	public const int GLFW_KEY_D =                  68;
	public const int GLFW_KEY_E =                  69;
	public const int GLFW_KEY_F =                  70;
	public const int GLFW_KEY_G =                  71;
	public const int GLFW_KEY_H =                  72;
	public const int GLFW_KEY_I =                  73;
	public const int GLFW_KEY_J =                  74;
	public const int GLFW_KEY_K =                  75;
	public const int GLFW_KEY_L =                  76;
	public const int GLFW_KEY_M =                  77;
	public const int GLFW_KEY_N =                  78;
	public const int GLFW_KEY_O =                  79;
	public const int GLFW_KEY_P =                  80;
	public const int GLFW_KEY_Q =                  81;
	public const int GLFW_KEY_R =                  82;
	public const int GLFW_KEY_S =                  83;
	public const int GLFW_KEY_T =                  84;
	public const int GLFW_KEY_U =                  85;
	public const int GLFW_KEY_V =                  86;
	public const int GLFW_KEY_W =                  87;
	public const int GLFW_KEY_X =                  88;
	public const int GLFW_KEY_Y =                  89;
	public const int GLFW_KEY_Z =                  90;
	public const int GLFW_KEY_LEFT_BRACKET =       91  /* [ */;
	public const int GLFW_KEY_BACKSLASH =          92  /* \ */;
	public const int GLFW_KEY_RIGHT_BRACKET =      93  /* ] */;
	public const int GLFW_KEY_GRAVE_ACCENT =       96  /* ` */;
	public const int GLFW_KEY_WORLD_1 =            161 /* non-US #1 */;
	public const int GLFW_KEY_WORLD_2 =            162 /* non-US #2 */;

	/* Function keys */
	public const int GLFW_KEY_ESCAPE =             256;
	public const int GLFW_KEY_ENTER =              257;
	public const int GLFW_KEY_TAB =                258;
	public const int GLFW_KEY_BACKSPACE =          259;
	public const int GLFW_KEY_INSERT =             260;
	public const int GLFW_KEY_DELETE =             261;
	public const int GLFW_KEY_RIGHT =              262;
	public const int GLFW_KEY_LEFT =               263;
	public const int GLFW_KEY_DOWN =               264;
	public const int GLFW_KEY_UP =                 265;
	public const int GLFW_KEY_PAGE_UP =            266;
	public const int GLFW_KEY_PAGE_DOWN =          267;
	public const int GLFW_KEY_HOME =               268;
	public const int GLFW_KEY_END =                269;
	public const int GLFW_KEY_CAPS_LOCK =          280;
	public const int GLFW_KEY_SCROLL_LOCK =        281;
	public const int GLFW_KEY_NUM_LOCK =           282;
	public const int GLFW_KEY_PRINT_SCREEN =       283;
	public const int GLFW_KEY_PAUSE =              284;
	public const int GLFW_KEY_F1 =                 290;
	public const int GLFW_KEY_F2 =                 291;
	public const int GLFW_KEY_F3 =                 292;
	public const int GLFW_KEY_F4 =                 293;
	public const int GLFW_KEY_F5 =                 294;
	public const int GLFW_KEY_F6 =                 295;
	public const int GLFW_KEY_F7 =                 296;
	public const int GLFW_KEY_F8 =                 297;
	public const int GLFW_KEY_F9 =                 298;
	public const int GLFW_KEY_F10 =                299;
	public const int GLFW_KEY_F11 =                300;
	public const int GLFW_KEY_F12 =                301;
	public const int GLFW_KEY_F13 =                302;
	public const int GLFW_KEY_F14 =                303;
	public const int GLFW_KEY_F15 =                304;
	public const int GLFW_KEY_F16 =                305;
	public const int GLFW_KEY_F17 =                306;
	public const int GLFW_KEY_F18 =                307;
	public const int GLFW_KEY_F19 =                308;
	public const int GLFW_KEY_F20 =                309;
	public const int GLFW_KEY_F21 =                310;
	public const int GLFW_KEY_F22 =                311;
	public const int GLFW_KEY_F23 =                312;
	public const int GLFW_KEY_F24 =                313;
	public const int GLFW_KEY_F25 =                314;
	public const int GLFW_KEY_KP_0 =               320;
	public const int GLFW_KEY_KP_1 =               321;
	public const int GLFW_KEY_KP_2 =               322;
	public const int GLFW_KEY_KP_3 =               323;
	public const int GLFW_KEY_KP_4 =               324;
	public const int GLFW_KEY_KP_5 =               325;
	public const int GLFW_KEY_KP_6 =               326;
	public const int GLFW_KEY_KP_7 =               327;
	public const int GLFW_KEY_KP_8 =               328;
	public const int GLFW_KEY_KP_9 =               329;
	public const int GLFW_KEY_KP_DECIMAL =         330;
	public const int GLFW_KEY_KP_DIVIDE =          331;
	public const int GLFW_KEY_KP_MULTIPLY =        332;
	public const int GLFW_KEY_KP_SUBTRACT =        333;
	public const int GLFW_KEY_KP_ADD =             334;
	public const int GLFW_KEY_KP_ENTER =           335;
	public const int GLFW_KEY_KP_EQUAL =           336;
	public const int GLFW_KEY_LEFT_SHIFT =         340;
	public const int GLFW_KEY_LEFT_CONTROL =       341;
	public const int GLFW_KEY_LEFT_ALT =           342;
	public const int GLFW_KEY_LEFT_SUPER =         343;
	public const int GLFW_KEY_RIGHT_SHIFT =        344;
	public const int GLFW_KEY_RIGHT_CONTROL =      345;
	public const int GLFW_KEY_RIGHT_ALT =          346;
	public const int GLFW_KEY_RIGHT_SUPER =        347;
	public const int GLFW_KEY_MENU =               348;

	public const int GLFW_KEY_LAST =               GLFW_KEY_MENU;

	/*! @} */

	/*! @defgroup mods Modifier key flags
	 *  @brief Modifier key flags.
	 *
	 *  See [key input](@ref input_key) for how these are used.
	 *
	 *  @ingroup input
	 *  @{ */

	/*! @brief If this bit is set one or more Shift keys were held down.
	 *
	 *  If this bit is set one or more Shift keys were held down.
	 */
	public const int GLFW_MOD_SHIFT =           0x0001;
	/*! @brief If this bit is set one or more Control keys were held down.
	 *
	 *  If this bit is set one or more Control keys were held down.
	 */
	public const int GLFW_MOD_CONTROL =         0x0002;
	/*! @brief If this bit is set one or more Alt keys were held down.
	 *
	 *  If this bit is set one or more Alt keys were held down.
	 */
	public const int GLFW_MOD_ALT =             0x0004;
	/*! @brief If this bit is set one or more Super keys were held down.
	 *
	 *  If this bit is set one or more Super keys were held down.
	 */
	public const int GLFW_MOD_SUPER =           0x0008;
	/*! @brief If this bit is set the Caps Lock key is enabled.
	 *
	 *  If this bit is set the Caps Lock key is enabled and the @ref
	 *  GLFW_LOCK_KEY_MODS input mode is set.
	 */
	public const int GLFW_MOD_CAPS_LOCK =       0x0010;
	/*! @brief If this bit is set the Num Lock key is enabled.
	 *
	 *  If this bit is set the Num Lock key is enabled and the @ref
	 *  GLFW_LOCK_KEY_MODS input mode is set.
	 */
	public const int GLFW_MOD_NUM_LOCK =        0x0020;

	/*! @} */

	/*! @defgroup buttons Mouse buttons
	 *  @brief Mouse button IDs.
	 *
	 *  See [mouse button input](@ref input_mouse_button) for how these are used.
	 *
	 *  @ingroup input
	 *  @{ */
	public const int GLFW_MOUSE_BUTTON_1 =         0;
	public const int GLFW_MOUSE_BUTTON_2 =         1;
	public const int GLFW_MOUSE_BUTTON_3 =         2;
	public const int GLFW_MOUSE_BUTTON_4 =         3;
	public const int GLFW_MOUSE_BUTTON_5 =         4;
	public const int GLFW_MOUSE_BUTTON_6 =         5;
	public const int GLFW_MOUSE_BUTTON_7 =         6;
	public const int GLFW_MOUSE_BUTTON_8 =         7;
	public const int GLFW_MOUSE_BUTTON_LAST =      GLFW_MOUSE_BUTTON_8;
	public const int GLFW_MOUSE_BUTTON_LEFT =      GLFW_MOUSE_BUTTON_1;
	public const int GLFW_MOUSE_BUTTON_RIGHT =     GLFW_MOUSE_BUTTON_2;
	public const int GLFW_MOUSE_BUTTON_MIDDLE =    GLFW_MOUSE_BUTTON_3;
	/*! @} */

	/*! @defgroup joysticks Joysticks
	 *  @brief Joystick IDs.
	 *
	 *  See [joystick input](@ref joystick) for how these are used.
	 *
	 *  @ingroup input
	 *  @{ */
	public const int GLFW_JOYSTICK_1 =             0;
	public const int GLFW_JOYSTICK_2 =             1;
	public const int GLFW_JOYSTICK_3 =             2;
	public const int GLFW_JOYSTICK_4 =             3;
	public const int GLFW_JOYSTICK_5 =             4;
	public const int GLFW_JOYSTICK_6 =             5;
	public const int GLFW_JOYSTICK_7 =             6;
	public const int GLFW_JOYSTICK_8 =             7;
	public const int GLFW_JOYSTICK_9 =             8;
	public const int GLFW_JOYSTICK_10 =            9;
	public const int GLFW_JOYSTICK_11 =            10;
	public const int GLFW_JOYSTICK_12 =            11;
	public const int GLFW_JOYSTICK_13 =            12;
	public const int GLFW_JOYSTICK_14 =            13;
	public const int GLFW_JOYSTICK_15 =            14;
	public const int GLFW_JOYSTICK_16 =            15;
	public const int GLFW_JOYSTICK_LAST =          GLFW_JOYSTICK_16;
	/*! @} */

	/*! @defgroup gamepad_buttons Gamepad buttons
	 *  @brief Gamepad buttons.
	 *
	 *  See @ref gamepad for how these are used.
	 *
	 *  @ingroup input
	 *  @{ */
	public const int GLFW_GAMEPAD_BUTTON_A =               0;
	public const int GLFW_GAMEPAD_BUTTON_B =               1;
	public const int GLFW_GAMEPAD_BUTTON_X =               2;
	public const int GLFW_GAMEPAD_BUTTON_Y =               3;
	public const int GLFW_GAMEPAD_BUTTON_LEFT_BUMPER =     4;
	public const int GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER =    5;
	public const int GLFW_GAMEPAD_BUTTON_BACK =            6;
	public const int GLFW_GAMEPAD_BUTTON_START =           7;
	public const int GLFW_GAMEPAD_BUTTON_GUIDE =           8;
	public const int GLFW_GAMEPAD_BUTTON_LEFT_THUMB =      9;
	public const int GLFW_GAMEPAD_BUTTON_RIGHT_THUMB =     10;
	public const int GLFW_GAMEPAD_BUTTON_DPAD_UP =         11;
	public const int GLFW_GAMEPAD_BUTTON_DPAD_RIGHT =      12;
	public const int GLFW_GAMEPAD_BUTTON_DPAD_DOWN =       13;
	public const int GLFW_GAMEPAD_BUTTON_DPAD_LEFT =       14;
	public const int GLFW_GAMEPAD_BUTTON_LAST =            GLFW_GAMEPAD_BUTTON_DPAD_LEFT;

	public const int GLFW_GAMEPAD_BUTTON_CROSS =       GLFW_GAMEPAD_BUTTON_A;
	public const int GLFW_GAMEPAD_BUTTON_CIRCLE =      GLFW_GAMEPAD_BUTTON_B;
	public const int GLFW_GAMEPAD_BUTTON_SQUARE =      GLFW_GAMEPAD_BUTTON_X;
	public const int GLFW_GAMEPAD_BUTTON_TRIANGLE =    GLFW_GAMEPAD_BUTTON_Y;
	/*! @} */

	/*! @defgroup gamepad_axes Gamepad axes
	 *  @brief Gamepad axes.
	 *
	 *  See @ref gamepad for how these are used.
	 *
	 *  @ingroup input
	 *  @{ */
	public const int GLFW_GAMEPAD_AXIS_LEFT_X =        0;
	public const int GLFW_GAMEPAD_AXIS_LEFT_Y =        1;
	public const int GLFW_GAMEPAD_AXIS_RIGHT_X =       2;
	public const int GLFW_GAMEPAD_AXIS_RIGHT_Y =       3;
	public const int GLFW_GAMEPAD_AXIS_LEFT_TRIGGER =  4;
	public const int GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER = 5;
	public const int GLFW_GAMEPAD_AXIS_LAST =          GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER;
	/*! @} */

	/*! @defgroup errors Error codes
	 *  @brief Error codes.
	 *
	 *  See [error handling](@ref error_handling) for how these are used.
	 *
	 *  @ingroup init
	 *  @{ */
	/*! @brief No error has occurred.
	 *
	 *  No error has occurred.
	 *
	 *  @analysis Yay.
	 */
	public const int GLFW_NO_ERROR =               0;
	/*! @brief GLFW has not been initialized.
	 *
	 *  This occurs if a GLFW function was called that must not be called unless the
	 *  library is [initialized](@ref intro_init).
	 *
	 *  @analysis Application programmer error.  Initialize GLFW before calling any
	 *  function that requires initialization.
	 */
	public const int GLFW_NOT_INITIALIZED =        0x00010001;
	/*! @brief No context is current for this thread.
	 *
	 *  This occurs if a GLFW function was called that needs and operates on the
	 *  current OpenGL or OpenGL ES context but no context is current on the calling
	 *  thread.  One such function is @ref glfwSwapInterval.
	 *
	 *  @analysis Application programmer error.  Ensure a context is current before
	 *  calling functions that require a current context.
	 */
	public const int GLFW_NO_CURRENT_CONTEXT =     0x00010002;
	/*! @brief One of the arguments to the function was an invalid enum value.
	 *
	 *  One of the arguments to the function was an invalid enum value, for example
	 *  requesting @ref GLFW_RED_BITS with @ref glfwGetWindowAttrib.
	 *
	 *  @analysis Application programmer error.  Fix the offending call.
	 */
	public const int GLFW_INVALID_ENUM =           0x00010003;
	/*! @brief One of the arguments to the function was an invalid value.
	 *
	 *  One of the arguments to the function was an invalid value, for example
	 *  requesting a non-existent OpenGL or OpenGL ES version like 2.7.
	 *
	 *  Requesting a valid but unavailable OpenGL or OpenGL ES version will instead
	 *  result in a @ref GLFW_VERSION_UNAVAILABLE error.
	 *
	 *  @analysis Application programmer error.  Fix the offending call.
	 */
	public const int GLFW_INVALID_VALUE =          0x00010004;
	/*! @brief A memory allocation failed.
	 *
	 *  A memory allocation failed.
	 *
	 *  @analysis A bug in GLFW or the underlying operating system.  Report the bug
	 *  to our [issue tracker](https://github.com/glfw/glfw/issues).
	 */
	public const int GLFW_OUT_OF_MEMORY =          0x00010005;
	/*! @brief GLFW could not find support for the requested API on the system.
	 *
	 *  GLFW could not find support for the requested API on the system.
	 *
	 *  @analysis The installed graphics driver does not support the requested
	 *  API, or does not support it via the chosen context creation API.
	 *  Below are a few examples.
	 *
	 *  @par
	 *  Some pre-installed Windows graphics drivers do not support OpenGL.  AMD only
	 *  supports OpenGL ES via EGL, while Nvidia and Intel only support it via
	 *  a WGL or GLX extension.  macOS does not provide OpenGL ES at all.  The Mesa
	 *  EGL, OpenGL and OpenGL ES libraries do not interface with the Nvidia binary
	 *  driver.  Older graphics drivers do not support Vulkan.
	 */
	public const int GLFW_API_UNAVAILABLE =        0x00010006;
	/*! @brief The requested OpenGL or OpenGL ES version is not available.
	 *
	 *  The requested OpenGL or OpenGL ES version (including any requested context
	 *  or framebuffer hints) is not available on this machine.
	 *
	 *  @analysis The machine does not support your requirements.  If your
	 *  application is sufficiently flexible, downgrade your requirements and try
	 *  again.  Otherwise, inform the user that their machine does not match your
	 *  requirements.
	 *
	 *  @par
	 *  Future invalid OpenGL and OpenGL ES versions, for example OpenGL 4.8 if 5.0
	 *  comes out before the 4.x series gets that far, also fail with this error and
	 *  not @ref GLFW_INVALID_VALUE, because GLFW cannot know what future versions
	 *  will exist.
	 */
	public const int GLFW_VERSION_UNAVAILABLE =    0x00010007;
	/*! @brief A platform-specific error occurred that does not match any of the
	 *  more specific categories.
	 *
	 *  A platform-specific error occurred that does not match any of the more
	 *  specific categories.
	 *
	 *  @analysis A bug or configuration error in GLFW, the underlying operating
	 *  system or its drivers, or a lack of required resources.  Report the issue to
	 *  our [issue tracker](https://github.com/glfw/glfw/issues).
	 */
	public const int GLFW_PLATFORM_ERROR =         0x00010008;
	/*! @brief The requested format is not supported or available.
	 *
	 *  If emitted during window creation, the requested pixel format is not
	 *  supported.
	 *
	 *  If emitted when querying the clipboard, the contents of the clipboard could
	 *  not be converted to the requested format.
	 *
	 *  @analysis If emitted during window creation, one or more
	 *  [hard constraints](@ref window_hints_hard) did not match any of the
	 *  available pixel formats.  If your application is sufficiently flexible,
	 *  downgrade your requirements and try again.  Otherwise, inform the user that
	 *  their machine does not match your requirements.
	 *
	 *  @par
	 *  If emitted when querying the clipboard, ignore the error or report it to
	 *  the user, as appropriate.
	 */
	public const int GLFW_FORMAT_UNAVAILABLE =     0x00010009;
	/*! @brief The specified window does not have an OpenGL or OpenGL ES context.
	 *
	 *  A window that does not have an OpenGL or OpenGL ES context was passed to
	 *  a function that requires it to have one.
	 *
	 *  @analysis Application programmer error.  Fix the offending call.
	 */
	public const int GLFW_NO_WINDOW_CONTEXT =      0x0001000A;
	/*! @brief The specified cursor shape is not available.
	 *
	 *  The specified standard cursor shape is not available, either because the
	 *  current platform cursor theme does not provide it or because it is not
	 *  available on the platform.
	 *
	 *  @analysis Platform or system settings limitation.  Pick another
	 *  [standard cursor shape](@ref shapes) or create a
	 *  [custom cursor](@ref cursor_custom).
	 */
	public const int GLFW_CURSOR_UNAVAILABLE =     0x0001000B;
	/*! @brief The requested feature is not provided by the platform.
	 *
	 *  The requested feature is not provided by the platform, so GLFW is unable to
	 *  implement it.  The documentation for each function notes if it could emit
	 *  this error.
	 *
	 *  @analysis Platform or platform version limitation.  The error can be ignored
	 *  unless the feature is critical to the application.
	 *
	 *  @par
	 *  A function call that emits this error has no effect other than the error and
	 *  updating any existing out parameters.
	 */
	public const int GLFW_FEATURE_UNAVAILABLE =    0x0001000C;
	/*! @brief The requested feature is not implemented for the platform.
	 *
	 *  The requested feature has not yet been implemented in GLFW for this platform.
	 *
	 *  @analysis An incomplete implementation of GLFW for this platform, hopefully
	 *  fixed in a future release.  The error can be ignored unless the feature is
	 *  critical to the application.
	 *
	 *  @par
	 *  A function call that emits this error has no effect other than the error and
	 *  updating any existing out parameters.
	 */
	public const int GLFW_FEATURE_UNIMPLEMENTED =  0x0001000D;
	/*! @brief Platform unavailable or no matching platform was found.
	 *
	 *  If emitted during initialization, no matching platform was found.  If the @ref
	 *  GLFW_PLATFORM init hint was set to `GLFW_ANY_PLATFORM`, GLFW could not detect any of
	 *  the platforms supported by this library binary, except for the Null platform.  If the
	 *  init hint was set to a specific platform, it is either not supported by this library
	 *  binary or GLFW was not able to detect it.
	 *
	 *  If emitted by a native access function, GLFW was initialized for a different platform
	 *  than the function is for.
	 *
	 *  @analysis Failure to detect any platform usually only happens on non-macOS Unix
	 *  systems, either when no window system is running or the program was run from
	 *  a terminal that does not have the necessary environment variables.  Fall back to
	 *  a different platform if possible or notify the user that no usable platform was
	 *  detected.
	 *
	 *  Failure to detect a specific platform may have the same cause as above or be because
	 *  support for that platform was not compiled in.  Call @ref glfwPlatformSupported to
	 *  check whether a specific platform is supported by a library binary.
	 */
	public const int GLFW_PLATFORM_UNAVAILABLE =   0x0001000E;
	/*! @} */

	/*! @addtogroup window
	 *  @{ */
	/*! @brief Input focus window hint and attribute
	 *
	 *  Input focus [window hint](@ref GLFW_FOCUSED_hint) or
	 *  [window attribute](@ref GLFW_FOCUSED_attrib).
	 */
	public const int GLFW_FOCUSED =                0x00020001;
	/*! @brief Window iconification window attribute
	 *
	 *  Window iconification [window attribute](@ref GLFW_ICONIFIED_attrib).
	 */
	public const int GLFW_ICONIFIED =              0x00020002;
	/*! @brief Window resize-ability window hint and attribute
	 *
	 *  Window resize-ability [window hint](@ref GLFW_RESIZABLE_hint) and
	 *  [window attribute](@ref GLFW_RESIZABLE_attrib).
	 */
	public const int GLFW_RESIZABLE =              0x00020003;
	/*! @brief Window visibility window hint and attribute
	 *
	 *  Window visibility [window hint](@ref GLFW_VISIBLE_hint) and
	 *  [window attribute](@ref GLFW_VISIBLE_attrib).
	 */
	public const int GLFW_VISIBLE =                0x00020004;
	/*! @brief Window decoration window hint and attribute
	 *
	 *  Window decoration [window hint](@ref GLFW_DECORATED_hint) and
	 *  [window attribute](@ref GLFW_DECORATED_attrib).
	 */
	public const int GLFW_DECORATED =              0x00020005;
	/*! @brief Window auto-iconification window hint and attribute
	 *
	 *  Window auto-iconification [window hint](@ref GLFW_AUTO_ICONIFY_hint) and
	 *  [window attribute](@ref GLFW_AUTO_ICONIFY_attrib).
	 */
	public const int GLFW_AUTO_ICONIFY =           0x00020006;
	/*! @brief Window decoration window hint and attribute
	 *
	 *  Window decoration [window hint](@ref GLFW_FLOATING_hint) and
	 *  [window attribute](@ref GLFW_FLOATING_attrib).
	 */
	public const int GLFW_FLOATING =               0x00020007;
	/*! @brief Window maximization window hint and attribute
	 *
	 *  Window maximization [window hint](@ref GLFW_MAXIMIZED_hint) and
	 *  [window attribute](@ref GLFW_MAXIMIZED_attrib).
	 */
	public const int GLFW_MAXIMIZED =              0x00020008;
	/*! @brief Cursor centering window hint
	 *
	 *  Cursor centering [window hint](@ref GLFW_CENTER_CURSOR_hint).
	 */
	public const int GLFW_CENTER_CURSOR =          0x00020009;
	/*! @brief Window framebuffer transparency hint and attribute
	 *
	 *  Window framebuffer transparency
	 *  [window hint](@ref GLFW_TRANSPARENT_FRAMEBUFFER_hint) and
	 *  [window attribute](@ref GLFW_TRANSPARENT_FRAMEBUFFER_attrib).
	 */
	public const int GLFW_TRANSPARENT_FRAMEBUFFER = 0x0002000A;
	/*! @brief Mouse cursor hover window attribute.
	 *
	 *  Mouse cursor hover [window attribute](@ref GLFW_HOVERED_attrib).
	 */
	public const int GLFW_HOVERED =                0x0002000B;
	/*! @brief Input focus on calling show window hint and attribute
	 *
	 *  Input focus [window hint](@ref GLFW_FOCUS_ON_SHOW_hint) or
	 *  [window attribute](@ref GLFW_FOCUS_ON_SHOW_attrib).
	 */
	public const int GLFW_FOCUS_ON_SHOW =          0x0002000C;

	/*! @brief Mouse input transparency window hint and attribute
	 *
	 *  Mouse input transparency [window hint](@ref GLFW_MOUSE_PASSTHROUGH_hint) or
	 *  [window attribute](@ref GLFW_MOUSE_PASSTHROUGH_attrib).
	 */
	public const int GLFW_MOUSE_PASSTHROUGH =      0x0002000D;

	/*! @brief Initial position x-coordinate window hint.
	 *
	 *  Initial position x-coordinate [window hint](@ref GLFW_POSITION_X).
	 */
	public const int GLFW_POSITION_X =             0x0002000E;

	/*! @brief Initial position y-coordinate window hint.
	 *
	 *  Initial position y-coordinate [window hint](@ref GLFW_POSITION_Y).
	 */
	public const int GLFW_POSITION_Y =             0x0002000F;

	/*! @brief Framebuffer bit depth hint.
	 *
	 *  Framebuffer bit depth [hint](@ref GLFW_RED_BITS).
	 */
	public const int GLFW_RED_BITS =               0x00021001;
	/*! @brief Framebuffer bit depth hint.
	 *
	 *  Framebuffer bit depth [hint](@ref GLFW_GREEN_BITS).
	 */
	public const int GLFW_GREEN_BITS =             0x00021002;
	/*! @brief Framebuffer bit depth hint.
	 *
	 *  Framebuffer bit depth [hint](@ref GLFW_BLUE_BITS).
	 */
	public const int GLFW_BLUE_BITS =              0x00021003;
	/*! @brief Framebuffer bit depth hint.
	 *
	 *  Framebuffer bit depth [hint](@ref GLFW_ALPHA_BITS).
	 */
	public const int GLFW_ALPHA_BITS =             0x00021004;
	/*! @brief Framebuffer bit depth hint.
	 *
	 *  Framebuffer bit depth [hint](@ref GLFW_DEPTH_BITS).
	 */
	public const int GLFW_DEPTH_BITS =             0x00021005;
	/*! @brief Framebuffer bit depth hint.
	 *
	 *  Framebuffer bit depth [hint](@ref GLFW_STENCIL_BITS).
	 */
	public const int GLFW_STENCIL_BITS =           0x00021006;
	/*! @brief Framebuffer bit depth hint.
	 *
	 *  Framebuffer bit depth [hint](@ref GLFW_ACCUM_RED_BITS).
	 */
	public const int GLFW_ACCUM_RED_BITS =         0x00021007;
	/*! @brief Framebuffer bit depth hint.
	 *
	 *  Framebuffer bit depth [hint](@ref GLFW_ACCUM_GREEN_BITS).
	 */
	public const int GLFW_ACCUM_GREEN_BITS =       0x00021008;
	/*! @brief Framebuffer bit depth hint.
	 *
	 *  Framebuffer bit depth [hint](@ref GLFW_ACCUM_BLUE_BITS).
	 */
	public const int GLFW_ACCUM_BLUE_BITS =        0x00021009;
	/*! @brief Framebuffer bit depth hint.
	 *
	 *  Framebuffer bit depth [hint](@ref GLFW_ACCUM_ALPHA_BITS).
	 */
	public const int GLFW_ACCUM_ALPHA_BITS =       0x0002100A;
	/*! @brief Framebuffer auxiliary buffer hint.
	 *
	 *  Framebuffer auxiliary buffer [hint](@ref GLFW_AUX_BUFFERS).
	 */
	public const int GLFW_AUX_BUFFERS =            0x0002100B;
	/*! @brief OpenGL stereoscopic rendering hint.
	 *
	 *  OpenGL stereoscopic rendering [hint](@ref GLFW_STEREO).
	 */
	public const int GLFW_STEREO =                 0x0002100C;
	/*! @brief Framebuffer MSAA samples hint.
	 *
	 *  Framebuffer MSAA samples [hint](@ref GLFW_SAMPLES).
	 */
	public const int GLFW_SAMPLES =                0x0002100D;
	/*! @brief Framebuffer sRGB hint.
	 *
	 *  Framebuffer sRGB [hint](@ref GLFW_SRGB_CAPABLE).
	 */
	public const int GLFW_SRGB_CAPABLE =           0x0002100E;
	/*! @brief Monitor refresh rate hint.
	 *
	 *  Monitor refresh rate [hint](@ref GLFW_REFRESH_RATE).
	 */
	public const int GLFW_REFRESH_RATE =           0x0002100F;
	/*! @brief Framebuffer double buffering hint and attribute.
	 *
	 *  Framebuffer double buffering [hint](@ref GLFW_DOUBLEBUFFER_hint) and
	 *  [attribute](@ref GLFW_DOUBLEBUFFER_attrib).
	 */
	public const int GLFW_DOUBLEBUFFER =           0x00021010;

	/*! @brief Context client API hint and attribute.
	 *
	 *  Context client API [hint](@ref GLFW_CLIENT_API_hint) and
	 *  [attribute](@ref GLFW_CLIENT_API_attrib).
	 */
	public const int GLFW_CLIENT_API =             0x00022001;
	/*! @brief Context client API major version hint and attribute.
	 *
	 *  Context client API major version [hint](@ref GLFW_CONTEXT_VERSION_MAJOR_hint)
	 *  and [attribute](@ref GLFW_CONTEXT_VERSION_MAJOR_attrib).
	 */
	public const int GLFW_CONTEXT_VERSION_MAJOR =  0x00022002;
	/*! @brief Context client API minor version hint and attribute.
	 *
	 *  Context client API minor version [hint](@ref GLFW_CONTEXT_VERSION_MINOR_hint)
	 *  and [attribute](@ref GLFW_CONTEXT_VERSION_MINOR_attrib).
	 */
	public const int GLFW_CONTEXT_VERSION_MINOR =  0x00022003;
	/*! @brief Context client API revision number attribute.
	 *
	 *  Context client API revision number
	 *  [attribute](@ref GLFW_CONTEXT_REVISION_attrib).
	 */
	public const int GLFW_CONTEXT_REVISION =       0x00022004;
	/*! @brief Context robustness hint and attribute.
	 *
	 *  Context client API revision number [hint](@ref GLFW_CONTEXT_ROBUSTNESS_hint)
	 *  and [attribute](@ref GLFW_CONTEXT_ROBUSTNESS_attrib).
	 */
	public const int GLFW_CONTEXT_ROBUSTNESS =     0x00022005;
	/*! @brief OpenGL forward-compatibility hint and attribute.
	 *
	 *  OpenGL forward-compatibility [hint](@ref GLFW_OPENGL_FORWARD_COMPAT_hint)
	 *  and [attribute](@ref GLFW_OPENGL_FORWARD_COMPAT_attrib).
	 */
	public const int GLFW_OPENGL_FORWARD_COMPAT =  0x00022006;
	/*! @brief Debug mode context hint and attribute.
	 *
	 *  Debug mode context [hint](@ref GLFW_CONTEXT_DEBUG_hint) and
	 *  [attribute](@ref GLFW_CONTEXT_DEBUG_attrib).
	 */
	public const int GLFW_CONTEXT_DEBUG =          0x00022007;
	/*! @brief Legacy name for compatibility.
	 *
	 *  This is an alias for compatibility with earlier versions.
	 */
	public const int GLFW_OPENGL_DEBUG_CONTEXT =   GLFW_CONTEXT_DEBUG;
	/*! @brief OpenGL profile hint and attribute.
	 *
	 *  OpenGL profile [hint](@ref GLFW_OPENGL_PROFILE_hint) and
	 *  [attribute](@ref GLFW_OPENGL_PROFILE_attrib).
	 */
	public const int GLFW_OPENGL_PROFILE =         0x00022008;
	/*! @brief Context flush-on-release hint and attribute.
	 *
	 *  Context flush-on-release [hint](@ref GLFW_CONTEXT_RELEASE_BEHAVIOR_hint) and
	 *  [attribute](@ref GLFW_CONTEXT_RELEASE_BEHAVIOR_attrib).
	 */
	public const int GLFW_CONTEXT_RELEASE_BEHAVIOR = 0x00022009;
	/*! @brief Context error suppression hint and attribute.
	 *
	 *  Context error suppression [hint](@ref GLFW_CONTEXT_NO_ERROR_hint) and
	 *  [attribute](@ref GLFW_CONTEXT_NO_ERROR_attrib).
	 */
	public const int GLFW_CONTEXT_NO_ERROR =       0x0002200A;
	/*! @brief Context creation API hint and attribute.
	 *
	 *  Context creation API [hint](@ref GLFW_CONTEXT_CREATION_API_hint) and
	 *  [attribute](@ref GLFW_CONTEXT_CREATION_API_attrib).
	 */
	public const int GLFW_CONTEXT_CREATION_API =   0x0002200B;
	/*! @brief Window content area scaling window
	 *  [window hint](@ref GLFW_SCALE_TO_MONITOR).
	 */
	public const int GLFW_SCALE_TO_MONITOR =       0x0002200C;
	/*! @brief Window framebuffer scaling
	 *  [window hint](@ref GLFW_SCALE_FRAMEBUFFER_hint).
	 */
	public const int GLFW_SCALE_FRAMEBUFFER =      0x0002200D;
	/*! @brief Legacy name for compatibility.
	 *
	 *  This is an alias for the
	 *  [GLFW_SCALE_FRAMEBUFFER](@ref GLFW_SCALE_FRAMEBUFFER_hint) window hint for
	 *  compatibility with earlier versions.
	 */
	public const int GLFW_COCOA_RETINA_FRAMEBUFFER = 0x00023001;
	/*! @brief macOS specific
	 *  [window hint](@ref GLFW_COCOA_FRAME_NAME_hint).
	 */
	public const int GLFW_COCOA_FRAME_NAME =         0x00023002;
	/*! @brief macOS specific
	 *  [window hint](@ref GLFW_COCOA_GRAPHICS_SWITCHING_hint).
	 */
	public const int GLFW_COCOA_GRAPHICS_SWITCHING = 0x00023003;
	/*! @brief X11 specific
	 *  [window hint](@ref GLFW_X11_CLASS_NAME_hint).
	 */
	public const int GLFW_X11_CLASS_NAME =         0x00024001;
	/*! @brief X11 specific
	 *  [window hint](@ref GLFW_X11_CLASS_NAME_hint).
	 */
	public const int GLFW_X11_INSTANCE_NAME =      0x00024002;
	public const int GLFW_WIN32_KEYBOARD_MENU =    0x00025001;
	/*! @brief Win32 specific [window hint](@ref GLFW_WIN32_SHOWDEFAULT_hint).
	 */
	public const int GLFW_WIN32_SHOWDEFAULT =      0x00025002;
	/*! @brief Wayland specific
	 *  [window hint](@ref GLFW_WAYLAND_APP_ID_hint).
	 *  
	 *  Allows specification of the Wayland app_id.
	 */
	public const int GLFW_WAYLAND_APP_ID =         0x00026001;
	/*! @} */

	public const int GLFW_NO_API =                          0;
	public const int GLFW_OPENGL_API =             0x00030001;
	public const int GLFW_OPENGL_ES_API =          0x00030002;

	public const int GLFW_NO_ROBUSTNESS =                   0;
	public const int GLFW_NO_RESET_NOTIFICATION =  0x00031001;
	public const int GLFW_LOSE_CONTEXT_ON_RESET =  0x00031002;

	public const int GLFW_OPENGL_ANY_PROFILE =              0;
	public const int GLFW_OPENGL_CORE_PROFILE =    0x00032001;
	public const int GLFW_OPENGL_COMPAT_PROFILE =  0x00032002;

	public const int GLFW_CURSOR =                  0x00033001;
	public const int GLFW_STICKY_KEYS =             0x00033002;
	public const int GLFW_STICKY_MOUSE_BUTTONS =    0x00033003;
	public const int GLFW_LOCK_KEY_MODS =           0x00033004;
	public const int GLFW_RAW_MOUSE_MOTION =        0x00033005;
	public const int GLFW_UNLIMITED_MOUSE_BUTTONS = 0x00033006;

	public const int GLFW_CURSOR_NORMAL =          0x00034001;
	public const int GLFW_CURSOR_HIDDEN =          0x00034002;
	public const int GLFW_CURSOR_DISABLED =        0x00034003;
	public const int GLFW_CURSOR_CAPTURED =        0x00034004;

	public const int GLFW_ANY_RELEASE_BEHAVIOR =            0;
	public const int GLFW_RELEASE_BEHAVIOR_FLUSH = 0x00035001;
	public const int GLFW_RELEASE_BEHAVIOR_NONE =  0x00035002;

	public const int GLFW_NATIVE_CONTEXT_API =     0x00036001;
	public const int GLFW_EGL_CONTEXT_API =        0x00036002;
	public const int GLFW_OSMESA_CONTEXT_API =     0x00036003;

	public const int GLFW_ANGLE_PLATFORM_TYPE_NONE =    0x00037001;
	public const int GLFW_ANGLE_PLATFORM_TYPE_OPENGL =  0x00037002;
	public const int GLFW_ANGLE_PLATFORM_TYPE_OPENGLES = 0x00037003;
	public const int GLFW_ANGLE_PLATFORM_TYPE_D3D9 =    0x00037004;
	public const int GLFW_ANGLE_PLATFORM_TYPE_D3D11 =   0x00037005;
	public const int GLFW_ANGLE_PLATFORM_TYPE_VULKAN =  0x00037007;
	public const int GLFW_ANGLE_PLATFORM_TYPE_METAL =   0x00037008;

	public const int GLFW_WAYLAND_PREFER_LIBDECOR =    0x00038001;
	public const int GLFW_WAYLAND_DISABLE_LIBDECOR =   0x00038002;

	public const int GLFW_ANY_POSITION =           unchecked((int)0x80000000);

	/*! @defgroup shapes Standard cursor shapes
	 *  @brief Standard system cursor shapes.
	 *
	 *  These are the [standard cursor shapes](@ref cursor_standard) that can be
	 *  requested from the platform (window system).
	 *
	 *  @ingroup input
	 *  @{ */

	/*! @brief The regular arrow cursor shape.
	 *
	 *  The regular arrow cursor shape.
	 */
	public const int GLFW_ARROW_CURSOR =           0x00036001;
	/*! @brief The text input I-beam cursor shape.
	 *
	 *  The text input I-beam cursor shape.
	 */
	public const int GLFW_IBEAM_CURSOR =           0x00036002;
	/*! @brief The crosshair cursor shape.
	 *
	 *  The crosshair cursor shape.
	 */
	public const int GLFW_CROSSHAIR_CURSOR =       0x00036003;
	/*! @brief The pointing hand cursor shape.
	 *
	 *  The pointing hand cursor shape.
	 */
	public const int GLFW_POINTING_HAND_CURSOR =   0x00036004;
	/*! @brief The horizontal resize/move arrow shape.
	 *
	 *  The horizontal resize/move arrow shape.  This is usually a horizontal
	 *  double-headed arrow.
	 */
	public const int GLFW_RESIZE_EW_CURSOR =       0x00036005;
	/*! @brief The vertical resize/move arrow shape.
	 *
	 *  The vertical resize/move shape.  This is usually a vertical double-headed
	 *  arrow.
	 */
	public const int GLFW_RESIZE_NS_CURSOR =       0x00036006;
	/*! @brief The top-left to bottom-right diagonal resize/move arrow shape.
	 *
	 *  The top-left to bottom-right diagonal resize/move shape.  This is usually
	 *  a diagonal double-headed arrow.
	 *
	 *  @note @macos This shape is provided by a private system API and may fail
	 *  with @ref GLFW_CURSOR_UNAVAILABLE in the future.
	 *
	 *  @note @wayland This shape is provided by a newer standard not supported by
	 *  all cursor themes.
	 *
	 *  @note @x11 This shape is provided by a newer standard not supported by all
	 *  cursor themes.
	 */
	public const int GLFW_RESIZE_NWSE_CURSOR =     0x00036007;
	/*! @brief The top-right to bottom-left diagonal resize/move arrow shape.
	 *
	 *  The top-right to bottom-left diagonal resize/move shape.  This is usually
	 *  a diagonal double-headed arrow.
	 *
	 *  @note @macos This shape is provided by a private system API and may fail
	 *  with @ref GLFW_CURSOR_UNAVAILABLE in the future.
	 *
	 *  @note @wayland This shape is provided by a newer standard not supported by
	 *  all cursor themes.
	 *
	 *  @note @x11 This shape is provided by a newer standard not supported by all
	 *  cursor themes.
	 */
	public const int GLFW_RESIZE_NESW_CURSOR =     0x00036008;
	/*! @brief The omni-directional resize/move cursor shape.
	 *
	 *  The omni-directional resize cursor/move shape.  This is usually either
	 *  a combined horizontal and vertical double-headed arrow or a grabbing hand.
	 */
	public const int GLFW_RESIZE_ALL_CURSOR =      0x00036009;
	/*! @brief The operation-not-allowed shape.
	 *
	 *  The operation-not-allowed shape.  This is usually a circle with a diagonal
	 *  line through it.
	 *
	 *  @note @wayland This shape is provided by a newer standard not supported by
	 *  all cursor themes.
	 *
	 *  @note @x11 This shape is provided by a newer standard not supported by all
	 *  cursor themes.
	 */
	public const int GLFW_NOT_ALLOWED_CURSOR =     0x0003600A;
	/*! @brief Legacy name for compatibility.
	 *
	 *  This is an alias for compatibility with earlier versions.
	 */
	public const int GLFW_HRESIZE_CURSOR =         GLFW_RESIZE_EW_CURSOR;
	/*! @brief Legacy name for compatibility.
	 *
	 *  This is an alias for compatibility with earlier versions.
	 */
	public const int GLFW_VRESIZE_CURSOR =         GLFW_RESIZE_NS_CURSOR;
	/*! @brief Legacy name for compatibility.
	 *
	 *  This is an alias for compatibility with earlier versions.
	 */
	public const int GLFW_HAND_CURSOR =            GLFW_POINTING_HAND_CURSOR;
	/*! @} */

	public const int GLFW_CONNECTED =              0x00040001;
	public const int GLFW_DISCONNECTED =           0x00040002;

	/*! @addtogroup init
	 *  @{ */
	/*! @brief Joystick hat buttons init hint.
	 *
	 *  Joystick hat buttons [init hint](@ref GLFW_JOYSTICK_HAT_BUTTONS).
	 */
	public const int GLFW_JOYSTICK_HAT_BUTTONS =   0x00050001;
	/*! @brief ANGLE rendering backend init hint.
	 *
	 *  ANGLE rendering backend [init hint](@ref GLFW_ANGLE_PLATFORM_TYPE_hint).
	 */
	public const int GLFW_ANGLE_PLATFORM_TYPE =    0x00050002;
	/*! @brief Platform selection init hint.
	 *
	 *  Platform selection [init hint](@ref GLFW_PLATFORM).
	 */
	public const int GLFW_PLATFORM =               0x00050003;
	/*! @brief macOS specific init hint.
	 *
	 *  macOS specific [init hint](@ref GLFW_COCOA_CHDIR_RESOURCES_hint).
	 */
	public const int GLFW_COCOA_CHDIR_RESOURCES =  0x00051001;
	/*! @brief macOS specific init hint.
	 *
	 *  macOS specific [init hint](@ref GLFW_COCOA_MENUBAR_hint).
	 */
	public const int GLFW_COCOA_MENUBAR =          0x00051002;
	/*! @brief X11 specific init hint.
	 *
	 *  X11 specific [init hint](@ref GLFW_X11_XCB_VULKAN_SURFACE_hint).
	 */
	public const int GLFW_X11_XCB_VULKAN_SURFACE = 0x00052001;
	/*! @brief Wayland specific init hint.
	 *
	 *  Wayland specific [init hint](@ref GLFW_WAYLAND_LIBDECOR_hint).
	 */
	public const int GLFW_WAYLAND_LIBDECOR =       0x00053001;
	/*! @} */

	/*! @addtogroup init
	 *  @{ */
	/*! @brief Hint value that enables automatic platform selection.
	 *
	 *  Hint value for @ref GLFW_PLATFORM that enables automatic platform selection.
	 */
	public const int GLFW_ANY_PLATFORM =           0x00060000;
	public const int GLFW_PLATFORM_WIN32 =         0x00060001;
	public const int GLFW_PLATFORM_COCOA =         0x00060002;
	public const int GLFW_PLATFORM_WAYLAND =       0x00060003;
	public const int GLFW_PLATFORM_X11 =           0x00060004;
	public const int GLFW_PLATFORM_NULL =          0x00060005;
	/*! @} */

	public const int GLFW_DONT_CARE =              -1;
}
