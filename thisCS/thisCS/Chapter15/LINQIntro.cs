using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thisCS.Chapter15
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class LINQIntro
    {
        //static void Main(string[] args)
        //{
        //    // 프로그램 목표 : arrProfile에서 Height 프로퍼티가 175 미만인 데이터만 골라
        //    //                  키의 오름차순으로 정렬하며 추출한다.
        //    Profile[] arrProfile =
        //    {
        //        new Profile(){Name="정우성", Height=186},
        //        new Profile(){Name="김태희", Height=158},
        //        new Profile(){Name="고현정", Height=172},
        //        new Profile(){Name="이문세", Height=178},
        //        new Profile(){Name="하동훈", Height=171}
        //    };
            
        //    //일반적인 추출코드.
        //    List<Profile> profiles = new List<Profile>();
        //    foreach(Profile profile in arrProfile)
        //    {
        //        if (profile.Height < 175)
        //            profiles.Add(profile);
        //    }
        //    profiles.Sort((profile1, profile2) =>
        //    {
        //        return profile1.Height - profile2.Height;
        //    });
        //    foreach (var profile in profiles)
        //        Console.WriteLine("{0}, {1}", profile.Name, profile.Height);


        //    //LINQ를 사용한 코드. 훨씬 간결.
        //    var profiles2 = from profile in arrProfile
        //                    where profile.Height < 175
        //                    orderby profile.Height
        //                    select profile;
        //    foreach (var profile in profiles2)
        //        Console.WriteLine("{0}, {1}", profile.Name, profile.Height);

        //}
    }
}
/* 데이터! 데이터! 데이터!
 * LINQ는 지루한 데이터 작업에서 해방시켜준다.
 * From : 어떤 데이터 집합에서 찾을것인가?
 * Where : 어떤 값의 데이터를 찾을 것인가?
 * Select : 어떤 항목을 추출할 것인가?
 */
