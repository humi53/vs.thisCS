using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace thisCS.Chapter15
{
    class MinMaxAvg
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

        //    var heightStat = from profile in arrProfile
        //                     group profile by profile.Height < 175 into g
        //                     select new
        //                     {
        //                         Group = g.Key == true ? "175미만" : "175이상",
        //                         Count = g.Count(),
        //                         Max = g.Max(profile => profile.Height),
        //                         Min = g.Min(profile => profile.Height),
        //                         Average = g.Average(profile => profile.Height)
        //                     };
        //    foreach(var stat in heightStat)
        //    {
        //        Console.Write("{0} - Count:{1}, Max:{2} ", stat.Group, stat.Count, stat.Max);
        //        Console.WriteLine("Min:{0}, Average:{1}", stat.Min, stat.Average);

        //    }
        //}
    }
}
/* LINQ의 비밀과 LINQ 표준 연산자
 * 표준LINQ 연산메소드 53개
 * 그중에 C#쿼리식에서 지원하는것은 11개
 * 나머지 42개를 활용할수 있다면 프로그래밍이 더 편해진다.
 */
