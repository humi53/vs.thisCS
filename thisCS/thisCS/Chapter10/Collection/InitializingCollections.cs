using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace thisCS.Chapter10.Collection
{
    class InitializingCollections
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = { 123, 456, 789 };

        //    ArrayList list = new ArrayList(arr);
        //    foreach(object item in list)
        //        WriteLine($"ArrayList : {item}");
        //    WriteLine();

        //    Stack stack = new Stack(arr);
        //    foreach (object item in stack)
        //        WriteLine($"Stack : {item}");
        //    WriteLine();

        //    Queue queue = new Queue(arr) ;
        //    foreach (object item in queue)
        //        WriteLine($"Queue : {item}");
        //    WriteLine();

        //    ArrayList list2 = new ArrayList() { 11, 22, 33 };
        //    foreach (object item in list2)
        //        WriteLine($"ArrayList2 : {item}");
        //    WriteLine();

        //}
    }
}
/* 컬렉션을 초기화하는 방법
 * ArrayList는 컬렉션 초기자를 이용해 초기화 가능. { 11, 22, 33 }
 * Stack, Queue는 불가능. 배열을 만들어서 초기화 가능. new Stack(arr);
 */

