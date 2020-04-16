using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter03
{
    class exam1
    {
        //static void Main(string[] args) {
        //    //int a = 7.3;    //소수를 정수변수에 넣으려고 함.
        //    //float b = 3.14; // 소수의 기본형은 double. double을 float에 넣으려고함.
        //    //double c = a * b;   //float 과 double 사이의 형변환은 10진수 -> 2진수 -> 10진수 과정으로 인해 표현하지 못하는 소수로 인해 데이터가 늘어진다.
        //    //char d = "abc";     // char에 문자열을 넣으려고함. 외따옴표를 이용 한 문자만 사용가능.
        //    //string e = '한';     //''외따옴표는 문자를 표현할때 사용 문자열은 ""쌍따옴표를 사용해야함.

        //    int a = 7;
        //    float b = 3.14f;
        //    double c = a * b;   // 해결책 3.14에 해당되는 데이터에 100을 곱하고 변환시키고 다시 100을 나누는 식으로 우회가능.(소수점 갯수만큼으로 처리)
        //                        // 하지만 제일 간단한것은 float을 쓰지않고 double을 써서 문제를 피하면된다.
        //    char d = 'a';
        //    string e = "한";
        //}
    }

    //exam2 값형식과 참조형식의 차이.
        // 값형식은 스택에 저장.
        // 참조형식은 힙에 저장.
    //exam3 박싱과 언박싱을 설명하시오.
        // 박싱은 참조형식으로 사용된다.
        // object형식에 값을 저장하는것이 박싱.
        // object 형식의 값을 꺼내는것이 언박싱. 값을꺼낼땐 타입을 알수 없으므로 형변환을 해줘야 한다.
    class exam4
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("사각형의 너비를 입력하세요.");
        //    string width = Console.ReadLine();
        //    Console.WriteLine("사각형의 높이를 입력하세요.");
        //    string height = Console.ReadLine();

        //    //이곳에 사각형의 넓이를 계산하고 출력하는 루틴을 추가하세요.
        //    Console.WriteLine("사각형의 넓이는 : " + int.Parse(width) * int.Parse(height));
        //}
    }
    //exam5  a,b의 데이터형식 맞추기
    // var a = 2020; int
    // var b = "double"; string
}
