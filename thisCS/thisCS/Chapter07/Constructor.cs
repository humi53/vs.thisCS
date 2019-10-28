using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter07
{
    class Cat
    {
        public string name;
        public string color;
        public Cat()
        {
            name = "";
            color = "";
        }

        public Cat(string _name, string _color)
        {
            name = _name;
            color = _color;
        }

        ~Cat()
        {
            Console.WriteLine($"{name} : 잘가");
        }

        public void meow()
        {
            Console.WriteLine($"{name} : 야옹");
        }
    }
    class Constructor
    {
        //static void Main(string[] args)
        //{
        //    Cat kitty = new Cat("키티", "하얀색");
        //    kitty.meow();
        //    Console.WriteLine($"{kitty.name} : {kitty.color}");

        //    Cat nero = new Cat("네로", "검은색");
        //    nero.meow();
        //    Console.WriteLine($"{nero.name} : {nero.color}");

        //}
    }
}
/* 생성자와 종료자
 * 종료자는 사용하지 않는게 좋음.
 */