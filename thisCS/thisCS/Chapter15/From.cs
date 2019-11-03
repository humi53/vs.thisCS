using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thisCS.Chapter15
{
    class From
    {
        //static void Main(string[] args)
        //{
        //    int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };
        //    var result = from n in numbers
        //                 where n % 2 == 0
        //                 orderby n
        //                 select n;

        //    foreach (int n in result)
        //        Console.WriteLine($"짝수 : {n}");
        //}
    }
}
/* from
 * 모든 LINQ Query Expression 은 반드시 from 절로 시작한다.
 * 데이터 원본과 데이터 원본안에 들어있는 요소를 나타내는 '범위변수'를 지정해줘야 한다.
 * from의 데이터 원본의 형식은 IEnumerable<T> 인터페이스를 상속받는 형식이어야 한다.
 * 범위변수는 Query Variable라고도 하는데 foreach문을 생각하면 이해가 쉽다.
 * LINQ의 범위변수와 foreach의 반복변수의 차이점
 *      foreach는 데이터 원본으로부터 데이터를 담아내지만
 *      범위변수는 실제로 데이터를 담지는 않는다.
 *      그래서 쿼리식 외부에서 선언된 변수에 범위변수의 데이터를 복사해 넣는 액션은 불가능.
 *      범위변수는 질의가 실행될때 어떤일이 일어날지를 묘사하기 위해 도입된것이기때문에
 *      LINQ질의 안에서만 통용된다.
 *      */

