using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter09
{
    interface INameValue
    {
        string Name
        {
            get;
            set;
        }
        string Value
        {
            get;
            set;
        }
    }
    class NamedValue : INameValue
    {
        public string Name
        {
            get;
            set;
        }
        public string Value
        {
            get;
            set;
        }
    }
    class PropertiesInInterface
    {
        //static void Main(string[] args)
        //{
        //    NamedValue name = new NamedValue()
        //    {
        //        Name = "이름",
        //        Value = "박상현"
        //    };
        //    NamedValue height = new NamedValue()
        //    {
        //        Name = "키",
        //        Value = "177Cm"
        //    };
        //    NamedValue weight = new NamedValue()
        //    {
        //        Name = "몸무게",
        //        Value = "90Kg"
        //    };
        //    Console.WriteLine($"{name.Name} : {name.Value}");
        //    Console.WriteLine($"{height.Name} : {height.Value}");
        //    Console.WriteLine($"{weight.Name} : {weight.Value}");
        //}
    }
}
/* 인터페이스의 프로퍼티
 * 파생클래스는 인터페이스의 모든 프로퍼티를 구현해야합니다.
 */
