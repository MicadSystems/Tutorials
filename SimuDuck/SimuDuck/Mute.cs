using System;

namespace SimuDuck
{
    public class Mute:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}