using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameJam.Scripts.Regular.Events
{
    public class ScienceBookDiscoveryEvent : IEvent
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
