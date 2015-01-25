using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular.Choices
{
    public class BaseChoice : MyMonoBehaviour, IChoice
    {
        public int ResourcesModifier = 6;
        public int PopulationModifier = 6;
        public int MoraleModifier = 6;

        public virtual bool DoExecute { get; set; }

        public virtual bool Disabled
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual void Execute()
        {
            var playerstats = gameObject.GetComponent<PlayerStatus>();
            playerstats.Resources += playerstats.Skill == "Resources" ? (int)(ResourcesModifier * playerstats.SkillMultiplier) : ResourcesModifier;
            playerstats.Population += playerstats.Skill == "Population" ? (int)(PopulationModifier * playerstats.SkillMultiplier) : PopulationModifier;
            playerstats.Morale += playerstats.Skill == "Morale" ? (int)(MoraleModifier * playerstats.SkillMultiplier) : MoraleModifier;
        }

        public virtual string Name
        {
            get { throw new NotImplementedException(); }
        }

        public void PrepareChoice()
        {
            Debug.Log("Choice Prepared");
            DoExecute = true;
        }
    }
}
