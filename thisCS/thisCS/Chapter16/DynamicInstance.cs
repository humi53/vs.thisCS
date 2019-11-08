using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace thisCS.Chapter16
{
    class Profile
    {
        private string name;
        private string phone;
        public Profile()
        {
            name = ""; phone = "";
        }
        public Profile(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
        public void Print()
        {
            Console.WriteLine($"{name}, {phone}");
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
    class DynamicInstance
    {
        //static void Main(string[] args)
        //{
        //    Type type = Type.GetType("thisCS.Chapter16.Profile");
        //    MethodInfo methodInfo = type.GetMethod("Print");
        //    PropertyInfo nameProperty = type.GetProperty("Name");
        //    PropertyInfo phoneProperty = type.GetProperty("Phone");

        //    object profile = Activator.CreateInstance(type, "박상현", "512-1234");
        //    methodInfo.Invoke(profile, null);   //null은 Print()메소드의 파라미터가 없기때문에 null로 처리.

        //    profile = Activator.CreateInstance(type);
        //    nameProperty.SetValue(profile, "박찬호");
        //    phoneProperty.SetValue(profile, "997-5511");
        //    Console.WriteLine("{0}, {1}", nameProperty.GetValue(profile), phoneProperty.GetValue(profile));

        //    //마지막 매개변수는 인덱서의 인덱스를 위해 사용된다. 하지만 예제에선 사용하지 않으므로 null입력.
        //    //그러나 인덱서 매개변수를 생략가능한 메소드들이 가능하다. msdn에서도 확인.
        //    //책의 예제 당시 버젼이 다른 부분인 것인지?
        //    //nameProperty.SetValue(profile, "박찬호", null);
        //    //phoneProperty.SetValue(profile, "997-5511",null);
        //    //Console.WriteLine("{0}, {1}", nameProperty.GetValue(profile,null), phoneProperty.GetValue(profile,null));

        //    // 추가테스트.
        //    // 의미가 있을지 모르겠지만 일반적으로 생성한 객체로 리플렉션 기능 사용가능.
        //    Profile profile1 = new Profile();
        //    nameProperty.SetValue(profile1, "박찬호");
        //    phoneProperty.SetValue(profile1, "997-5511");
        //    Console.WriteLine("{0}, {1}", nameProperty.GetValue(profile1), phoneProperty.GetValue(profile1));

        //    //dynamic을 이용하면 object로는 불가능 했던 호출이 가능하다.
        //    dynamic profile2 = Activator.CreateInstance(type);
        //    nameProperty.SetValue(profile2, "박찬호");
        //    phoneProperty.SetValue(profile2, "997-5511");
        //    Console.WriteLine("{0}, {1}", profile2.Name, profile2.Phone);

        //}
    }
}
/* 리플렉션을 이용해서 객체 생성하고 이용하기
 * 리플렉션을 이용하여 특정형식의 인스턴스를 생성하고
 *                      데이터를 할당하며,
 *                      메소드를 호출 하는 방법을 설명.
 * 코드안에서 런타임에 특정 형식의 인스턴스를 만들수 있게 되면 조금 더 프로그램이 동적으로 동작할 수 있게 구성할 수 있다.
 * 
 * System.Activator 클래스의 도움으로 리플렉션을 이용해 동적 생성.
 * object a= Activator.CreateInstance(typeof(int)); Type 객체를 매개변수로 넘기면 인스턴스를 생성
 * List<int> list = Activator.CraeteInstance<List<int>>(); 일반화를 지원하는 CreateInstance() 메소드도 있다.
 * 
 * 객체의 프로퍼티에 값을 할당하는것도 동적으로 가능
 * PropertyInfo객체의 SetValue() GetValue()를 호출하여 프로퍼티로부터 값을 읽고 할당가능.
 * 
 * 메소드 호출은 MethodInfo 객체의 Invoke로 호출 가능.
 * Invoke(동적객체, 메소드매개변수);
 * 
 * 리플렉션은 어디에 쓰나? : 인터넷에서 검색해봄.
 * 리플렉션을 이용하면 아래와 같은 경우 매우 편리하게 클래스를 초기화 할수 있습니다.
 * 만약, 인터넷에서 REST로 다운로드 되는 XML에서 하나의 정보를 구성하는 데이터가 수십개의 노드들로 구성이 되어있고 
 * 이에 해당하는 클래스를 멤버변수를 노드의 이름으로 설정을 해놓은 상황이있다고 했을때, 
 * Node들의 이름에 따라서 멤버변수을 설정해야 할 때는 일일이 지정하기가 힘듭니다. 이때 리플렉션을 이용하면 한줄로
 * 깔끔하게 처리가 됩니다.
        01.foreach (XmlNode nowItem in DataItems)
        02.{
        03.    tempStatus = new HongsClass();
        04.    foreach (XmlNode nowSubItem in nowItem)
        05.    {
        06.        tempStatus.GetType().GetProperty(nowSubItem.Name).SetValue(tempStatus, nowSubItem.InnerText, null);
        07.    }
        08. 
        09.    ReturnData.Add(tempStatus);
        10. 
        11.}
 * 위에서 우선 GetProperty로 해당 노드의 이름에 대한 프로퍼니가 어떤것인지를 가져왔으며, 두번째로 SetValue()라는 함수를 이용해서
 * tempStatus의 인스턴스에 해당멤버변수에 값을 nowSubItem.InnerText로 설정하는 내용입니다.
 * 출처: https://hongjinhyeon.tistory.com/86#rp [생각대로 살지 않으면 사는대로 생각한다.]
 */
