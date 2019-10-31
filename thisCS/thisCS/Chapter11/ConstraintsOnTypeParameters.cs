using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter11
{
    interface IStart
    {
        void Run();
    }
    interface IPara
    {
        void Fly();
    }
    class PlayMan<T> where T : IStart, IPara
    {
        public void Run(T obj)
        {
            obj.Run();
        }
        public void Fly(T obj)
        {
            obj.Fly();
        }
    }
    class InMan : IStart, IPara
    {
        public void Fly()
        {
            Console.WriteLine("뛴다.");
        }

        public void Run()
        {
            Console.WriteLine("날아간다.");
        }
    }

    class StructArray<T> where T : struct
    {
        public T[] Array { get; set;}
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }
    class RefArray<T> where T : class
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }
    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }
        public void CopyArray<T>(T[] Source) where T : U
        {
            Source.CopyTo(Array, 0);
        }
    }
    class ConstraintsOnTypeParameters
    {
        //public static T CreatInstance<T>() where T : new()
        //{
        //    return new T();
        //}
        //public static void Main(string[] args)
        //{
        //    StructArray<int> a = new StructArray<int>(3);
        //    a.Array[0] = 0;
        //    a.Array[1] = 1;
        //    a.Array[2] = 2;

        //    RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
        //    b.Array[0] = new StructArray<double>(5);
        //    b.Array[1] = new StructArray<double>(10);
        //    b.Array[2] = new StructArray<double>(1004);

        //    BaseArray<Base> c = new BaseArray<Base>(3);
        //    c.Array[0] = new Base();
        //    c.Array[1] = new Derived();
        //    c.Array[2] = CreatInstance<Base>();

        //    BaseArray<Derived> d = new BaseArray<Derived>(3);
        //    d.Array[0] = new Derived();
        //    d.Array[1] = CreatInstance<Derived>();
        //    d.Array[2] = CreatInstance<Derived>();

        //    BaseArray<Derived> e = new BaseArray<Derived>(3);
        //    e.CopyArray<Derived>(d.Array);

            
        //    PlayMan<InMan> pm = new PlayMan<InMan>();
        //    pm.Fly(new InMan());


        //}
    }
}
/* 형식 매개 변수 제약지키기
 * where 로 형식을 제약 where 형식매개변수 : 제약조건
 * 제약조건
 *      where T : struct        T는 값형식
 *      where T : class         T는 참조형식
 *      where T : new()         T는 반드시 매개변수가 없는 생성자가 있어야한다.
 *      where T : 기반클래스     T는 명시한 기반클래스의 파생 클래스여야 한다.
 *      where T : 인터페이스     T는 명시한 인터페이스를 반드시 구현해야 한다. 인터페이스 이름에는 여러개의 인터페이스를 명시할 수도 있다.
 *      where T : U             T는 또다른 형식 매개 변수 U로부터 상속받은 클래스여야 한다.
 */
