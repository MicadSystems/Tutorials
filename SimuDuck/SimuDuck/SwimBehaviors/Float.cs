using System;

namespace SimuDuck.SwimBehaviors
{
    public class Float:ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("Floating");
        }
    }
}