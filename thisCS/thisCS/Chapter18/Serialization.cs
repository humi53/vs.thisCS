using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace thisCS.Chapter18
{
    [Serializable]
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;
    }
    class Serialization
    {
        //static void Main(string[] args)
        //{
        //    Stream ws = new FileStream("a.dat", FileMode.Create);
        //    BinaryFormatter serializer = new BinaryFormatter();

        //    NameCard nc = new NameCard();
        //    nc.Name = "박상현";
        //    nc.Phone = "010-123-4567";
        //    nc.Age = 33;

        //    serializer.Serialize(ws, nc);
        //    ws.Close();

        //    Stream rs = new FileStream("a.dat", FileMode.Open);
        //    BinaryFormatter deserializer = new BinaryFormatter();

        //    NameCard nc2;
        //    nc2 = (NameCard)deserializer.Deserialize(rs);
        //    rs.Close();

        //    Console.WriteLine($"Name : {nc2.Name}");
        //    Console.WriteLine($"Phone : {nc2.Phone}");
        //    Console.WriteLine($"Age : {nc2.Age}");
        //}
    }
}
/* 객체 직렬화하기
 * .NET에서는 이진형식으로의 직렬화를 지원한다. JSON, XML도 지원.
 * 클래스 선언부 앞에 [Serializable] 붙여주면 해당클래스는 메모리나 영구저장장치에 저장이 가능한 형식이 된다.
 * 특정 필드를 제외하려면 필드앞에 [NonSerialized]를 붙이면 된다.
 * 복합데이터 형식을 직렬화 할땐 직렬화하지 못하는 필드도  NonSerialized를 해야한다.
 * 아니면 해당 필드의 클래스에 Serializable를 붙여줘야 한다.
 */