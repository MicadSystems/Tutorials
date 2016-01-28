using System;

namespace SimuDuck.QuackBehaviors
{
    public class Mute:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}