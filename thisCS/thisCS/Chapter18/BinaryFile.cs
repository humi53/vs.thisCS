using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace thisCS.Chapter18
{
    class BinaryFile
    {
        //static void Main(string[] args)
        //{
        //    BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));

        //    bw.Write(int.MaxValue);
        //    bw.Write("Good Morning!");
        //    bw.Write(uint.MaxValue);
        //    bw.Write("안녕하세요!");
        //    bw.Write(double.MaxValue);

        //    bw.Close();

        //    BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));

        //    Console.WriteLine($"File size : {br.BaseStream.Length} bytes");
        //    Console.WriteLine($"{br.ReadInt32()}");
        //    Console.WriteLine($"{br.ReadString()}");
        //    Console.WriteLine($"{br.ReadUInt32()}");
        //    Console.WriteLine($"{br.ReadString()}");
        //    Console.WriteLine($"{br.ReadDouble()}");

        //    br.Close();
        //}
    }
}
/* 이진 데이터 처리를 위한 BinaryWriter/BinaryReader
 * byte형식 또는 byte배열형식으로 변환해야하는 불편함을 해소
 * 스트림에 이진데이터를 기록하기위한 목적으로, FileStream이나 NetworkStream과 함께 사용하면 파일기록,네트워크 전송을 할수 있다.
 * 문자열 앞에 문자열 길이를 기록한다. 가변길이로 1바이트가 넘게 필요할경우 가변으로 늘어난다.
 */