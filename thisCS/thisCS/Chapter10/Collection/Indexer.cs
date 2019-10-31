using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter10.Collection
{
    class MyList
    {
        private int[] array;
        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }
    }
    class Indexer
    {
        //static void Main(string[] args)
        //{
        //    MyList list = new MyList();
        //    for (int i = 0; i < 5; i++)
        //        list[i] = i;

        //    for (int i = 0; i < list.Length; i++)
        //        Console.WriteLine(list[i]);
        //}
    }
}
/* 인덱서
 * 객체내의 데이터에 접근해주는 프로퍼티라고 생각.
 * 객체를 배열처럼 사용할 수 있게 해준다.
 * 예제는 내부에 배열을 가지고 있고, 인덱스를 통해 배열에 접근하는 내용.
 *      크기가 작으면 크기를 재조정한다.
 *      */
