using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter07
{
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }
        ~Base()
        {
            Console.WriteLine($"{this.Name}.~Base()");
        }
        public void BaseMethod()
        {
            Console.WriteLine($"{Name}.BaseMethod()");
        }
    }
    class Derived : Base
    {
        public Derived(string Name): base(Name)
        {
            Console.WriteLine($"{this.Name}.Derived()");
        }
        ~Derived()
        {
            Console.WriteLine($"{this.Name}.~Derived()");
        }
        public void DerivedMethod()
        {
            Console.WriteLine($"{Name}.DerivedMethod");
        }
    }
    class Inheritance
    {
        //static void Main(string[] args)
        //{
        //    Base a = new Base("a");
        //    a.BaseMethod();

        //    Derived b = new Derived("b");
        //    b.BaseMethod();
        //    b.DerivedMethod();
        //}
    }
}
/* 상속으로 코드 재활용하기
 */