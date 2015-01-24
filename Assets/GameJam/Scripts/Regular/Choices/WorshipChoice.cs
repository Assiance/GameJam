using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameJam.Scripts.Regular.Choices
{
    public class WorshipChoice : MyMonoBehaviour, IChoice
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
