using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace thisCS.Chapter15a
{
    class SimpleLinq2
    {
        //static void Main(string[] args)
        //{
        //    Profile[] arrProfile =
        //    {
        //        new Profile(){Name="정우성", Height=186},
        //        new Profile(){Name="김태희", Height=158},
        //        new Profile(){Name="고현정", Height=172},
        //        new Profile(){Name="이문세", Height=178},
        //        new Profile(){Name="하하", Height=171}
        //    };

        //    var profiles = arrProfile.
        //        Where(profile => profile.Height < 175).
        //        OrderBy(profile => profile.Height).
        //        Select(profile =>
        //            new
        //            {
        //                Name = profile.Name,
        //                InchHeight = profile.Height * 0.393
        //            });

        //    foreach (var profile in profiles)
        //        Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
        //}
    }
}
/* LINQ의 비밀과 LINQ 표준 연산자
 * LINQ 쿼리식을 분석해서 일반적인 메소드 호출 코드로 만들어내는 것뿐이다.
 * where 는 Where()
 * orderby 는 OrderBy()
 * select 는 Select() 
 * 범위변수는 각메소드에 입력되는 람다식의 매개변수로 변경.
 * 
 * arrProfile은 배열이기 때문에 IEnumerable<T> 형식이며 System.Collections.Generic 네임스페이스 소속이다.
 * System.Collections.Generic만 using하면 실행이 되지 않는다.
 * 그 이유는 각 메소드들이 System.Linq 네임스페이스에 정이되있는 IEnumerable<T>의 확장 메소드이기 때문이다.
 * 따라서 위의 예저는 System.Linq가 using되어 있어야 정상적으로 돌아갈수 있다.
 */