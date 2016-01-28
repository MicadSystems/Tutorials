using System;
using SimuDuck.FlyBehaviors;
using SimuDuck.QuackBehaviors;
using SimuDuck.SwimBehaviors;

namespace SimuDuck.Ducks
{
    public class RubberDuck:Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new CanSqueak();
            FlyBehavior = new FlyNoWay();
            SwimBehavior = new Float();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck!");
        }
        
    }
}