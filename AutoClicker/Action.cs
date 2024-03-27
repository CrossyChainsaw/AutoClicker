using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

namespace AutoClicker
{
    internal class Action
    {
        public VirtualKeyCode Key { get; internal set; }
        public int Delay { get; internal set; }
        public Point Point { get; internal set; }

        public void SetPoint(Point point)
        {
            Point = point;
        }
        public void SetKey(VirtualKeyCode key)
        {
            Key = key;
        }
        public void SetDelay(int delay)
        {
            Delay = delay;
        }
    }
}
