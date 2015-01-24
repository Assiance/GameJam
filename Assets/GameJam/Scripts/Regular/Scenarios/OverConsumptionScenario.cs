using Assets.GameJam.Scripts.Regular.Controllers;
using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular.Scenarios
{
    public class OverConsumptionScenario : MyMonoBehaviour, IScenario
    {
        public void Execute()
        {
            PlayerStats playerstats = gameObject.GetComponent<PlayerStats>() as PlayerStats;
        }

        public string Name
        {
            get { return "Villager Over Consumption!"; }
        }


        public string Description
        {
            get { throw new NotImplementedException(); }
        }

        public string Effect
        {
            get { throw new NotImplementedException(); }
        }

        public string Resolution
        {
            get { throw new NotImplementedException(); }
        }
    }
}
