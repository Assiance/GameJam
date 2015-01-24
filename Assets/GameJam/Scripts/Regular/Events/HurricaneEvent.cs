using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameJam.Scripts.Regular.Events
{
    public class HurricaneEvent : IEvent
    {
        public void Execute()
        {
            // Do something
        }

        public string Name
        {
            get { return "Tornado"; }
        }
    }
}
