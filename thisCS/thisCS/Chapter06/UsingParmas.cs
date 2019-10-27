using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter06
{
    class UsingParmas
    {
        static int Sum(params int[] args)
        {
            Console.Write("Summing...");

            int sum = 0;

            for(int i = 0; i<args.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }

                Console.Write(args[i]);

                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }

        //static void Main(string[] args)
        //{
        //    int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
        //    Console.WriteLine($"Sum : {sum}");
        //}
    }
}
/* 가변길이 매개변수
 * params 키워드 사용
 */

