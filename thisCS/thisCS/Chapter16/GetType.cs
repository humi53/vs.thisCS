using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace thisCS.Chapter16
{
    class GetType
    {
        static void PrintInterfaces(Type type)
        {
            Console.WriteLine("-------- Interfaces -------- ");
            Type[] interfaces = type.GetInterfaces();
            foreach (Type i in interfaces)
                Console.WriteLine("Name:{0}", i.Name);
            Console.WriteLine();
        }

        static void PrintField(Type type)
        {
            Console.WriteLine("-------- Fields -------- ");
            FieldInfo[] fields = type.GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.Instance);
            foreach(FieldInfo field in fields)
            {
                String accessLevel = "protected";
                if (field.IsPublic) accessLevel = "public";
                else if (field.IsPrivate) accessLevel = "private";

                Console.WriteLine("Access:{0}, Type:{1}, Name:{2}", accessLevel, field.FieldType.Name, field.Name);
            }
            Console.WriteLine();
        }
        static void PrintMethods(Type type)
        {
            Console.WriteLine("-------- Methods -------- ");
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.Write("Type:{0}, Name:{1}, Parameter:", method.ReflectedType.Name, method.Name);
                ParameterInfo[] args = method.GetParameters();
                for(int i=0; i<args.Length; i++)
                {
                    Console.Write("{0}", args[i].ParameterType.Name);
                    if (i < args.Length - 1)
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void PrintProperties(Type type)
        {
            Console.WriteLine("-------- Properties -------- ");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
                Console.WriteLine("Type:{0}, Name:{1}", property.PropertyType.Name, property.Name);
            Console.WriteLine();
        }
        //static void Main(string[] args)
        //{
        //    int a = 0;
        //    Type type = a.GetType();

        //    PrintInterfaces(type);
        //    PrintField(type);
        //    PrintProperties(type);
        //    PrintMethods(type);
        //}
    }
}
/* Object.GetType() 메소드와 Type 클래스
 * 리플렉션 : 객체의 Type 정보를 들여다보는 기능.
 *      이 기능을 이용하면 객체형식 이름부터 프로퍼티 목록, 메소드 목록, 필드, 이벤트목록까지 모두 열어볼수 있다.
 *      심지어 새로운 형식을 동적으로 만들수 있다.
 *      .NET 팀은 Object형식에 GetType() 메소드를 만들어 놨다.
 *      
 * Type형식의 자주쓰이는 메소드
 *      GetConstructors()       ConstructorInfo[]   모든 생성자 목록
 *      GetEvents()             EventInfo[]         이벤트 목록
 *      GetFiles()              FieldInfo[]         필드 목록
 *      GetGenericArguments()   Type[]              형식 매개 변수 목록
 *      GetInterfaces()         Type[]              상속하고있는 인터페이스 목록
 *      GetMembers()            MemberInfo[]        멤버 목록
 *      GetMethods()            MethodInfo[]        메소드 목록
 *      GetNestedTypes()        Type[]              내장 형식 목록
 *      GetProperties()         PropertyInfo[]      프로퍼티 목록
 * 추가 메소드는 MSDN에서 확인.
 * GetFields()나 GetMethods()는 검색 옵션 지정 가능 public, non public만 조회가능, 혹은 같이 조회가능, static 또는 인스터스 항목만 조회할수도 있다.
 * 아니면 모든 조건들을 포함하는 조건을 만들수도 있다. 검색옵션은 System.Reflection.BindingFlags 열거형을 이용해서 구성된다.
 * GetFields나 GetMethods등의 메소드는 BindingFlags 매개변수를 받지않는 버전으로도 오버로딩 되어있다. 이경우는 public 맴버만 반환.
 *      */