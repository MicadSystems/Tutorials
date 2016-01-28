using System;

namespace SimuDuck
{
    internal class RobotDuck:Duck
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