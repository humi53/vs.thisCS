using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thisCS19_21.Chapter19a
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
                Console.WriteLine("Running thread isn't gonna be interrupted");
                Thread.SpinWait(1000000000);

                while(count > 0)
                {
                    Console.WriteLine($"{count--} left");

                    Console.WriteLine("Entering into WaitJoinSleep State...");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count : 0");
            }
            catch(ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }
    }
    class InterruptingThread
    {
        //static void Main(string[] args)
        //{
        //    SideTask task = new SideTask(100);
        //    Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
        //    t1.IsBackground = false;

        //    Console.WriteLine("Starting thread...");
        //    t1.Start();

        //    Thread.Sleep(100);

        //    Console.WriteLine("Interrupting thread...");
        //    t1.Interrupt();

        //    Console.WriteLine("Wating until thread stops...");
        //    t1.Join();

        //    Console.WriteLine("Finished");
        //}
    }
}
/* 스레드를 임의로 멈추는 또 하나의 방법 : 인터럽트
 * Abort()와 비슷하지만 Running 상태를 피해서 WaitJoinSleep상태에 들어갔을때 ThreadInterruptedException을 던져 스레드를 중지시킨다.
 * 이때문에 절대로 중단되면 안되는 작업을 하고있을때는 중단되지 않는다는 보장을 받을수 있다.
 */