using Assets.GameJam.Scripts.Regular.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameJam.Scripts.Regular.Scenarios
{
    public class WildPantherScenario : MyMonoBehaviour, IScenario
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get { return "Wild Panthers attacked!"; }
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
