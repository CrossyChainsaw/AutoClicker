using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal class KeyAction : Action
    {
        static public List<Keys> AllKeys = new List<Keys>() { Keys.Left, Keys.Right, Keys.Down, Keys.Up, Keys.Escape, Keys.W, Keys.A, Keys.S, Keys.D, Keys.Z, Keys.X, Keys.C, Keys.V, Keys.Alt, Keys.Enter, Keys.Shift, Keys.Tab, Keys.Space, Keys.Back, Keys.F5, Keys.D0, Keys.D1 };
        public List<string> AllKeyStrings = new List<string>() { "", "{ESC}", "{F5}", "{ENTER}", "TEST" };
        public KeyAction(string key, int delay)
        {
            Key = key;
            Delay = delay;
        }
    }
}
