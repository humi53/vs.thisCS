using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter14
{
    class FuncTest
    {
        //static void Main(string[] args)
        //{
        //    Func<int> func1 = () => 10;
        //    Console.WriteLine($"func1() : {func1()}");

        //    Func<int, int> func2 = (x) => x * 2;
        //    Console.WriteLine($"func2(4) : {func2(4)}");

        //    Func<double, double, double> func3 =
        //        (x, y) => x / y;
        //    Console.WriteLine($"func3(22, 7) : {func3(22, 7)}");

        //    Func<int, int, string> func4 =
        //        (x, y) => x.ToString() + y.ToString();
        //    Console.WriteLine($"func4(1, 2) : {func4(1,2)}");
        //}
    }
}
/* Func와 Action으로 더 간편하게 무명 함수 만들기
 * Func 대리자
 * .Net 프레임워크는 17가지의 버전을 준비되있다.
 * 매개변수가 0개부터 16개까지 가능.
 * 맨 뒤에 있는것은 out TResult 타입.
 * 예)  Func<in T1, in T2, out TResult> : T1, T2는 매개변수타입 TResult는 반환변수타입
 * 여러개의 매개변수 1개의 반환.
 */
