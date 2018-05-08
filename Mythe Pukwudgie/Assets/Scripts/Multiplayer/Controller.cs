using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    private static string cross1 = "";
    public static string Cross1 { get { return cross1; } }
    private static string leftStickXP1 = "";
    public static string LeftStickXP1 { get { return leftStickXP1; } }
    private static string leftStickYP1 = "";
    public static string LeftStickYP1 { get { return leftStickYP1; } }

    private static string cross2 = "";
    public static string Cross2 { get { return cross2; } }
    private static string leftStickXP2 = "";
    public static string LeftStickXP2 { get { return leftStickXP2; } }
    private static string leftStickYP2 = "";
    public static string LeftStickYP2 { get { return leftStickYP2; } }

    private static string cross3 = "";
    public static string Cross3 { get { return cross3; } }
    private static string leftStickXP3 = "";
    public static string LeftStickXP3 { get { return leftStickXP3; } }
    private static string leftStickYP3 = "";
    public static string LeftStickYP3 { get { return leftStickYP3; } }

    private static string cross4 = "";
    public static string Cross4 { get { return cross4; } }
    private static string leftStickXP4 = "";
    public static string LeftStickXP4 { get { return leftStickXP4; } }
    private static string leftStickYP4 = "";
    public static string LeftStickYP4 { get { return leftStickYP4; } }

    public static void setController(ControllerType controller, OperationSystem os)
    {
        if (cross1 != "")
            return;

        if (os == OperationSystem.mac)
        {
            if (controller == ControllerType.playstation)
            {
                cross1 = "psCrossP1";
                leftStickXP1 = "psLeftStickXP1";
                leftStickYP1 = "psLeftStickYP1";

                cross2 = "psCrossP2";
                leftStickXP2 = "psLeftStickXP2";
                leftStickYP2 = "psLeftStickYP2";

                cross3 = "psCrossP3";
                leftStickXP3 = "psLeftStickXP3";
                leftStickYP3 = "psLeftStickYP3";

                cross4 = "psCrossP4";
                leftStickXP4 = "psLeftStickXP4";
                leftStickYP4 = "psLeftStickYP4";
                return;
            }

            if (controller == ControllerType.xbox)
            {
                cross1 = "xboxAMacP1";
                leftStickXP1 = "xboxLeftStickXMacP1";
                leftStickYP1 = "xboxLeftStickYMacP1";

                cross2 = "xboxAMacP2";
                leftStickXP2 = "xboxLeftStickXMacP2";
                leftStickYP2 = "xboxLeftStickYMacP2";

                cross3 = "xboxAMacP3";
                leftStickXP3 = "xboxLeftStickXMacP3";
                leftStickYP3 = "xboxLeftStickYMacP3";

                cross4 = "xboxAMacP4";
                leftStickXP4 = "xboxLeftStickXMacP4";
                leftStickYP4 = "xboxLeftStickYMacP4";
                return;
            }
        }

        if (os == OperationSystem.windows)
        {
            if (controller == ControllerType.playstation)
            {
                cross1 = "psCrossP1";
                leftStickXP1 = "psLeftStickXP1";
                leftStickYP1 = "psLeftStickYP1";

                cross2 = "psCrossP2";
                leftStickXP2 = "psLeftStickXP2";
                leftStickYP2 = "psLeftStickYP2";

                cross3 = "psCrossP3";
                leftStickXP3 = "psLeftStickXP3";
                leftStickYP3 = "psLeftStickYP3";

                cross4 = "psCrossP4";
                leftStickXP4 = "psLeftStickXP4";
                leftStickYP4 = "psLeftStickYP4";
                return;
            }

            if (controller == ControllerType.xbox)
            {
                cross1 = "xboxAWinP1";
                leftStickXP1 = "xboxLeftStickXWinP1";
                leftStickYP1 = "xboxLeftStickYWinP1";

                cross2 = "xboxAWinP2";
                leftStickXP2 = "xboxLeftStickXWinP2";
                leftStickYP2 = "xboxLeftStickYWinP2";

                cross3 = "xboxAWinP3";
                leftStickXP3 = "xboxLeftStickXWinP3";
                leftStickYP3 = "xboxLeftStickYWinP3";

                cross4 = "xboxAWinP4";
                leftStickXP4 = "xboxLeftStickXWinP4";
                leftStickYP4 = "xboxLeftStickYWinP4";
                return;
            }
        }
    }
}
