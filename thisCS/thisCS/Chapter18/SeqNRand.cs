using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace thisCS.Chapter18
{
    class SeqNRand
    {
        //static void Main(string[] args)
        //{
        //    Stream outStream = new FileStream("a.dat", FileMode.Create);
        //    Console.WriteLine($"Position : {outStream.Position}");

        //    outStream.WriteByte(0x01);
        //    Console.WriteLine($"Position : {outStream.Position}");

        //    outStream.WriteByte(0x02);
        //    Console.WriteLine($"Position : {outStream.Position}");

        //    outStream.WriteByte(0x03);
        //    Console.WriteLine($"Position : {outStream.Position}");

        //    outStream.Seek(5, SeekOrigin.Current);
        //    Console.WriteLine($"Position : {outStream.Position}");

        //    outStream.WriteByte(0x04);
        //    Console.WriteLine($"Position : {outStream.Position}");

        //    outStream.Close();

        //    Stream inStream = new FileStream("a.dat", FileMode.Open);
        //    int[] rb = new int[2];
        //    inStream.Seek(1, SeekOrigin.Current);
        //    for(int i=0; i<rb.Length; i++)
        //        rb[i] = inStream.ReadByte();

        //    for (int i = 0; i < rb.Length; i++)
        //        Console.Write(rb[i] + " ");
        //    inStream.Close();
        //}
    }
}
/* 파일을 읽고 쓰기 위해 알아야 할 것들
 * 임의접근 예제.
 */
