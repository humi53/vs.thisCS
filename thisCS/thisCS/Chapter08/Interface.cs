using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace thisCS.Chapter08
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력해주세요.: ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;
                logger.WriteLog("현재 온도 : " + temperature);
            }
        }
    }

    class Interface
    {
        //static void Main(string[] args)
        //{
        //    //ClimateMonitor moniter = new ClimateMonitor(new FileLogger("MyLog.txt"));
        //    //moniter.start();
        //    ClimateMonitor moniter2 = new ClimateMonitor(new ConsoleLogger());
        //    moniter2.start();
        //}
    }
}
/* 인터페이스는 약속이다
 */