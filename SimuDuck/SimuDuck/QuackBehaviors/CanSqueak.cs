using System;

namespace SimuDuck.QuackBehaviors
{
    public class CanSqueak:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}