using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace thisCS.Chapter04
{
    class NullConditionalOperator
    {
        //static void Main(String[] args)
        //{
        //    ArrayList a = null;
        //    a?.Add("야구");
        //    a?.Add("축구");
        //    // a? 로 null이므로 결과가 나오지 않음.
        //    WriteLine($"Count : {a?.Count}");
        //    WriteLine($"{a?[0]}");
        //    WriteLine($"{a?[1]}");
        //    //WriteLine($"Count : {a.Count}");    // 그냥하려면 Exception 발생.

        //    a = new ArrayList();
        //    a?.Add("야구");
        //    a?.Add("축구");
        //    WriteLine($"Count : {a?.Count}");
        //    WriteLine($"{a?[0]}");
        //    WriteLine($"{a?[1]}");

        //}
    }
}
/* 널 조건부 연산자
 * C# 6.0부터 도입.
 * ?. 단일맴버  ?[]컬랙선 객체의 맴버접근
 * Null인지 확인한후 null 이면 null 반환 아니면 .뒤의 맴버를 반환.
 */
