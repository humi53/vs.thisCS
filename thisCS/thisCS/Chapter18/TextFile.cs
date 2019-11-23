using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace thisCS.Chapter18
{
    class TextFile
    {
        //static void Main(string[] args)
        //{
        //    StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create));

        //    sw.WriteLine(int.MaxValue);
        //    sw.WriteLine("Good morning");
        //    sw.WriteLine(uint.MaxValue);
        //    sw.WriteLine("안녕하세요!");
        //    sw.WriteLine(double.MaxValue);

        //    sw.Close();

        //    StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));

        //    Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");

        //    while(sr.EndOfStream == false)
        //    {
        //        Console.WriteLine(sr.ReadLine());
        //    }
        //    sr.Close();
        //}
    }
}
/* 텍스트 파일 처리를 위한 StreamWriter/StreamReader
 * ASCII 인코딩에서는 각 바이트가 문자 하나를 나타내기 때문에 바이트 오더의 문제에서 벗어날수 있고,
 * 이로 인해 플랫폼에 관계없이 생성하고 읽을수 있다. 편집기로 열면 사람도 읽을수 있다.
 */