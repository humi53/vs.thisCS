using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter14
{
    class StatementLambda
    {
        delegate string Concatenate(string[] args);
        //static void Main(string[] args)
        //{
        //    Concatenate concat =
        //        (arr) =>
        //        {
        //            string result = "";
        //            foreach (string s in arr)
        //                result += s;
        //            return result;
        //        };
        //    Console.WriteLine(concat(args));
        //}
    }
}
/* 문 형식의 람다식
 * (매개_변수_목록) =>
 * {
 *      문장1;
 *      문장2;
 *      문장3;
 *      ...
 * }
 * 식 형식의 람다식은 반환형식이 없는 무명함수를 만들수 없음, 
 * (식 형식은 반환이 무조건 있어야된다.)
 * 하지만 문 형식의 람다식을 이용하면 반환이 가능하다.
 * 
 */