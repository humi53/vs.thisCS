using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter07
{
    class Myclass
    {
        public int Myfield1;
        public int MyFiled2;

        public Myclass DeepCopy()
        {
            Myclass newCopy = new Myclass();
            newCopy.Myfield1 = this.Myfield1;
            newCopy.MyFiled2 = this.MyFiled2;

            return newCopy;
        }
    }
    class DeepCopy
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Shallow Copy");

        //    {
        //        Myclass source = new Myclass();
        //        source.Myfield1 = 10;
        //        source.MyFiled2 = 20;

        //        Myclass target = source;
        //        target.MyFiled2 = 30;

        //        Console.WriteLine($"{source.Myfield1} {source.MyFiled2}");
        //        Console.WriteLine($"{target.Myfield1} {target.MyFiled2}");
        //    }

        //    Console.WriteLine("Deep Copy");
        //    {
        //        Myclass source = new Myclass();
        //        source.Myfield1 = 10;
        //        source.MyFiled2 = 20;

        //        Myclass target = source.DeepCopy();
        //        target.MyFiled2 = 30;

        //        Console.WriteLine($"{source.Myfield1} {source.MyFiled2}");
        //        Console.WriteLine($"{target.Myfield1} {target.MyFiled2}");
        //    }
        //}
    }
}
/* 객체 복사하기 : 얕은 복사와 깊은 복사
 * 깊은 복사를 위해 ICloneable이 준비되있음.
 * ICloneable.Clone() 메소드를 이용하여 구현
 */
