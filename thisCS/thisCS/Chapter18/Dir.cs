using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace thisCS.Chapter18
{
    class Dir
    {
        //static void Main(string[] args)
        //{
        //    string directory;
        //    if (args.Length < 1)
        //        directory = ".";
        //    else
        //        directory = args[0];
        //    directory = "c:\\Users";
        //    Console.WriteLine($"{directory} directory Info");
        //    Console.WriteLine("- Directories :");
        //    var directories = (from dir in Directory.GetDirectories(directory)
        //                       let info = new DirectoryInfo(dir)
        //                       select new
        //                       {
        //                           Name = info.Name,
        //                           Attributes = info.Attributes
        //                       }).ToList();

        //    foreach (var d in directories)
        //        Console.WriteLine($"{d.Name} : {d.Attributes}");

        //    Console.WriteLine("- Files :");
        //    var files = (from file in Directory.GetFiles(directory)
        //                 let info = new FileInfo(file)
        //                 select new
        //                 {
        //                     Name = info.Name,
        //                     FileSize = info.Length,
        //                     Attributes = info.Attributes
        //                 }).ToList();

        //    foreach (var f in files)
        //        Console.WriteLine($"{f.Name} : {f.FileSize}, {f.Attributes}");
        //}
    }
}

/* 예제 프로그램: 디렉토리/파일 정보 조회하기
 */
/* 파일 정보와 디렉토리 정보 다루기
 * 파일과 디렉토리 정보를 손쉽게 다룰수 있도록 System.IO 네임스페이스 아래에 아래의 클래스들을 제공.
 * File, FileInfo
 * Directory, DirctoryInfo
 * 둘의 차이는 작업내용은 같지만 한쪽은 정적메소드 info는 인스턴스메소드를 제공한다.
 * 생성 복사 삭제 이동 존재여부확인 속성조회 하위디렉토리조회 하위파일조회
 */