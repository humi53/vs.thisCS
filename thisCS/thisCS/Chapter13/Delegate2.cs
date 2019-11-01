using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter13
{
    delegate int MyDelegate(int a, int b);
    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Delegate2
    {
        //static void Main(string[] args)
        //{
        //    Calculator Calc = new Calculator();
        //    MyDelegate Callback;

        //    Callback = new MyDelegate(Calc.Plus);
        //    Console.WriteLine(Callback(3, 4));

        //    Callback = new MyDelegate(Calculator.Minus);
        //    Console.WriteLine(Callback(7, 5));
        //}
    }
}
/* 대리자란?
 * 메소드를 파라미터로 넘겨준다.
 * 그리고 받은쪽에서 실행하고 싶을때 해당 메소드를 대신 실행하면
 * 실행이된다.
 * A -> B 로 메소드 넘김 : 넘길때 인터페이스처럼 규칙만 맞다면 A의것이 아닌 다른놈꺼 메소드를 넘길수도 있음.
 * B가 실행하고 싶을때 메소드를 실행
 * B가 A의 메소드를 자기것처럼 실행이 가능.
 * B에서 A의 객체를 생성해서 해당메소드를 실행하는 것과는 다름.
 * B가 A의 메소드를 자기메소드처럼 실행하는것이 포인트!!
 */
