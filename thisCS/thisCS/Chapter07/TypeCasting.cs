using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter07a
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }
    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }
    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }
    class TypeCasting
    {
        //static void Main(string[] args)
        //{
        //    Mammal mammal = new Dog();
        //    Dog dog;

        //    if(mammal is Dog)
        //    {
        //        dog = (Dog)mammal;
        //        dog.Bark();
        //    }

        //    Mammal mammal1 = new Cat();

        //    Cat cat = mammal1 as Cat;
        //    if(cat != null)
        //    {
        //        cat.Meow();
        //    }
        //    else
        //    {
        //        Console.WriteLine("cat2 is not a Cat");
        //    }
        //}
    }
}
/* 기반클래스와 파생클래스 사이의 형식 변환, 그리고 is 와 as
 * is 객체가 해당 형식에 해당하는지를 검사하여 그 결과를 bool값으로 반환
 * as 형식변환과 같은 역할, 형변환은 실패시 예외반환, as는 null로 만든다는게 다름.
 * Bill Wagner는 as를 권장함. as는 참조형식에서만 사용 가능.
 */