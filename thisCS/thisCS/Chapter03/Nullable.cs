using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter03
{
    class Nullable
    {
        //static void Main(string[] args)
        //{
        //    int? a = null;
        //    Console.WriteLine(a.HasValue);  // 값을 가지고 있는지 가지고 있지 않은지 확인.
        //    Console.WriteLine(a != null);
        //    Console.WriteLine(a);           //없어도 그냥 넘어가짐.

        //    a = 3;

        //    Console.WriteLine(a.HasValue);
        //    Console.WriteLine(a != null);
        //    Console.WriteLine(a.Value);     // 값이 없으면 Exception 호출됨.
        //}
    }
}
/* Nullable 형식
 * 비어있을수 없는 값형식에 null을 저장할수 있게 만들어준다.
 * 
 * 사용시 HasValue를 사용하여 비어있는지 체크하거나
 *      Value를 호출하여 사용해야 동작시 버그를 방지한다.
 */
