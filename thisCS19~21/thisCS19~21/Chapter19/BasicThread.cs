using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thisCS19_21.Chapter19
{
    class BasicThread
    {
        static void DoSomthing()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);
            }
        }
        //static void Main(string[] args)
        //{
        //    Thread t1 = new Thread(new ThreadStart(DoSomthing));

        //    Console.WriteLine("Starting thread...");
        //    t1.Start();

        //    for(int i =0; i<5; i++)
        //    {
        //        Console.WriteLine($"Main : {i}");
        //        Thread.Sleep(10);
        //    }

        //    Console.WriteLine("Wating until thread stops ...");
        //    t1.Join();

        //    Console.WriteLine("Finished");
        //}
        
    }
}
/* 스레드 시작하기.
 * 장점
 * 사용자 대화형 프로그램에서 응답성을 높일수 있다.
 * 멀티프로세스방싱에 비해 자원공유가 쉽다.
 *      멀티프로세스는 소켓,공유메모리 같은 IPC를 이용해야하는데 스레드는 스레드 코드내의 변수를 같이 사용하는것으로 해결.
 * 프로세스를 띄우기위해 메모리와 자원을 할당하는 작업은 비용이 비싸다. 멀티스레드는 자원을 그대로 사용할수 있어서 비용을 지불하지 않아도 된다.
 * 단점
 * 구현하는데 어렵다. 테스트도 어렵다.
 * 멀티프로세스는 자식중 하나가 문제가 생겨도 영향이 확산되지 않지만
 * 멀티스레드는 자식중 하나에 문제가 생기면 전체 프로세스가 영향을 받게 된다.
 * 스레드를 너무 많이 사용하게 되면 오히려 성능이 저하된다.
 * 
 * 1. Thread의 인스턴스를 생성한다. 이 때 생성자의 매개변수로 스레드가 실행할 메소드를 매개 변수로 넘긴다.
 * 2. Thread.Start()메소드를 호출하여 스레드를 시작한다.
 * 3. Thread.Join() 메소드를 호출하여 스레드가 끝날때까지 기다린다.
 *
 */
