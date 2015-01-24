using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameJam.Scripts.Regular.Choices
{
    public class RaidChoice : BaseChoice 
    {
        public override void Execute()
        {
            base.Execute();
        }

        public override string Name
        {
            get { return "Gather"; }
        }

        public bool DoExecute { get; set; }
        public override bool Disabled { get; set; }  
    }
}
