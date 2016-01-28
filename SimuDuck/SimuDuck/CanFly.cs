using System;

namespace SimuDuck
{
    public class CanFly:IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying!");
        }
    }
}