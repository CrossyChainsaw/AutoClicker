using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    internal class TextAction : Action
    {
        public TextAction(string text, int delay)
        {
            Text = text;
            Delay = delay;
        }
    }
}
