using System;

namespace SimuDuck.QuackBehaviors
{
    public class CanQuack:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("QUACK!");
        }
    }
}