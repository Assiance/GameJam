using Assets.GameJam.Scripts.Regular.Controllers;
using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular.Scenarios
{
    public class OverConsumptionScenario : BaseScenario
    {

        private void Start()
        {
            
        }
        public override void Execute()
        {
            base.Execute();
        }

        public override string Name
        {
            get { return "Villager Over Consumption!"; }
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
