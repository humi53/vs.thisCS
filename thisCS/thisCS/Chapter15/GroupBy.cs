using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace thisCS.Chapter15b
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class GroupBy
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

        //    var listProfile = from profile in arrProfile
        //                      orderby profile.Height
        //                      group profile by profile.Height < 175 into g
        //                      select new { GroupKey = g.Key, Profiles = g };

        //    foreach(var Group in listProfile)
        //    {
        //        Console.WriteLine($"- 175cm 미만? : {Group.GroupKey}");
        //        foreach(var profile in Group.Profiles)
        //            Console.WriteLine($"    {profile.Name}, {profile.Height}");
        //    }
        //}
    }
}
/* group by로 데이터 분료하기
 * group 범위변수 by 분류기준 into 그룹변수
 * 예제의 그룹변수 g에는 175미만인 객체의 컬렉션, 175 이상인 객체의 컬렉션이 입력되고
 * select 문이 추출하는 새로운 무명현식은 컬렉션의 컬렉션이 된다.
 */