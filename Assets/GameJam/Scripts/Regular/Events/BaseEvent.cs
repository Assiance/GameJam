using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameJam.Scripts.Regular.Events
{
    public class BaseEvent : MyMonoBehaviour, IEvent
    {
          public int ResourcesModifier=0;
          public int PopulationModifier = 0;
          public int MoraleModifier= 0;

          public virtual void Execute()
          {
              var playerstats = gameObject.GetComponent<PlayerStatus>();
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
