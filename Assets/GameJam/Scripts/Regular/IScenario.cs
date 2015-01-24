using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameJam.Scripts.Regular
{
    public interface IScenario
    {
        void Execute();
        string Name {get;}
        string Description { get; }
        string Effect { get; }
        string Resolution { get; }
    }
}
