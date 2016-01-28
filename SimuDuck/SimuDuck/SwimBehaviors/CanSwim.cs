using System;

namespace SimuDuck.SwimBehaviors
{
    public class CanSwim:ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("Splish splash!");
        }
    }
}