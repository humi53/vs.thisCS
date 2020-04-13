using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace thisCS19_21.Chapter19a
{
    class Counter
    {
        const int LOOP_COUNT = 1000;

        readonly object thisLock;

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
            while(loopCount-- > 0)
            {
                Monitor.Enter(thisLock);
                try
                {
                    count++;
                }
                finally
                {
                    Monitor.Exit(thisLock);
                }
                Thread.Sleep(1);
            }
        }
        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                Monitor.Enter(thisLock);
                try
                {
                    count--;
                }
                finally
                {
                    Monitor.Exit(thisLock);
                }
                Thread.Sleep(1);
            }
        }
    }
    class UsingMonitor
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
/* 스레드 간의 동기화 : Moniter 클래스로 동기화하기
 * Monitor.Enter() : 크리티컬 센션을 만든다. 
 * Monitor.Exit() : 크리티컬 섹션을 제거
 * 
 * lock 키워드는 Monitor 클래스의 Enter()와 Exit()를 바탕으로 구현되있다.
 * 이둘을 사용하여 동기화 하기보단 lock 키워드를 사용하는 편이 좋다.
 */