using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.GameJam.Scripts.Regular;
using Assets.GameJam.Scripts.Regular.General;
using UnityEngine;


namespace Assets.GameJam.Scripts.Regular.Choices
{
    public class GatherChoice : BaseChoice 
    {
        public override void Execute()
        {
            base.Execute();
            Debug.Log("Gathering");
        }

        public override string Name
        {
            get { return "Gather"; }
        }

        public override bool Disabled { get; set; }        
    }
}
