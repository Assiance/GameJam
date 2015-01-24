using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular;

namespace Assets.GameJam.Scripts
{
    public class GatherChoice : IChoice
    {
        public void Execute()
        {
            // Increase resources! Hooray!
        }

        public string Name
        {
            get { return "Gather"; }
        }

        public bool Disabled { get; set; }        
    }
}
