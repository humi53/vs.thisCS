using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace thisCS.Chapter15
{
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }
    class Example1
    {
        //static void Main(string[] args)
        //{
        //    Car[] cars =
        //    {
        //        new Car(){Cost = 56, MaxSpeed=120},
        //        new Car(){Cost = 70, MaxSpeed=150},
        //        new Car(){Cost = 45, MaxSpeed=180},
        //        new Car(){Cost = 32, MaxSpeed=200},
        //        new Car(){Cost = 82, MaxSpeed=200}
        //    };
        //    var selected = from car in cars
        //                   where car.Cost >= 50 && car.MaxSpeed >= 150
        //                   select car;

        //    foreach(var car in selected)
        //    {
        //        Console.WriteLine("{0} {1}", car.Cost, car.MaxSpeed);
        //    }
        //}

      
    }
}
/* Cost가 50이상, MaxSpeed는 150이상인 레코드를 조회하는 LINQ */
