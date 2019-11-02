using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter14
{
    class ActionTest
    {
        //static void Main(string[] args)
        //{
        //    Action act1 = () => Console.WriteLine("Action()");
        //    act1();

        //    int result = 0;
        //    Action<int> act2 = (x) => result = x * x;

        //    act2(3);
        //    Console.WriteLine($"result : {result}");

        //    Action<double, double> act3 = (x, y) =>
        //    {
        //        double pi = x / y;
        //        Console.WriteLine($"Action<T1, T2>({x}, {y}) : {pi}");
        //    };
        //    act3(22.0, 7.0);
        //}
    }
}
/* Func와 Action으로 더 간편하게 무명 함수 만들기
 * Action 대리자
 * Func처럼 17개의 버전이 제공되지만 반환형식이 없다.
 * 람다식 밖에서 선언된 변수에 접근해 값을 변경하는것이 가능하다. (결과를 반환한 효과?)
 */

