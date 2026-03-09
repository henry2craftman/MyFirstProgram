using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    // 값유형 -> 스텍에 저장
    public struct Point
    {
        public int X {  get; set; }
        public int Y {  get; set; }

        public Point (int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Translate(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
    }

    internal class StructStudy
    {
        static List<Point> pointList;

        static void Main23()
        {
            Point point = new Point(5, 6);
            point.Translate(5, 10);

            pointList = new List<Point>();
        }
    }
}
