using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter10.Collectionaa
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

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
        //IEnumerator 맴버
        public object Current
        {
            get
            {
                return array[position];
            }
        }
        //IEnumerator 맴버
        public bool MoveNext()
        {
            if(position == array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }
        //IEnumerator 맴버
        public void Reset()
        {
            position = -1;
        }

        //IEnumerable 맴버
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }

    }
    class Enumerable
    {
        //static void Main(string[] args)
        //{
        //    MyList list = new MyList();
        //    for (int i = 0; i < 5; i++)
        //        list[i] = i;

        //    foreach(int e in list)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}
    }
}
/* foreach각 가능한 객체 만들기
 * 메소드
 * IEnumerator GetEnumerator()      IEnumerator 형식의 객체를 반환.
 * 메소드 또는 프로퍼티
 * boolean MoveNext()           다음요소로 이동합니다. 컬렉션의 끝을 지난경우 false, 이동성공 true 반환.
 * void Reset()                 컬렉션의 첫 번째 위치의 "앞"으로 이동 0이 첫번째면 -1로 이동. 첫번째 위치로 이동은 MoveNext()를 호출한 다음에 이루어짐.
 * Object Current{get;}         컬렉션의 현재 요소를 반환합니다.
 * 
 * 특이사항 : 상속을 받지 않아도 메소드만 구현되있으면 실행됨. 
 *      다형성과의 관계가 있는게 맞나?
 * */
