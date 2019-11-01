using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter12
{
    class StackTrace
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        int a = 1;
        //        Console.WriteLine(3 / --a);
        //    }catch(DivideByZeroException e)
        //    {
        //        Console.WriteLine(e.StackTrace);
        //    }
        //}
    }
}
/* 예외 처리 다시 생각해보기
 * 예외처리가 없다면 호출부분으로 출력전용매개변수나 리턴값으로 넘겨줘야 한다.
 * 예외처리를 사용함으로써 알고리즘과 예외처리부분을 깔끔하게 분리시킴으로 코드를 간결하게 만듬.
 * 예외의 StackTrace 프로퍼티를 통해 문제 발생한 코드의 위치를 알려주기때문에 디버깅에 용이하다.
 */
