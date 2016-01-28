using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformSwim();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.WriteLine();

            var redhead = new RedheadDuck();
            redhead.Display();
            redhead.PerformSwim();
            redhead.PerformQuack();
            redhead.PerformFly();

            Console.WriteLine();

            var rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.PerformSwim();
            rubberDuck.PerformQuack();
            rubberDuck.PerformFly();

            Console.WriteLine();

            var decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.PerformSwim();
            decoyDuck.PerformQuack();
            decoyDuck.PerformFly();

            Console.WriteLine();

            var robotDuck = new RobotDuck();
            robotDuck.Display();
            robotDuck.PerformSwim();
            robotDuck.PerformQuack();
            robotDuck.PerformFly();

            Console.ReadLine();


            robotDuck.FlyBehavior = new Rockets();

            robotDuck.PerformFly();

            Console.ReadLine();

        }
    }
}
