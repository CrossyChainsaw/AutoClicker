using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal class Action
    {
        //public Keys Key { get; internal set; }
        public string Key { get; internal set; }
        public int Delay { get; internal set; }
        public Point Point { get; internal set; }

        public void SetPoint(Point point)
        {
            Point = point;
        }
        public void SetKey(string key)
        {
            Key = key;
        }
        public void SetDelay(int delay)
        {
            Delay = delay;
        }
    }
}
