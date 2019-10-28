using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter07a
{
    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod");
        }
    }
    class Derived : Base
    {
        public new void MyMethod()
        {
            Console.WriteLine("Derived.MyMethod");
        }
    }
    class MethodHiding
    {
        //static void Main(string[] args)
        //{
        //    Base baseObj = new Base();
        //    baseObj.MyMethod();

        //    Derived derivedObj = new Derived();
        //    derivedObj.MyMethod();

        //    Base baseOrDerived = new Derived();
        //    baseOrDerived.MyMethod();
        //}
    }
}
/* 메소드 숨기기
 * new 키워드
 * 다형성은 사용하지 못함
 */