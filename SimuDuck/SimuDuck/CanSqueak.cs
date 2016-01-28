using System;

namespace SimuDuck
{
    public class CanSqueak:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}