using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace thisCS.Chapter15a
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class SimpleLinq
    {
        //static void Main(string[] args)
        //{
        //    Profile[] arrProfile =
        //    {
        //        new Profile(){Name="정우성", Height=186},
        //        new Profile(){Name="김태희", Height=158},
        //        new Profile(){Name="고현정", Height=172},
        //        new Profile(){Name="이문세", Height=178},
        //        new Profile(){Name="하동훈", Height=171}
        //    };

        //    var profiles = from profile in arrProfile
        //                   where profile.Height < 175
        //                   orderby profile.Height
        //                   select new
        //                   {
        //                       Name = profile.Name,
        //                       InchHeight = profile.Height * 0.393
        //                   };

        //    foreach (var profile in profiles)
        //        Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
        //}
    }
}
/* where, orderby, select
 * 
 * where 필터
 * 
 * orderby      ascending, descending
 * 
 * select
 *      LINQ의 질의 결과는 IEnumerable<T>로 반환 되는데 T는 select문으로 결정된다.
 *      var의 타입은 select문으로 결정된다.
 *      Profile객체를 골라 리턴하면 IEnumerable<Profile>
 *      Name프로퍼티만 골라 리턴하면 IEnumerable<string>
 *      형식으로 컴파일이 된다.
 *      무명 형식을 이용하여 새로운 형식을 즉성으로 만들어 낼수도 있다.
 *      */

