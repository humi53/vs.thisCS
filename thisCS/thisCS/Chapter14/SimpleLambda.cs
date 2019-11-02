using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter14
{
    class SimpleLambda
    {
        delegate int Calculate(int a, int b);
        //static void Main(string[] args)
        //{
        //    Calculate calc = (a, b) => a + b;
        //    Console.WriteLine($"{3} + {4} : {calc(3, 4)}");
        //}
    }
}
/* 처음 만나는 람다식
 * 매개_변수_목록 => 식
 * (int a, int b) => a + b;
 * C# 컴파일러는 형식 유추 type Inference를 제공 더 간단하게 표현 가능.
 * (a, b) => a + b;
 * 대리자는 C# 2.0에서 도입
 * 람다식은 C# 3.0에서 도입
 * 그래서 두가지 방법 둘다 제공.
 */