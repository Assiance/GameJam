﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.GameJam.Scripts.Regular
{
    public interface IChoice
    {
        bool DoExecute { get; set; }
        bool Disabled { get; set; }
        void Execute();
        string Name { get; }
    }
}
