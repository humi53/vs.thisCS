using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter06
{
    class SwapByValue
    {
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        //static void Main(String[] args)
        //{
        //    int x = 3;
        //    int y = 4;

        //    Console.WriteLine();

        //    Swap(x, y);
        //    Console.WriteLine();
        //}
    }
}
/* 매개 변수에 대하여
 */
