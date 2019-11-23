using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace thisCS.Chapter18
{
    class Touch
    {
        static void OnWrongPathType(string type)
        {
            Console.WriteLine($"{type} is wrong type");
            return;
        }

        //static void Main(string[] args)
        //{
        //    //if(args.Length == 0)
        //    //{
        //    //    Console.WriteLine("Using : Touch.exe <Path> [Type:File/Directory]");
        //    //    return;
        //    //}

        //    //string path = args[0];
        //    string path = "a.dat";
        //    string type = "File";
        //    //if (args.Length > 1)
        //    //    type = args[1];

        //    if(File.Exists(path) || Directory.Exists(path))
        //    {
        //        if (type == "File")
        //            File.SetLastWriteTime(path, DateTime.Now);
        //        else if (type == "Directory")
        //            Directory.SetLastWriteTime(path, DateTime.Now);
        //        else
        //        {
        //            OnWrongPathType(path);
        //            return;
        //        }
        //        Console.WriteLine($"Updated {path} {type}");
        //    }
        //    else
        //    {
        //        if (type == "File")
        //            File.Create(path).Close();
        //        else if (type == "Directory")
        //            Directory.CreateDirectory(path);
        //        else
        //        {
        //            OnWrongPathType(path);
        //            return;
        //        }
        //        Console.WriteLine($"Created {path} {type}");
        //    }
        //}
    }
}
/* 예제 프로그램: 디렉토리/파일 생성하기
 */