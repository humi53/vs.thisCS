using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter07
{
    struct Point3D
    {
        public int X;
        public int Y;
        public int Z;

        public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
            return string.Format($"{X}, {Y}, {Z}");
        }
    }
    class Structure
    {
        //static void Main(string[] args)
        //{
        //    Point3D p3d1;
        //    p3d1.X = 10;
        //    p3d1.Y = 20;
        //    p3d1.Z = 40;

        //    Console.WriteLine(p3d1.ToString());

        //    Point3D p3d2 = new Point3D(100, 200, 300);
        //    Point3D p3d3 = p3d2;
        //    p3d3.Z = 400;

        //    Console.WriteLine(p3d2.ToString());
        //    Console.WriteLine(p3d3.ToString());
        //}
    }
}
/* 구조체
 * struc 값형식 깊은복사
 * 선언만으로도 생성
 * 매개 변수 없는 생성자 선언 불가능
 * 모든 구조체는 System.Object를 상속받는 System.VauleType으로부터 직접 상속받음
 */
