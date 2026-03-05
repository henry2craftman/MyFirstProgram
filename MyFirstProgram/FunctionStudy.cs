using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class FunctionStudy
    {
        static void Main23()
        {
            PrintYourName();
            PrintName("김하나");
            PrintName("김흥수");
            Add(5, 8);
            float temp = Add(3.14f, 55.69f);
            Console.WriteLine(temp);

            // 내부함수
            void PrintYourName()
            {
                Console.WriteLine("신태욱");
            }

            // 인자(파라미터)가 있는 내부함수
            void PrintName(string name)
            {
                Console.WriteLine(name);
            }

        }

        // 인자가 여러개인 정적메서드
        static void Add(int numA, int numB)
        {
            Console.WriteLine(numA + numB);
        }

        // 다형성(polymolphysm): 같은 이름이지만, 형태를 다르게 해서
        //                       유지보수성 업!
        // 메서드의 오버로드: 같은 이름의 다른 기능의 메서드
        // 리턴값(반환값)이 있는 메서드
        static float Add(float numA, float numB)
        {
            return numA + numB;
        }

        
        class Coord
        {
            public int x, y;
        }

        // 반환형이 여러개인 메서드
        // 거리를 계산해서 x, y를 반환
        static Coord CalculateCoord(int x, int y)
        {
            Coord coord = new Coord(); // 객체화, 인스턴싱
            coord.x = x;
            coord.y = y;

            return coord;
        }
    }
}
