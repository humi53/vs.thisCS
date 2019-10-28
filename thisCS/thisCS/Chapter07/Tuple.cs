using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter07
{
    class Tuple
    {
        //생략...
        //static void Main(string[] args)
        //{
        //    //명명되지 않은 튜플
        //    var a = ("슈퍼맨", 999);
        //    Console.WriteLine($"{a.Item1}, {a.Item2}");

        //    //명명된 튜플
        //    var b = (Name: "박상현", Age: 17);
        //    Console.WriteLine($"{b.Name}, {b.Age}");

        //    //분해
        //    var (name, age) = b;
        //    Console.WriteLine($"{name}, {age}");

        //    //명명된 튜플 = 명명되지 않은 튜플
        //    b = a;
        //    Console.WriteLine($"{b.Name}, {b.Age}");
        //}
    }
}
/* 튜플
 * 여러 필드를 담을 수 있는 구조체.
 * 
 * System.ValueTuple MSDN 참고
 * System.Value Type라는 추가 패키지가 필요합니다.
 * 2019버전 기준으로 추가설치 없이 실행.
 */