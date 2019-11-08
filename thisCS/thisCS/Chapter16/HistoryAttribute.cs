using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter16
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    class History : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First release";
        }
        public string GetProgrammer()
        {
            return programmer;
        }
    }
    [History("Sean", version = 0.1, changes = "2017-11-01 Created class stub")]
    [History("Bob", version = 0.2, changes = "2017-12-03 Added Func() Method")]
    class Myclass
    {
        public void Func()
        {
            Console.WriteLine("Func()");
        }
    }

    class HistoryAttribute
    {
        //static void Main(string[] args)
        //{
        //    Type type = typeof(Myclass);
        //    Attribute[] attributes = Attribute.GetCustomAttributes(type);

        //    Console.WriteLine("MyClass change history...");

        //    foreach(Attribute a in attributes)
        //    {
        //        History h = a as History;
        //        if (h != null)
        //            Console.WriteLine("Ver{0}, Programmer:{1}, Changes:{2}", h.version, h.GetProgrammer(), h.changes);
        //    }
        //}
    }
}
/* 내가 만드는 애트리뷰트
 * .NET 프레임워크가 제공하는 애트리뷰트는 Obsolete 말고도 종류가 많다.
 * C/C++로 작성된 DLL에 있는 함수를 호출할때 쓰는 [DLLImport], 조건부 메소드 실행을 지정할때 사용하는 [Conditional] 등이 그예입니다.
 * 애트리뷰트 자체를 공부하기보다 용도를 중심으로 공부하는편이 좋다. 애트리뷰트는 부가정보이지 핵심내용이 아닌데다 사용방법도 그 수많큼 다양.
 * 그래서 책의 저자는 애트리 뷰트를 일일이 알아보는 대신, 애트리뷰트를 직접 만들어보고 활용함으로써 다른 애트리뷰트를 활용할때 필요한 내용을 나누기원함.
 * 애트리뷰트도 하나의 클래스 System.Attribute 클래스로부터 상속.
 * System.AttributeUsage라는 애트리뷰트는 애트리뷰트의 애트리뷰트입니다.
 * All          이표의 나머지 모든 요소
 * Assembly     어셈블리
 * Module       모듈
 * Interfate    인터페이스
 * Class        클래스
 * Struct       구조체
 * ClassMembers 클래스 안에 선언된 클래스나 구조체를 포함한 클래스의 모든 맴버
 * Constructor  생성자
 * Delegate     대리자
 * Enum         열거형
 * Field        필드
 * Property     프로퍼티
 * Method       메소드
 * Parameter    메소드의 매개변수
 * ReturnValue  메소드의 반환 값
 * Attribute Target은 논리합 연산자를 이용해서 결합할수 있다.
 * AllowMeltiple, 이부분이 History애트리뷰트를 여러번 사용할수 있게 된다.
 */
