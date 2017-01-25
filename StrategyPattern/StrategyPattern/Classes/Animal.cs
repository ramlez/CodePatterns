using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Classes
{
    class Animal
    {

        //This field allows us to dynamically change the abilities of the animal.
        //We can now allow an animal to fly at runtime.
        public IFlies flyingType;

        public string TryToFly()
        {
            return flyingType.fly();
        }

        public void SetFlyingAbility(IFlies newFlyingType)
        {
            flyingType = newFlyingType;
        }


    }
}
