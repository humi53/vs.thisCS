using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter08
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }
        public void PublicMehtodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }
        public abstract void AbstractMethodA();
    }
    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();

        }
    }
    class AbstractClass
    {
        //static void Main(string[] args)
        //{
        //    AbstractBase obj = new Derived();
        //    obj.AbstractMethodA();
        //    obj.PublicMehtodA();
        //}
    }
}
/* 추상 클래스 : 인터페이스와 클래스 사이
 * abstract 키워드
 * 상속을 받았을경우 override 키워드를 붙여서 구현 필수!
 */
