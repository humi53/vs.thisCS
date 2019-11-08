using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

namespace thisCS.Chapter16
{
    class EmitTest
    {
        //public static void Main()
        //{
        //    //AssemblyBuilder newAssembly = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);
        //}
    }
}
/* 해당 프로젝트는 .NET Core 프로젝트이고,
 * 해당 예제는 .NET Framework 프로젝트가 필요해보임.
 * 같은 using임에도 불구하고 DefineDynamicAssembly가 존재하지 않아 해당 프로젝트에서 진행불가.
 * 다른프로젝트를 열어서 예제 진행.
 */
