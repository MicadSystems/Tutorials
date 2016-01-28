using System;

namespace SimuDuck
{
    public abstract class Duck
    {
        public IQuackBehavior QuackBehavior { get; set; } = new CanQuack();
        public IFlyBehavior FlyBehavior { get; set; } = new CanFly();
        public ISwimBehavior SwimBehavior { get; set; } = new CanSwim();
        

        public abstract void Display();

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformSwim()
        {
            SwimBehavior.Swim();
        }

    }
}