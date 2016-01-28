using System;

namespace SimuDuck.FlyBehaviors
{
    public class Rockets : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("ROOOAAARRARA!!!!!");
        }
    }
}