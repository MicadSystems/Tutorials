using System;

namespace SimuDuck
{
    public class CanSwim:ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("Splish splash!");
        }
    }
}