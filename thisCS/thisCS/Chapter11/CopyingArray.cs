using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter11
{
    class CopyingArray
    {
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }

        //static void Main(string[] args)
        //{
        //    int[] source = { 1, 2, 3, 4, 5 };
        //    int[] target = new int[source.Length];

        //    CopyArray<int>(source, target);

        //    foreach (int element in target)
        //        Console.WriteLine(element);

        //    string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
        //    string[] target2 = new string[source2.Length];

        //    CopyArray<string>(source2, target2);

        //    foreach (string element in target2)
        //        Console.WriteLine(element);
        //}
    }
}
/* 일반화 메소드
 * 타입이 다를경우 오버로딩하지않고 모든 형식을 지원가능.
 */

