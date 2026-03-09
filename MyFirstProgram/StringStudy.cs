using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class StringStudy
    {
        static void Main34()
        {
            string name = " abc ";
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Contains('b'));
            Console.WriteLine(name.Replace('c', 'd'));

            Console.WriteLine(name.Trim());

            // CSV(comma seperated value)
            string code = "abc,123,456,def";
            string[] codeSplited = code.Split(',');
            foreach (string s in codeSplited)
            {
                Console.WriteLine(s);
            }

            string subCode = code.Substring(4, 11);
            Console.WriteLine(subCode);

            // 55+88-55.5*55.44

            // 서식지정자
            string valueA = "Hello";
            string valueB = "World";
            string valueC = "~!";

            Console.WriteLine("{0} {1} {2}", valueA, valueB, valueC);
            Console.WriteLine($"{valueA} {valueB} {valueC}");

            // 수치 서식 지정자
            Console.WriteLine("C: {0,6:C}", 1234567);
            Console.WriteLine("D: {0,6:D}", 1234567);
            Console.WriteLine("E: {0,6:E}", 1234567);
            Console.WriteLine("F: {0,6:F}", 1234567);
            Console.WriteLine("G: {0,6:G}", 1234567);
            Console.WriteLine("N: {0,6:N}", 1234567);
            Console.WriteLine("P: {0,6:P}", 1234567);
            Console.WriteLine("X: {0,6:X}", 1234567);

            // 날짜 및 시간 서식 지정자
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            string newNow = now.ToString("yyyy-MM-dd HH:mm");
            Console.WriteLine(newNow);

            // 포메팅 메서드
            int number = 10;
            string numberStr = number.ToString();
        }
    }
}
