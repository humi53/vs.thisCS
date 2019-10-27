using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter06
{
    class NamedParameter
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        //static void Main(string[] args)
        //{
        //    PrintProfile(name: "박찬호", phone: "010-123-1234");
        //    PrintProfile(phone: "010-123-1234", name: "박지성");
        //    PrintProfile("박세리", "010-123-1234");
        //    PrintProfile("박상현", phone: "010-123-1234");

        //}
    }
}
/* 명명된 매개변수
 * 호출시 순서로 하지 않고
 * 매개변수의 이름을 지정하고 할당.
 */
