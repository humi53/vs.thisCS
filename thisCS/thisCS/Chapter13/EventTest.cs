using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter13
{
    delegate void EventHandler(string message);
    class MyNotifier
    {
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if(temp != 0 && temp %3 == 0)
            {
                SomethingHappened(String.Format("{0} : 짝", number));
            }
        }
    }
    class EventTest
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        //static void Main(string[] args)
        //{
        //    MyNotifier notifier = new MyNotifier();
        //    notifier.SomethingHappened += new EventHandler(MyHandler);
        //    for(int i=1; i < 30; i++)
        //    {
        //        notifier.DoSomething(i);
        //    }

        //    //notifier.SomethingHappened(3);  //외부에서 호출불가.
        //}
    }
}
/* 이벤트: 객체에 일어난 사건 알리기
 * 1. 대리자선언 클래스 밖에도 가능
 * 2. 클래스내에서 대리자의 인스턴스를 event한정자로 선언
 * 3. 이벤트 헨들러 작성. 1의 대리자와 일치하는 메소드면됨.
 * 4. 클래스 인스턴스를 생성 3에서 작성한 이벤트 핸들러를 등록.
 * 5. 이벤트가 발생하면 이벤트 헨들러가 호출됩니다.
 * 
 * 대리자와 이벤트
 * 대리자는 외부에서 직접 호출할수 있지만
 * 이벤트는 객체 외부에서 직접호출 할수 없습니다.
 */
