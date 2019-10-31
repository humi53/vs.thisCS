using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter10.Collection
{
    class UsingList
    {
        //static void Main(string[] args)
        //{
        //    ArrayList list = new ArrayList();
        //    for (int i = 0; i < 5; i++)
        //        list.Add(i);

        //    foreach (object obj in list)
        //        Console.Write($"{obj} ");
        //    Console.WriteLine();

        //    list.RemoveAt(2);

        //    foreach (object obj in list)
        //        Console.Write($"{obj} ");
        //    Console.WriteLine();

        //    list.Insert(2, 2);

        //    foreach (object obj in list)
        //        Console.Write($"{obj} ");
        //    Console.WriteLine();

        //    list.Add("abc");
        //    list.Add("def");

        //    for (int i = 0; i < list.Count; i++)
        //        Console.Write($"{list[i]} ");
        //    Console.WriteLine();

        //}
    }
}
/* ArrayList
 * 용량 미리 지정없이 자동으로 늘어나거나 줄어든다.
 * Add(), RemoveAt(), Insert()
 * 
 * 매개변수가 object형식으로 사용하므로 모든 형식을 지원
 * 하지만 박싱 언박싱의 오버헤드로 데이터가 많아질수록 성능저하가 일어남
 * Stack, Queue, Hashtable 등도 같이 있음
 * 해결법은 Generic Collection 일반화 컬랙션으로 해결.
 */

