using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter06
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
    }
    class RefReturn
    {
        //static void Main(string[] args)
        //{
        //    Product carrot = new Product();

        //    ref int ref_local_price = ref carrot.GetPrice();
        //    int normal_local_price = carrot.GetPrice();

        //    carrot.PrintPrice();
        //    Console.WriteLine($"Ref Local Price : {ref_local_price}");
        //    Console.WriteLine($"Normal Local Price : {normal_local_price}");

        //    ref_local_price = 200;

        //    carrot.PrintPrice();
        //    Console.WriteLine($"Ref Local Price : {ref_local_price}");
        //    Console.WriteLine($"Normal Local Price : {normal_local_price}");
        //}
    }
}
/* 메소드의 결과를 참조로 반환하기
 * 참조반환값 ref return, 참조 지역변수 ref local
 */
