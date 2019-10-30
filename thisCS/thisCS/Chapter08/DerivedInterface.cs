using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter08a
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    interface IFormattableLogger: ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
        public void WriteLog(string format, params Object[] args)
        {
            String message = String.Format(format, args);
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    class DerivedInterface
    {
        //static void Main(string[] args)
        //{
        //    IFormattableLogger logger = new ConsoleLogger2();
        //    logger.WriteLog("The world is not flat");
        //    logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        //}
    }
}
/* 인터페이스를 상속하는 인터페이스
 * 
 * 상속하려는 인터페이스가 어셈블리로만 제공되는 경우.
 * 상속하려는 인터페이스의 소스를 갖고 있어도 이미 인터페이스를 상속하는 클래스가 존재하는 경우.
 */