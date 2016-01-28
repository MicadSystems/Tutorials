using System;
using SimuDuck.SwimBehaviors;

namespace SimuDuck.Ducks
{
    public class RobotDuck:Duck
    {
        public RobotDuck()
        {
            base.SwimBehavior = new Sinks();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a robot duck!");
        }
    }
}