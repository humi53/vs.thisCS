using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace thisCS.Chapter16
{
    public static class Trace
    {
        public static void WriteLine(string message, [CallerFilePath] string file = "",
            [CallerLineNumber] int line =0, [CallerMemberName] string member = "")
        {
            Console.WriteLine($"{file}(Line:{line}) {member}: {message}");
        }
    }
    class CallerInfo
    {
        //static void Main(string[] args)
        //{
        //    Trace.WriteLine("즐거운 프로그래밍!");
        //}
    }
}
/* 호출자 정보 애트리뷰트
 * C/C++에서 제공하는 __FILENAME__, __LINE__, __FUNCTION__ 메크로에 해당하는 기능을 C#에선 제공하지 않았었음.
 * C# 5.0 버전부터는 호출자정보 Caller Information는 애트리뷰타가 도입되어서 해당기능을 사용할수 있다.
 * CallerMemberNameAttribute : 메소드 또는 프로퍼티 이름
 * CallerFilePathAttribute : 소스파일 경로. 소스코드를 컴파일 할때의 전체경로.
 * CallerLineNumberAttribute : 호출된 소스파일 내의 행 번호를 나타낸다.
 * 매개변수 부분에 추가하면  프로그래머가 별도로 입력하지 않아도 자동으로 정보가 넘어옴.
 * 
 */
