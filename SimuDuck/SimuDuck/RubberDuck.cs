using System;

namespace SimuDuck
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