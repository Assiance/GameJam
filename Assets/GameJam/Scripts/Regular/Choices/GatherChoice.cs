using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular;
using Assets.GameJam.Scripts.Regular.General;

namespace Assets.GameJam.Scripts
{
    public class GatherChoice : MyMonoBehaviour, IChoice
    {
        public void Execute()
        {
            // Increase resources! Hooray!
        }

        public string Name
        {
            get { return "Gather"; }
        }

        public bool DoExecute { get; set; }
        public bool Disabled { get; set; }        
    }
}
