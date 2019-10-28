using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter07
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }
    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }
    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }
    class Oeverriding
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Creating ArmorSuite...");
        //    ArmorSuite armorSuite = new ArmorSuite();
        //    armorSuite.Initialize();

        //    Console.WriteLine("\nCreating IronMan...");
        //    ArmorSuite ironMan = new IronMan();
        //    ironMan.Initialize();

        //    Console.WriteLine("\nCreating WarMachine...");
        //    ArmorSuite warmachine = new WarMachine();
        //    warmachine.Initialize();
        //}
    }
}
/* 오버라이딩과 다형성
 * private로 선언한 메소드는 오버라이딩 불가.
 */