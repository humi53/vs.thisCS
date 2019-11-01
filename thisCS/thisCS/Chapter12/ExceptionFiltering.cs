using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter12
{
    class FilterableException : Exception
    {
        public int ErrorNo { get; set; }
    }
    class ExceptionFiltering
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter Number Between 0~10");
        //    string input = Console.ReadLine();
        //    try
        //    {
        //        int num = Int32.Parse(input);
        //        if (num < 0 || num > 10)
        //            throw new FilterableException() { ErrorNo = num };
        //        else
        //            Console.WriteLine($"Output : {num}");
        //    }catch(FilterableException e) when(e.ErrorNo < 0)
        //    {
        //        Console.WriteLine("Nagative input is not allowed.");
        //    }catch(FilterableException e) when(e.ErrorNo > 10)
        //    {
        //        Console.WriteLine("Too big number is not allowed.");
        //    }
        //}
    }
}
/* 예외 필터하기
 * C#6.0부터 when 키워드를 이요하여 제약조건을 기술.
 */
