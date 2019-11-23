using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace thisCS.Chapter18
{
    class BasicIO
    {
        //static void Main(string[] args)
        //{
        //    long someValue = 0x123456789ABCDEF0;
        //    Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data", someValue);

        //    Stream outStream = new FileStream("a.dat", FileMode.Create);
        //    byte[] wBytes = BitConverter.GetBytes(someValue);

        //    Console.Write("{0,-13} : ", "Byte array");

        //    foreach (byte b in wBytes)
        //        Console.Write("{0:X2} ", b);
        //    Console.WriteLine();

        //    outStream.Write(wBytes, 0, wBytes.Length);
        //    outStream.Close();

        //    Stream inStream = new FileStream("a.dat", FileMode.Open);
        //    byte[] rbytes = new byte[8];

        //    int i = 0;
        //    while (inStream.Position < inStream.Length)
        //        rbytes[i++] = (byte)inStream.ReadByte();
        //    long readValue = BitConverter.ToInt64(rbytes, 0);

        //    Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);
        //    inStream.Close();
        //}
    }
}
/* 파일을 읽고 쓰기 위해 알아야 할 것들
 * 스트림을 통해 저장매체 <-> 메모리 사이의 데이터가 이동한다.
 * 스트림은 흐름이기 때문에 순차접근이 보통이다.
 * 스트림의 구조는 네트워크,데이터백업장치의 데이터 입/출력 구조와도 통하기 때문에 스트림을 이용하면 네트워크를 향해 데이터를 흘려보낼수 있다.
 * 하지만 하드디스크는 암과헤드가 존재하기 때문에 임의접근이 가능하다.
 * C#은 X86계열과 같은 리틀 엔디안 방식으로 동작.
 * Java는 빅 엔디안 방식을 채택.
 */
