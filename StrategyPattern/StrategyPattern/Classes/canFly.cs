using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Classes
{
    class CanFly : IFlies
    {
        public string fly()
        {
            return "I can fly";
        }
    }
}
