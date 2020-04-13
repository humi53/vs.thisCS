using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thisCS19_21.Chapter19
{
    class SideTask
    {
        int count;
        public SideTask(int count)
        {
            this.count = count;
        }
        public void KeepAlive()
        {
            try
            {

                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count : 0");
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine(e);
                Thread.ResetAbort();
            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }
    }
    class AbortingThread
    {
        //static void Main(string[] args)
        //{
        //    SideTask task = new SideTask(100);
        //    Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
        //    t1.IsBackground = false;

        //    Console.WriteLine("Starting thread...");
        //    t1.Start();

        //    Thread.Sleep(100);

        //    Console.WriteLine("Aborting thread...");
        //    t1.Abort();

        //    Console.WriteLine("Wating until thread stops...");
        //    t1.Join();

        //    Console.WriteLine("Finished");
        //}
    }
}
/* 스레드 임의로 종료시키기
 * Abort(); 메소드로 종료.
 * 종료 될때는 호출즉시 종료된다는 보장이 없다.
 * Abort()가 호출되면 CLR은 해당 스레드가 실행중이던 코드에 ThreadAbortException을 호출한다.
 * 예외처리 -> finally처리 후 해당 스레드는 완전 종료된다. 그래서 이 처리시간을 반드시 염두에 둬야 한다.
 * 
 * Thread.Abort()를 사용하지 않는것이 좋다.
 *      한스레드가 동기화를 위해 자원을 독점, 잠근후 해재하지 않고 Abort로 죽어버린다면? 다른스레드들은 그대로 꼼짝못한다.
 *      그래서 Abort()를 goto문을 사용하는만큼 금기시 한다.
 *      Abort()를 호출하는 대신 반복문 매회 반복할때마다 계속 수행확인할 변수를 다른 스레드들과 공유하고 외부에서 변경하는것이 낫다.
 */