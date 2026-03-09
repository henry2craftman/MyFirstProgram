using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    public class BaseCalculator
    {
        private double num1;
        private double num2;
        public double Result { get; set; }

        public double Plus(double x, double y)
        {
            return x + y;
        }

        public double Minus(double x, double y)
        {
            return x - y;
        }

        public void Multiply(double x, double y, ref double result)
        {
            result = x * y;
        }

        public bool Divide(double x, double y, ref double result)
        {
            result =  x / y;

            return true;
        }
    }

    public class EngineeringCal : BaseCalculator
    {

    }
    internal class Calculator
    {
        static void Main32()
        {
            EngineeringCal cal = new EngineeringCal();

            while(true)
            {
                //Console.Clear();
                Console.WriteLine("------     아래에서 옵션을 선택해 주세요.    ------ ");
                Console.WriteLine("[1] 더하기 / [2] 빼기 / [3] 곱하기    / [4] 나누기  ");
                Console.WriteLine("[5] 제곱근 / [6] 제곱 / [7] 10의 제곱 / [8] 펙토리얼");
                Console.WriteLine("[0] 프로그램 종료");
                Console.WriteLine("--------------------------------------------------- ");


                string option = Console.ReadLine();

                if (option.Contains("0"))
                    break;

                int optionInt;
                bool isParsed = int.TryParse(option, out optionInt);

                if (!isParsed)
                {
                    Console.WriteLine("잘못 입력하셨습니다. 위 0~8 사이의 옵션을 숫자로 입력해 주세요.");
                    continue;
                }

                double num1, num2;
                KeyInput(out num1, out num2);

                switch (optionInt)
                {
                    case 1: 
                        cal.Result = cal.Plus(num1, num2);
                        break;
                    case 2:
                        cal.Result = cal.Minus(num1, num2);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                }

                Console.WriteLine("결과는 " + cal.Result + "입니다.");
            }
        }

        private static void KeyInput(out double num1, out double num2)
        {
            Console.Write("첫 번째 숫자를 입력: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력: ");
            num2 = double.Parse(Console.ReadLine());
        }
    }
}
