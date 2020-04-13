using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace thisCS19_21.Chapter19
{
    class UsingTask
    {
        //static void Main(string[] args)
        //{
        //    string srcFile = args[0];

        //    Action<object> FileCopyAction = (object state) =>
        //    {
        //        String[] paths = (String[])state;
        //        File.Copy(paths[0], paths[1]);

        //        Console.WriteLine("TaskID:{0}, ThreadID:{1}, {2} was copied to {3}", Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);
        //    };

        //    Task t1 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });

        //    Task t2 = Task.Run(() =>
        //    {
        //        FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
        //    });

        //    t1.Start();

        //    Task t3 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy3" });

        //    t3.RunSynchronously();

        //    t1.Wait();
        //    t2.Wait();
        //    t3.Wait();
        //}
    }
}
/* System.Threading.Tasks.Task 클래스
 */
 /*
  * 병렬처리 : 하나의 작업을 여러 작업자가 나눠서 수행한 뒤 다시 하나의 결과로 만드는것.
  * 비동기 처리 : A를 시작한후 A의 결과가 나오기를 기다리는것이 아닌 곧이어 B,C,D,... 를 수행하다 작업A가 끝나면 그때 결과를 받아내는 처리 방식.
  */