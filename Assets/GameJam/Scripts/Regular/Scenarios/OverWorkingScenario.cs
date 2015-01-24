using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameJam.Scripts.Regular.Scenarios
{
    public class OverWorkingScenario : BaseScenario
    {
        public override void Execute()
        {
            base.Execute();
        }

        public override string Name
        {
            get { return "Villagers are tired!"; }
        }


        public override string Description
        {
            get { throw new NotImplementedException(); }
        }

        public override string Effect
        {
            get { throw new NotImplementedException(); }
        }

        public override string Resolution
        {
            get { throw new NotImplementedException(); }
        }
    }
}
