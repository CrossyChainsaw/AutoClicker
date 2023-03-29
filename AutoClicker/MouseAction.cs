using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal class MouseAction : Action
    {

        public MouseAction(Point point, int delay)
        {
            Point = point;
            Delay = delay;
        }
    }
}
