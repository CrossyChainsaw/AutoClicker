using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

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
            VirtualKeyCode.SPACE,
            VirtualKeyCode.RETURN
        };

        public KeyAction(VirtualKeyCode key, int delay)
        {
            Key = key;
            Delay = delay;
            Point = new Point(0, 0); // not used data
        }
    }
}
