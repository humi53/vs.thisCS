using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace COMIntroop
{
    class MainApp
    {
        public static void OldWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;
            for(int i=0;i<data.GetLength(0); i++)
            {
                ((Excel.Range)worksheet.Cells[i + 1, 1]).Value2 = data[i, 0];
                ((Excel.Range)worksheet.Cells[i + 1, 2]).Value2 = data[i, 1];
            }

            worksheet.SaveAs(savePath + "\\shark-book-old.xlsx",
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing);

            excelApp.Quit();
        }

        public static void NewWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            Excel._Worksheet worksheet = excelApp.ActiveSheet;
            for(int i = 0; i < data.GetLength(0); i++)
            {
                worksheet.Cells[i + 1, 1] = data[i, 0];
                worksheet.Cells[i + 1, 2] = data[i, 1];
            }
            worksheet.SaveAs(savePath + "\\shpark_book-dynaic.xlsx");
            excelApp.Quit();
        }
        static void Main(string[] args)
        {
            string savePath = System.IO.Directory.GetCurrentDirectory();
            string[,] array = new string[,]
            {
                {"뇌를 자극하는 알고리즘", "2009" },
                {"뇌를 자극하는 C# 4.0", "2011" },
                {"뇌를 자극하는 C# 5.0", "2013" },
                {"뇌를 자극하는 파이썬 3", "2016" },
                {"이것이 C#이다", "2018" }
            };

            Console.WriteLine("Creating Excel doucument in old way...");
            OldWay(array, savePath);

            Console.WriteLine("Creating Excel doucument in new way...");
            NewWay(array, savePath);
        }
    }
}
/* COM과 .NET 사이의 상호 운용성을 위한 dynamic 형식
 * C#을 비롯한 .NET 언어들은 RCW(Runtime Callable Wrapper)를 통해서 COM 컴포넌트를 사용할수 있다.
 * RCW는 .NET 프레임워크가 제공하는 Type Library Importer(tlbimp.exe)를 이용해서 만들수 있다.
 * 
 * 불편하게 하는점들.
 * COM은 메소드 결과를 반환할 때 실제 형식이 아닌 object형식으로 반환 그래서 C#코드에선 실제 형식으로 변환해야 하는 번거로움이 있었습니다.
 * COM은 오버로딩을 지원하지 않습니다. 그래서 COM API를 호출하려면 매개변수를 수없이 입력해줘야 하는 번거로움 존재.
 * C# 4.0 이후부터 이 문제들을 해결.
 * 첫번째 문제는 dynamic형식을 도입, 두번째 문제는 메소드의 선택적 매개변수와 기본값 매개변수를 도입.
 * 
 * 선택적 매개변수와 dynamic형식은 비주얼 스튜디오가 RCW를 만들때 사용하고 프로그래머들은 전혀 손대지 않는다.
 * 인텔리센스 기능을 사용하여 dynamic형식을 사용하는것을 확인 가능하다.
 */