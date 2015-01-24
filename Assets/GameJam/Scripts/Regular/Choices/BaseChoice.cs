using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameJam.Scripts.Regular.Choices
{
    public class BaseChoice : MyMonoBehaviour, IChoice
    {
        public int ResourcesModifier = -2;
        public int PopulationModifier = 0;
        public int MoraleModifier = 0;

        public bool DoExecute { get; set; }

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
            var playerstats = gameObject.GetComponent<PlayerStats>();
            playerstats.Resources += ResourcesModifier;
            playerstats.Population += PopulationModifier;
            playerstats.Morale += MoraleModifier;
        }

        public virtual string Name
        {
            get { throw new NotImplementedException(); }
        }
    }
}
