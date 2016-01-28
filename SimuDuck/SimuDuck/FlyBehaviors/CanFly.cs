using System;

namespace SimuDuck.FlyBehaviors
{
    public class CanFly:IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying!");
        }
    }
}