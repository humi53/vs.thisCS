using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter10
{
    class DerivedFromArray
    {
        //static void Main(string[] args)
        //{
        //    int[] array = new int[] { 10, 30, 20, 7, 1 };
        //    Console.WriteLine($"Type of array : {array.GetType()}");
        //    Console.WriteLine($"Base type of array : {array.GetType().BaseType}");
        //}
    }
}
/* 알아두면 삶이 윤택해지는 System.Array
 * 자주 사용 하는 메소드
 *  정적 메소드
 *      Sort() : 정렬
 *      BinarySearch<T>() : 이진탐색
 *      IndexOf() : 찾는 데이터의 특정 인덱스 반환 (지정한 값)
 *      TrueForAll<T>() : 모든 요소가 지정조건에 부합하는지 여부 판단
 *      FindIndex<T>() : 조건에 부합하는 첫번째 요소의 인덱스 반환 (지정한 조건)
 *      Resize<T>() : 배열크기 재조정
 *      Clear() 모든 요소 초기화, 0,false, null
 *      ForEach<T>() : 모든요소에 동일한 작업 수행.
 *  인스턴스 메소드
 *      GetLength() : 지정한 차원의 길이를 반환. 다차원 배열에서 유용
 *  프로퍼티
 *      Length : 배열의 길이
 *      Rank : 배열의 차원
 *      
 *      */
