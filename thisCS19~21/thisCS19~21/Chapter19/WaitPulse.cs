using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thisCS19_21.Chapter19b
{
    class Counter
    {
        const int LOOP_COUNT = 1000;

        readonly object thisLock;
        bool lockedCount = false;

        private int count;
        public int Count
        {
            get { return count; }
        }
        public Counter()
        {
            thisLock = new object();
            count = 0;
        }

        public void Increase()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    while (count > 0 || lockedCount == true)
                        Monitor.Wait(thisLock);

                    lockedCount = true;
                    count++;
                    lockedCount = false;

                    Monitor.Pulse(thisLock);
                }
            }
        }

        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    while (count < 0 || lockedCount == true)
                        Monitor.Wait(thisLock);

                    lockedCount = true;
                    count--;
                    lockedCount = false;

                    Monitor.Pulse(thisLock);
                }
            }
        }
    }
    class WaitPulse
    {
        //static void Main(string[] args)
        //{
        //    Counter counter = new Counter();

        //    Thread incThread = new Thread(new ThreadStart(counter.Increase));
        //    Thread decThread = new Thread(new ThreadStart(counter.Decrease));

        //    incThread.Start();
        //    decThread.Start();

        //    incThread.Join();
        //    decThread.Join();

        //    Console.WriteLine(counter.Count);
        //}
    }
}
/* 스레드 간의 동기화 : Monitor.Wait()와 Monitor.Pulse()로 하는 저수준 동기화
 * 해당 두 메소드는 lock 블록 안에서 호출해야한다. 그렇지 않으면 CLR이 SynchronizationLockException 예외를 던진다.
 * 
 * Ready Queue, Waiting Queue
 * Wait()메소드는 스레드를 WaitSleepJoin 상태로 만든다. WaitSleepJoin 상태로 들어간 스레드는 lock을 내려놓은뒤 Waiting Queue라는 큐에 입력되고 다른 스레드가 락을 얻어 작업을 수행한다.
 * 작업을 수행하던 스레드가 일을 마친 뒤 Pulse()를 호출하면 CLR은 Waiting Queue의 첫번째 스레드를 꺼내 Ready Queue에 입력시킨다.
 * Ready Queue에 입력된 스레드는 차례에 따라 락을 얻어 Running 상태에 들어간다.
 * 
 * Thread.Sleep() 메소드도 WaitSleepJoin 상태로 만들기는 하지만 Monitor.Pulse()메소드에 의해 깨어날수 없다.(Waiting Queue에 들어가지도 않는다.)
 * 다시 Running 상태로 돌아오려면 매개변수로 입력된 시간이 경과되거나 인터럽트 예외를 받아야 깨어난다.
 * 
 */
