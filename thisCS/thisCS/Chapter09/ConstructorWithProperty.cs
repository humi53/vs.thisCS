using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter09b
{
    class BirthdayInfo
    {
        public string Name
        {
            get;
            set;
        }
        public DateTime Birthday
        {
            get;
            set;
        }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class ConstructorWithProperty
    {
        //static void Main(string[] args)
        //{
        //    BirthdayInfo birth = new BirthdayInfo()
        //    {
        //        Name = "서현",
        //        Birthday = new DateTime(1991, 6, 28)
        //    };
            
        //    Console.WriteLine($"Name : {birth.Name}");
        //    Console.WriteLine($"birthday : {birth.Birthday.ToShortDateString()}");
        //    Console.WriteLine($"Age : {birth.Age}");
        //}
    }
}
/* 프로퍼티와 생성자.
 * 객체를 생성할때 또다른 초기화 방법.
 * 프로퍼티를 이용한 초기화
 * 클래스 인스턴스 = new 클래스(){ 프로퍼티 = 값, 프로퍼티 = 값 };
 */

