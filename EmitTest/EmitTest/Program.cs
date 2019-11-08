using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;

namespace EmitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyBuilder newAssembly =
                AppDomain.CurrentDomain.DefineDynamicAssembly(
                    new AssemblyName("CalculatorAssembly"),
                    AssemblyBuilderAccess.Run);     //어셈블리 생성.
            //CurrentDomain 프로퍼티는 현재 코드가 실행되고 있는 AppDomain을 반환합니다.


            ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");    //모듈 생성.
            TypeBuilder newType = newModule.DefineType("Sum1To100");    //클래스 생성.

            MethodBuilder newMethod = newType.DefineMethod(
                "Calculate",
                MethodAttributes.Public,
                typeof(int),    //반환형식
                new Type[0]);   //매개변수
            //메소드 생성.

            ILGenerator generator = newMethod.GetILGenerator();

            // Calculate메소드에 IL명령어를 채워넣기.
            generator.Emit(OpCodes.Ldc_I4, 1);  //32비트 정수1을 계산스택에 넣습니다.

            for(int i=2;i<=100; i++)
            {
                generator.Emit(OpCodes.Ldc_I4, i);  //32비트 정수(i)를 계산스택에 넣습니다.
                generator.Emit(OpCodes.Add);    // 계산후 계산 스택에 담겨있는 두개의 값을 꺼내서 더한후, 그 결과를 다시 계산 스택에 넣습니다.
            }

            generator.Emit(OpCodes.Ret);    // 계산 스택에 담겨 있는 값을 반환합니다.
            newType.CreateType();   //sum1To100 클래스를 CLR에 제출.

            //동적형식으로 생성해서 사용.
            object sum1To100 = Activator.CreateInstance(newType);
            MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculate");
            Console.WriteLine(Calculate.Invoke(sum1To100, null));
        }
    }
}
/* 16장 리플렉션과 애트리뷰트
 * 형식 내보내기
 * 프로그램 실행중에 새로운 형식을 만들어 낼 수 있는 기능도 제공.
 * 동적으로 새로운 형식을 만드는 작업은 System.Reflection.Emit 네임스페이스에 있는 클래스들을 통해 이루어짐.
 * Emit은 프로그램이 실행중에 만들어 낸 새 형식을 CLR의 메모리에 내보낸다는 의미로 생각하면 이해하는데 도움이 된다.
 * Emit네임스페이스의 클래스들 확인 : https://docs.microsoft.com/ko-kr/dotnet/api/system.reflection.emit?view=netframework-4.8
 * 
 * 클래스를 사용하는 요령은 다음순서와 같다.
 * 1. AssemblyBuilder를 이용해서 어셈블리를 만듭니다.
 * 2. ModuleBuilder를 이용해서 1에서 생성한 어셈블리 안에 모듈을 만들어 넣습니다.
 * 3. TypeBuilder를 2에서 생성한 모듈 안에 클래스(형식)를 만들어 넣습니다.
 * 4. 3에서 생성한 클래스 안에 메소드(MethodBuilder 이용)나 프로퍼티(PropertyBuilder 이용)를 만들어 넣습니다.
 * 5. 4에서 생성한것이 메소드라면, ILGenerator를 이용해서 메소드 안에 CPU가 실행할 IL 명령들을 넣습니다.
 * 
 * .NET프로그램을 실행하면 메모리에 프로세스가 생성되고 그않에 AppDomain이 만들어집니다.
 * AppDomain은 어셈블리를 로딩해서 실행할 코드를 메모리에 적재합니다.
 * AssemblyBuilder 객체를 만들수 잇는 클래스가 System.AppDomain입니다.
 * DefineDynamicAssembly() 메소드로 AssemblyBuilder 인스턴스를 만들수 있습니다.
 */
