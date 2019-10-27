using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter06
{
    class LocalFuction
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }
            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(ToLowerString("Hello!"));
        //    Console.WriteLine(ToLowerString("Good Morning."));
        //    Console.WriteLine(ToLowerString("This is C#."));

        //}
    }
}
/* 로컬 함수
 * 람다식과 더불어 코드를 간추릴수 있는 옵션중 하나.
 */


