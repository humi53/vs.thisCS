using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter16
{
    class MyClass
    {
        [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]
        public void OldMethod()
        {
            Console.WriteLine("I'm old");
        }
        public void NewMethod()
        {
            Console.WriteLine("I'm new");
        }
    }
    class BasicAttribute
    {
        //static void Main(string[] args)
        //{
        //    MyClass obj = new MyClass();
        //    obj.OldMethod();
        //    obj.NewMethod();
        //}
    }
}
/* 애트리뷰트 사용하기
 * 사람이 작성하고 컴퓨터가 읽는 주석?.
 * 클래스나 구조체, 메소드, 프로퍼티 등에 데이터를 기록해두면
 * C#컴파일러나 C#으로 작성된 프로그램이 이정보를 읽어 사용할수 있다.
 */
