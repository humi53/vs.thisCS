using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter06
{
    class SwapByRef
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        //static void Main(string[] args)
        //{
        //    int x = 3;
        //    int y = 4;

        //    Console.WriteLine($"{x} , {y}");
        //    Swap(ref x, ref y);
        //    Console.WriteLine($"{x} , {y}");
        //}
    }
}
/* 참조에 의한 매개 변수 전달
 * 변수 앞에 ref를 붙인다.
 * 값형식의 변수를 참조형식으로 넘길수 있다.
 */
