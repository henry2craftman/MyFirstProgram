using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class EnumStudy
    {
        enum Weekday
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thirsday,
            Friday,
            Saturday
        }

        enum Status
        {
            Stop,
            Idle,
            Runnung,
            Emmergency
        }

        enum KioskStatus
        {
            PowerOn,
            Idle,
            Order,
            Pay
        }

        static void Main23()
        {
            Weekday productionDay = Weekday.Monday;

            if(productionDay == Weekday.Monday)
            {
                Console.WriteLine("생산일은 월요입니다.");
            }

            Status status = Status.Stop;

            switch (status)
            {
                case Status.Stop:
                        Console.WriteLine("Stop 상태입니다.");
                    break;
                case Status.Idle:
                        Console.WriteLine("Idle 상태입니다.");
                    break;
                case Status.Runnung:
                        Console.WriteLine("Running 상태입니다.");
                    break;
                case Status.Emmergency:
                        Console.WriteLine("Emmergency 상태입니다.");
                    break;
            }

            // 키오스크 예제
            KioskStatus kioskStatus = KioskStatus.Idle;

            while(false)
            {
                switch (kioskStatus)
                {
                    case KioskStatus.Idle:
                        Console.WriteLine("주문을 하시려면 1을 눌러주세요.");

                        string input = Console.ReadLine();


                        if(input.Contains("1"))
                        {
                            kioskStatus = KioskStatus.Order;
                        }
                        break;
                    case KioskStatus.Order:
                        Console.WriteLine("아이스아메리카노를 입력해 주세요.");

                        input = Console.ReadLine();

                        if (input.Contains("아이스아메리카노"))
                        {
                            kioskStatus = KioskStatus.Pay;
                        }
                        break;
                    case KioskStatus.Pay:
                        Console.WriteLine("결재 방식을 선택해 주세요.");

                        input = Console.ReadLine();

                        if (input.Contains("카드"))
                        {
                            kioskStatus = KioskStatus.Idle;
                        }
                        break;
                }
            }

            Console.WriteLine("점수를 입력해 주세요.");

            string input2 = Console.ReadLine();
            int score = Int32.Parse(input2);

            if(score >= 90 && score <= 100)
            {
                Console.WriteLine("A학점 입니다.");
            }
            else if(score >= 80 && score <= 89)
            {
                Console.WriteLine("B학점 입니다.");
            }
            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine("C학점 입니다.");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("D학점 입니다.");
            }
            else
            {
                Console.WriteLine("F학점 입니다.");
            }
        }
    }
}
