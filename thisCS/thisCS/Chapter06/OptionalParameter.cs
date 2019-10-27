using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter06
{
    class OptionalParameter
    {
        static void PrintProfile(string name, String phone = "none")
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        //static void Main(string[] args)
        //{
        //    PrintProfile("태연");
        //    PrintProfile("윤아", "010-123-1234");
        //    PrintProfile(name:"유리");
        //    PrintProfile(name: "서현", phone: "010-789-7890");
        //}
    }
}
/* 선택적 매개 변수
 * 오버로딩과 선택적 매개변수
 * 실행은 되지만 혼란을 야기할수 있으므로
 * 정책적으로 분명하게 정하는것이 필요.
 * */

