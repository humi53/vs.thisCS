using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace WithPython
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            scope.SetVariable("n", "박상현");
            scope.SetVariable("p", "010-123-4566");

            ScriptSource source = engine.CreateScriptSourceFromString(@"
class NameCard :
    name = ''
    phone = ''

    def __init__(self, name, phone) :
        self.name = name
        self.phone = phone

    def printNameCard(self) :
        print self.name + ', ' + self.phone

NameCard(n, p)
");
            dynamic result = source.Execute(scope); //파이썬코드를 실행하여 결과 반환, NameCard객체가 생성되어 반환.
            result.printNameCard(); //객체의 메소드를 호출가능.

            Console.WriteLine("{0}, {1}", result.name, result.phone);   //객체의 필드를 접근가능.
        }
    }
}
/* 동적 언어와의 상호 운용성을 위한 dynamic 형식
 * C#은 CLR위에서 실행된다. 파이썬은 CLR - DLR(Dynamic Language Runtime) 위에서 실행된다.
 * 그래서 C#코드에서 파이썬이나 루비 코드를 실행하고 결과를 받아볼수 있다.
 * COM과 .NET의 상호 운용성 문제에 사용했던 dynamic을 CLR과 DLR 사이의 상호 운용성 문제를 해결하는데 사용할수 있다.
 * 미리 형식 검사를 할수없는 동적 형식 언어의 객체를 C#의 dynamic형식이 받아낼수 있기 때문.
 * 
 * 설치는 참조의 Nuget 패키지 관리에서 설치가능.
 * 
 * DLR이 제공해주는 클래스의 도움을 받아 동적언어를 호스팅 가능.
 * ScriptRuntime = 동적언어를 호스팅하는 시작점.ScrpitRuntime 클래스는 참조된 어셈블리나 전역객체같은 전역상태를 나타내며 .NET AppDomain 여러개의 인스턴스 만들수 있다.
 * ScriptScope = 기본적으로 네임스페이스를 나타냄, 호스트(C#)은 ScriptScope 객체안에 동적언어 코드의 변수 값을 대입하거나 읽을수 있다.
 * ScriptEngine = 언어 구문을 나타낸다. 스크립트 엔진은 코드를 실행하고 ScrpitScope와 ScriptSource를 생성하는 다양한 방법을 제공
 * ScriptSource = 이클래스는 소스 코드를 읽어들이는 여러 메소드와 읽어들인 소스코드를 다양한 방법으로 실행하는 메소드를 제공.
 * CompiledCode = 컴파일된 코드를 나타냄. 한번 컴파일하고 여러번 반복해서 실행하는 코드를 나타내는데 사용.
 * 
 * dynamic 형식은 ScriptRuntime를 이용해 소스파일에담긴 코드를 실행하든 ScrpitEngine,ScriptScope,ScriptSource를 이용하여 문자열에 담긴 코드를 실행하든 만들어진 객체를 그대로 받아낸다.
 * 이렇게 받아낸 객체는 C#코드에서 직접 메소드를 호출할수도 있고 필드에 접근하는것도 가능하다.
 */