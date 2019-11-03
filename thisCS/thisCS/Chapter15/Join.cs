using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace thisCS.Chapter15c
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Product
    {
        public string Title { get; set; }
        public string Str { get; set; }
    }
    class Join
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

        //    Product[] arrProduct =
        //    {
        //        new Product(){Title="비트",       Str="정우성"},
        //        new Product(){Title="CF 다수",    Str="김태희"},
        //        new Product(){Title="아이리스",   Str="김태희"},
        //        new Product(){Title="모래시계",   Str="고현정"},
        //        new Product(){Title="Solo 예찬",  Str="이문세"}
        //    };

        //    var listProfile =
        //        from profile in arrProfile
        //        join product in arrProduct on profile.Name equals product.Str
        //        select new
        //        {
        //            Name = profile.Name,
        //            Work = product.Title,
        //            Height = profile.Height
        //        };

        //    Console.WriteLine("--- 내부 조인 결과 ---");
        //    foreach(var profile in listProfile)
        //    {
        //        Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}cm", profile.Name, profile.Work, profile.Height);
        //    }

        //    listProfile =
        //        from profile in arrProfile
        //        join product in arrProduct on profile.Name equals product.Str into ps
        //        from product in ps.DefaultIfEmpty(new Product() { Title = "그런거 없음" })
        //        select new
        //        {
        //            Name = profile.Name,
        //            Work = product.Title,
        //            Height = profile.Height
        //        };
        //    Console.WriteLine();
        //    Console.WriteLine("--- 외부 조인 결과 ---");
        //    foreach(var profile in listProfile)
        //    {
        //        Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}cm", profile.Name, profile.Work, profile.Height);
        //    }
        //}
    }
}
/* 내부조인 외부조인
 * 내부조인 : equals이 맞을 경우에만 결과를 도출.
 *      from a in A
 *      join b in B a.XXX equals b.YYY
 * 외부조인 : equals이 맞지 않아도 결과를 도출.
 *      from a in A
 *      join b in B a.xxx equals b.yyy into ps
 *      from b in ps.DefaultIfEmpty(new B(){변수=값})
 *      외부조인은 기준이 되는 데이터를 조인 결과에 반드시 포함한다.
 *      연결데이터가 원본데이터에 일치하는 값이 없으면 그부분을 빈값으로 채우게 된다.
 *      조인결과를 임시컬렉션(ps)에 저장하고 이 임시컬렉션에 대해 DefaultIfEmpty연상을 수행해 비어있는 조인 결과에 빈값을 채워놓는다.
 *      결과를 from 절을 통해 범위변수를 뽑아내어 원본에서나온 범위변수와 함께 결과를 추출한다.
 *      
 * left join, right join, full outer join
 * DBMS에서 사용하는 sql을 본떠 프로그래밍 언어에 통합한것이다.
 * 왼쪽조인은 왼쪽기준 오른쪽조인은 오른쪽기준 완전외부조인은 양쪽모두 기준을 삼는다.
 * 하지만 LINQ에서는 왼쪽 조인만 지원을 한다. 데이터를 다루는데는 이것만으로도 충분할것이다.
 */