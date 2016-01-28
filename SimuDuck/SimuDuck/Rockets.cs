using System;

namespace SimuDuck
{
    public class Rockets : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("ROOOAAARRARA!!!!!");
        }
    }
}