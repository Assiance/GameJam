using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameJam.Scripts.Regular
{
    public interface IEvent
    {
        void Execute();
        string Name { get; }
    }
}
