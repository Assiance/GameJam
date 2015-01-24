using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameJam.Scripts.Regular
{
    public class PlayerStats : MyMonoBehaviour
    {
        public int PlayerId { get; set; }
        public int Population{set;get;}
        public int Resources { set; get; }
        public int Morale { set; get; }
        public double SkillMultiplier { get; set; }
        public string Skill { get; set; }
        public string Name { get; set; }

    }
}
