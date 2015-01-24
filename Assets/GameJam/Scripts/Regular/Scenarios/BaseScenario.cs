using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameJam.Scripts.Regular.Scenarios
{
    public class BaseScenario : MyMonoBehaviour, IScenario
    {
        public int ResourcesModifier =-2;
        public int PopulationModifier = 0;
        public int MoraleModifier = 0;

        public virtual void Execute()
        {
            var playerstats = gameObject.GetComponent<PlayerStats>();
            playerstats.Resources += ResourcesModifier;
            playerstats.Population += PopulationModifier;
            playerstats.Morale += MoraleModifier;
        }

        public virtual string Name
        {
            get { throw new NotImplementedException(); }
        }

        public virtual string Description
        {
            get { throw new NotImplementedException(); }
        }

        public virtual string Effect
        {
            get { throw new NotImplementedException(); }
        }

        public virtual string Resolution
        {
            get { throw new NotImplementedException(); }
        }
    }
}
