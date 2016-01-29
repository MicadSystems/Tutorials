using System;
using System.Collections.Generic;
using SimuDuck.Ducks;
using SimuDuck.FlyBehaviors;

namespace SimuDuck
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var robotDuck = new RobotDuck();

            var flock = new List<Duck>
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new DecoyDuck(),
                robotDuck
            };

            foreach (var duck in flock)
            {
                DoDuck(duck);
                Console.WriteLine();
            }

            Console.ReadLine();

            robotDuck.FlyBehavior = new Rockets();

            DoDuck(robotDuck);

            Console.ReadLine();
            
        }

        private static void DoDuck(Duck duck)
        {
            duck.Display();
            duck.PerformSwim();
            duck.PerformQuack();
            duck.PerformFly();
        }
    }
}
