using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter08
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }
    class FlyingCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }

        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }
    }
    class MultiInterfaceInhritance
    {
        //static void Main(string[] args)
        //{
        //    FlyingCar car = new FlyingCar();
        //    car.Run();
        //    car.Fly();

        //    IRunnable runnable = car as IRunnable;
        //    runnable.Run();

        //    IFlyable flyable = car as IFlyable;
        //    flyable.Fly();
        //}

        
    }
}
/* 여러 개의 인터페이스, 한꺼번에 상속하기
 */
