using System;

public static class InputConsts
{
	[Flags]
	public enum InputType
	{
		None = 0,
		GamePad = 1,
		Keyboard = 4,
		Mouse = 8,
	}

	public enum InputValueType
	{
		NONE,
		BUTTON,
		SINGLE_AXIS,
		DOUBLE_AXIS
	}

	public struct UITextTypeInputs
	{
		public UITextType InputID;
		public UITextType TooltipID;

		public UITextTypeInputs(UITextType inputID, UITextType tooltipID)
		{
			InputID = inputID;
			TooltipID = tooltipID;
		}
	}

	public enum InputCommandType
	{
		UNDEFINED = 0,
		DEPRECATED = 4,
		SELECT = 100,
		MENU_CONFIRM = 101,
		ENTER = 102,
		ENTER2 = 103,
		CANCEL = 104,
		CANCEL_REBINDING1 = 105,
		CANCEL_REBINDING2 = 106,
		ESCAPE = 107,
		SET_DEFAULTS = 108,
		CONFIRM = 109,
		CONFIRM2 = 110,
		UP = 111,
		DOWN = 112,
		RIGHT = 113,
		LEFT = 114,
		MENU_RIGHT = 115,
		MENU_LEFT = 116,
		SUBMENU_RIGHT = 117,
		SUBMENU_LEFT = 118,
		UP2 = 119,
		DOWN2 = 120,
		RIGHT2 = 121,
		LEFT2 = 122,
		TAB = 123,
		TABL = 124,
		TABR = 125,
		TABL2 = 126,
		TABR2 = 127,
		SHIFTL = 128,
		SHIFTR = 129,
		PAUSE = 130,
		FACE_UP = 131,
		FACE_DOWN = 132,
		FACE_LEFT = 133,
		FACE_RIGHT = 134,
		SWAP_SHIP_LOG_MODE = 200,
		MARK_ENTRY_ON_HUD = 201,
		SCROLLING_TEXT = 202,
		MAP = 210,
		MAP_ZOOM = 211,
		MAP_MOUSE0 = 212,
		MAP_MOUSE1 = 213,
		MAP_ZOOM_IN = 214,
		MAP_ZOOM_OUT = 215,
		MOVE_XZ = 220,
		MOVE_X = 221,
		MOVE_Z = 222,
		LOOK = 223,
		LOOK_X = 224,
		LOOK_Y = 225,
		JUMP = 226,
		INTERACT = 230,
		SLEEP = 231,
		SUIT_MENU = 232,
		INTERACT_SECONDARY = 233,
		FLASHLIGHT = 240,
		EXTEND_STICK = 241,
		TOOL_PRIMARY = 250,
		TOOL_SECONDARY = 251,
		TOOL_X = 252,
		TOOL_Y = 253,
		TOOL_UP = 254,
		TOOL_DOWN = 255,
		TOOL_RIGHT = 256,
		TOOL_LEFT = 257,
		SIGNALSCOPE = 260,
		SCOPEVIEW = 261,
		PROBELAUNCH = 270,
		PROBERETRIEVE = 271,
		ROLL_MODE = 280,
		BOOST = 281,
		THRUSTX = 282,
		THRUSTZ = 283,
		THRUST_UP = 284,
		THRUST_DOWN = 285,
		YAW = 286,
		PITCH = 287,
		LOCKON = 300,
		MATCH_VELOCITY = 301,
		LANDING_CAMERA = 310,
		AUTOPILOT = 311,
		FREELOOK = 312,
		TAKE_SCREENSHOT = 900,
		TAKE_2XSCREENSHOT = 901,
		SLOWDOWNTIME = 902,
		SPEEDUPTIME = 903,
	}

}
