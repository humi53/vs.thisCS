using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter12
{
    class InvalidArgumentException : Exception
    {
        public InvalidArgumentException()
        {

        }
        public InvalidArgumentException(string message) : base(message)
        {

        }
        public object Argument
        {
            get;
            set;
        }
        public string Range
        {
            get;
            set;
        }
    }
    class MyException
    {
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint[] args = new uint[] { alpha, red, green, blue };
            foreach(uint arg in args)
            {
                if (arg > 255)
                    throw new InvalidArgumentException()
                    {
                        Argument = arg,
                        Range = "0~255"
                    };
            }
            return (alpha << 24 & 0xFF000000) |
                (red << 16 & 0x00FF0000) |
                (green << 8 & 0x0000FF00) |
                (blue & 0x000000FF);

        }
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Console.WriteLine("0x{0:X}", MergeARGB(255, 111, 111, 111));
        //        Console.WriteLine("0x{0:X}", MergeARGB(1, 65, 192, 128));
        //        Console.WriteLine("0x{0:X}", MergeARGB(0, 255, 255, 300));
        //    }
        //    catch (InvalidArgumentException e)
        //    {
        //        Console.WriteLine(e.Message);
        //        Console.WriteLine($"Argument:{e.Argument}, Range:{e.Range}");
        //    }
        //}
    }
}
/* 사용자 정의 예외 클래스 만들기
 */

