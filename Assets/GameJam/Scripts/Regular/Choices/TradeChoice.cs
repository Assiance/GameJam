using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.UI;

namespace Assets.GameJam.Scripts.Regular.Choices
{
    public class TradeChoice : BaseChoice 
    {

        public override void Execute()
        {
            Image[] images = gameObject.GetComponentsInChildren<Image>();
            foreach(var image in images)
            {
                if(image.name == "ChoiceOptionsBG")
                {
                    image.active = !image.active;
                }
            }
        }

        public override string Name
        {
            get { return "Gather"; }
        }

        public override bool Disabled { get; set; } 
    }
}
