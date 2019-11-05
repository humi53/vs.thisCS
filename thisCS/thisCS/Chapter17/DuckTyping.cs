using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter17
{
    class Duck
    {
        public void Walk()
        {Console.WriteLine(this.GetType() + ".Walk");}
        public void Swim()
        { Console.WriteLine(this.GetType() + ".Swim"); }
        public void Quack()
        { Console.WriteLine(this.GetType() + ".Quack"); }
    }
    class Mallard : Duck
    { }
    class Robot
    {
        public void Walk()
        { Console.WriteLine(this.GetType() + ".Walk"); }
        public void Swim()
        { Console.WriteLine(this.GetType() + ".Swim"); }
        public void Quack()
        { Console.WriteLine(this.GetType() + ".Quack"); }
    }

    class DuckTyping
    {
        //static void Main(string[] args)
        //{
        //    dynamic[] arr = new dynamic[] { new Duck(), new Mallard(), new Robot() };
        //    foreach(dynamic duck in arr)
        //    {
        //        Console.WriteLine(duck.GetType());
        //        duck.Walk();
        //        duck.Swim();
        //        duck.Quack();
        //        Console.WriteLine();
        //    }
        //}
    }
}
/* 오리 타이핑
 * "오리처럼 걷고 오리처럼 헤어치며 오리처럼 꽉꽉 거리는 새를 봤을 때, 나는 그 새를 오리라고 부른다." 제임스 위스콤 라일리
 * 오리 타이핑을 가장 잘 설명하는 문장이다.
 * C#에선 오리라고 인정받기 위해선 그 형식의 조상중에 오리가 있어야 한다.
 * 반면 오리타이핑에선 어떤 형식이 오리로 인정 받으려면 오리처럼 걷고, 오리처럼 헤엄치고, 오리처럼 꽉꽉거리기만 하면된다.
 * 형식은 어느 형식으로부터 상속받는지는 전혀 중요하지 않다.
 * 오리타이핑의 철학을 C#에선 dynamic 형식을 통해 구현할수 있다.
 * 
 * 인터페이스의 설계는 추상화를 잘해야되는데 많은 연습과 경험이 필요하고, 잘못설계하면 수정해야할 일들이 늘어난다.
 * 하지만 오리타이핑은 상속관계를 이용하지 않기 때문에 좀 더 유연한 해결이 가능하다. 동작에 관련된 부분만 손대면 되기때문.
 * 
 * 오리 타이핑은 비주얼 스튜디오의 리팩토리 기능을 이용할수 없어 불편하다.
 * 인터페이스냐 오리타이핑이냐는 대개 프로그래머의 취향에 따라 답이 다르게 나온다.
 * 
 */
