using System;

namespace SimuDuck
{
    public class CanQuack:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("QUACK!");
        }
    }
}