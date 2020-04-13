using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thisCS19_21.Chapter19
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
                lock (thisLock)
                {
                    count++;
                }
            Thread.Sleep(1);
            }
        }

        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while(loopCount-- > 0)
            {
                lock (thisLock)
                {
                    count--;
                }
                Thread.Sleep(1);
            }
        }
    }
    class Synchronize
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
/* 스레드 간의 동기화 : lock 키워드로 동기화 하기
 * 크리티컬 섹션. 커널객체를 사용하지 않으므로 가볍고 빠르다. 서로 다른 프로세스간에 접근이 불가하다. 한프로세스 내의 쓰레드 사이에서만 동기화 가능.
 *      뮤텍스는. 커널 객체를 사용. 크리티컬 섹션보다 무겁다. 뮤텍스는 여러 프로세스의 스레드 사이에서 동기화 가능하다. 가장흔한 예가 프로세스 다중 실행을 막을때.
 *      세마포어. 커널 객체. 크리티컬섹션, 뮤텍스는 하나의 쓰레드만 실행. 세마포어는 지정된 수만큼의 쓰레드가 동시에 실행 되도록 동기화 하는것이 가능.
 *
 * 구문이해 예시
 * 각스레드는 목수
 * 스레드들이 실행하는 코드는 목수들이 일하는 작업실
 * lock 키워드의 매개변수는 망치.
 * 목수가 망치를 가지고 작업실에 들어가듯이... 스레드는 lock을 얻어야 크리티컬 섹션을 생성한다. (다른스레드가 망치를 쓰고 있으면 작업불가.) (대기상태 돌입)
 *          * 확인이 더 필요한 부분인것 같음.
 * 
 * 매개변수로 쓰이면 곤란한 객체
 * this , * Type 형식  * string 형식
 */
