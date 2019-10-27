using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter06
{
    class UsingOut
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        //static void Main(string[] args)
        //{
        //    int a = 20;
        //    int b = 3;
        //    // int c;
        //    // int d;
        //    Divide(a, b, out int c, out int d);
        //    Console.WriteLine($"a:{a}, b:{b}:, a/b:{c}, a%b:{d}");
        //}
    }
}
/* 출력 전용 매개 변수
 * out
 * ref와 다른점은 값이 할당되지 않으면 컴파일러가 채크해줌.
 */

