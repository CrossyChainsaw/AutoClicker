using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

public enum KeyActionTypes
{
    Press,
    Down,
    Up,
    Placeholder
}

namespace AutoClicker
{
    internal class KeyAction : Action
    {
        public static readonly List<VirtualKeyCode> ALLKEYS = new List<VirtualKeyCode>()
        {
            VirtualKeyCode.CONTROL,
            VirtualKeyCode.ESCAPE,
            VirtualKeyCode.VK_A,
            VirtualKeyCode.VK_B,
            VirtualKeyCode.VK_C,
            VirtualKeyCode.VK_D,
            VirtualKeyCode.VK_V,
            VirtualKeyCode.SPACE,
            VirtualKeyCode.RETURN,
            VirtualKeyCode.F2
        };

        public KeyAction(VirtualKeyCode key, int delay, KeyActionTypes keyActionType)
        {
            Key = key;
            Delay = delay;
            KeyActionType = keyActionType;
            Point = new Point(0, 0); // unused
        }
    }
}
