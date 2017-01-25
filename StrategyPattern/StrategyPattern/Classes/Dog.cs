using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Classes
{
    class Dog : Animal
    {
        public Dog()
        {
            flyingType = new CannotFly();
           
        }
    }
}
