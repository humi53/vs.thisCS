using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter14
{
    class FriendList
    {
        private List<string> list = new List<string>();
        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }
        public FriendList() => Console.WriteLine("FriendList()");
        ~FriendList() => Console.WriteLine("~FriendList()");
        //public int Capacity => list.Capacity;   //읽기전용
        public int Capacity //속성
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }
        //public string this[int index] => list[index];   //읽기전용
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }
    class ExpressionBodiedMember
    {
        //static void Main(string[] args)
        //{
        //    FriendList obj = new FriendList();
        //    obj.Add("Eeny");
        //    obj.Add("Meeny");
        //    obj.Add("Miny");
        //    obj.Remove("Eeny");
        //    obj.PrintAll();

        //    Console.WriteLine($"{obj.Capacity}");
        //    obj.Capacity = 10;
        //    Console.WriteLine($"{obj.Capacity}");

        //    Console.WriteLine($"{obj[0]}");
        //    obj[0] = "Moe";
        //    obj.PrintAll();
        //}
    }
}
/* 식으로 이루어지는 멤버
 * 메소드를 비롯하여 속성(인덱서), 생성자, 종료자는 공통된 특징이 있다.
 * 모두 클래스의 맴버로 중괄호{}로 이루어져 있다.
 * 이러한 맴버의 본문을 식Expression만으로 구현하는 것이 가능하다.
 * 이렇게 식으로 구현된 맴버를 영어로는 "Expression-Bodied Member"라 하고,
 * 우리말로는 "식 본문 맴버"라고 한다
 * 메소드, 인덱서, 생성자, 종료자, 속성, 읽기전용 인덱서, 읽기전용 속성 가능.
 * 쓰기전용 속성은 불가능.
 * */