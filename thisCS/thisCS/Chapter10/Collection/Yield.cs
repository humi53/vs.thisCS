using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter10.Collection
{
    class MyEnumerator
    {
        int[] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
            yield return numbers[3];
        }
    }
    class Yield
    {
        //static void Main(string[] args)
        //{
        //    var obj = new MyEnumerator();
        //    foreach (int i in obj)
        //        Console.WriteLine(i);
        //}
    }
}
/* foreach가 가능한 객체 만들기
 *      foreach문은 배열이나 리스트 같은 컬랙션만 사용가능.
 *      foreach문은 IEnumerator를 상속하는 형식만 지원한다.
 *      그래서 일반클래스도 IEnumerable과 IEnumerator를 상곡하시만 하면 순회가능.
 * yield를 이용한 예제
 * GetEnumerator()메소드를 구현
 * yield return 문은 현재 메소드(GetEnumerator())의 실행을 일시 정지 시켜놓고 호출자에게 결과 반환
 * 메소드가 다시 호출되면  yield를 만날때까지 실행.
 */
