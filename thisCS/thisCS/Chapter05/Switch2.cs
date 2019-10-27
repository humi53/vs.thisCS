using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter05
{
    class Switch2
    {
        //static void Main(string[] args)
        //{
        //    object obj = null;

        //    string s = Console.ReadLine();

        //    if (int.TryParse(s, out int out_i))
        //        obj = out_i;
        //    else if (float.TryParse(s, out float out_f))
        //        obj = out_f;
        //    else
        //        obj = s;

        //    switch (obj)
        //    {
        //        case int i:
        //            Console.WriteLine($"{i}는 int 형식입니다.");
        //            break;
        //        case float f:
        //            Console.WriteLine($"{f}는 float 형식입니다.");
        //            break;
        //        default:
        //            Console.Write($"{obj}는 모르는 형식입니다.");
        //            break;
        //    }
        //}
    }
}
/* C#7.0 부터는 데이터 형식을 조건으로 비교 가능
 * 데이터 형식으로 사용할시 when 절을 이요하여 추가적인 조건 검사 가능하다.
 * 
 *  case float f when f >= 0:
 */
