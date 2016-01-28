using System;

namespace SimuDuck
{
    public class DecoyDuck:Duck
    {
        public DecoyDuck()
        {
            QuackBehavior = new Mute();
            FlyBehavior = new FlyNoWay();
            SwimBehavior = new Float();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Decoy!");
        }
        
    }
}