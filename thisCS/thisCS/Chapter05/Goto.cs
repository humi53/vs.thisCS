using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter05
{
    class Goto
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("종료 조건(숫자)을 입력하세요 :");

        //    string input = Console.ReadLine();

        //    int input_number = Convert.ToInt32(input);
        //    int exit_number = 0;

        //    for(int i = 0; i < 2; i++)
        //    {
        //        for(int j = 0; j<2; j++)
        //        {
        //            for(int k = 0; k < 3; k++)
        //            {
        //                if (exit_number++ == input_number)
        //                    goto EXIT_FOR;
        //            }
        //        }
        //    }

        //    goto EXIT_PROGRAM;

        //EXIT_FOR:
        //    Console.WriteLine("\nExit nested for...");

        //EXIT_PROGRAM:
        //    Console.WriteLine("Exit program...");
        //}
    }
}
/* goto
 * 스파게티 소스의 위험.
 * 최대한 사용하지 않는게 좋음
 * 유용한 사용의 예중 하나는 중첩for문을 한번에 종료하고 나올수 있다.
 */