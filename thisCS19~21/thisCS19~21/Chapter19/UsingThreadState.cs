using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thisCS19_21.Chapter19
{
    class UsingThreadState
    {
        private static void PrintThreadState(ThreadState state)
        {
            Console.WriteLine("{0,-16} : {1}", state, (int)state);
        }

        //static void Main(string[] args)
        //{
        //    PrintThreadState(ThreadState.Running);
        //    PrintThreadState(ThreadState.StopRequested);
        //    PrintThreadState(ThreadState.SuspendRequested);
        //    PrintThreadState(ThreadState.Background);
        //    PrintThreadState(ThreadState.Unstarted);
        //    PrintThreadState(ThreadState.Stopped);
        //    PrintThreadState(ThreadState.WaitSleepJoin);
        //    PrintThreadState(ThreadState.Suspended);
        //    PrintThreadState(ThreadState.AbortRequested);
        //    PrintThreadState(ThreadState.Aborted);
        //    PrintThreadState(ThreadState.Aborted | ThreadState.Stopped);
        //}
    }
}
/* 스레드의 일생과 상태 변화
 * Unstarted : 스레드 객체를 생성한 후 Start() 호출전 상태.
 * Running : 스레드 동작중인 상태 Start()를 통해 만들수 있다.
 * Suspended :  스레드 일시 중단 상태. Suspend() 를통해 만들수 있으며 Resume()메소드를 통해 Running으로 만들수 있다.
 * WaitSleepJoin : 스레드가 블록된 상태. Monitor.Enter(), Thread.Sleep(), Thread.Join() 메소드를 호출하면 이상태가 된다.
 *      Blocked - 사용하고자 하는 객체의 락이 풀릴 때까지 기다리는 상태.
 * Aborted : 스레드가 취소된 상태.Abort()를 호출하면 이상태가 되며 Aborted는 Stopped 상태로 전환되어 완전히 중지된다.
 * Stopped : 스래드가 중지된 상태. Abort()를 호출하거나 실행중인 메소드가 종료되면 이상태가 된다.
 * 
 * ThreadState는 Flags 애트리뷰트를 가지고 있다. Flags는 자신이 수식하는 열거형을 비트필드, 즉 플래그 집합으로 처리 할 수 있음을 나타낸다.
 * 그래서 한번에 여러 상태를 가지고 있을수 있다.
 * ThreadState 필드값을 확인하려면 이런식으로 구성.
 * (t1.ThreadState & ThreadState.Aborted == ThreadState.Aborted)
 */