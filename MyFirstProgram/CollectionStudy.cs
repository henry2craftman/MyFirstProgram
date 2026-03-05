using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class CollectionStudy
    {
        static void Main23()
        {
            // 컬렉션 = 자료구조 = 참조형
            // 1. 리스트
            // null : 주소가 없음...
            List<int> numberList = new List<int>();
            numberList.Add(5);
            numberList.Add(10);
            numberList.Add(20); // 가변형

            numberList.Remove(5);

            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }

            List<string> names = new List<string>() { "신태욱", "김하나" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // 반환형(isOK)과 인자("신태욱")가 있는 메서드
            bool isOK = names.Contains("신태욱");
            Console.WriteLine(isOK);

            names.IndexOf("김하나"); // 김하나의 번지수 확인
            names.BinarySearch("김하나"); // 자료를 반씩 나눠서 찾기

            // 참조형 자료구조: 문자열, 컬렉션 -> 주소를 힙에 저장 -> 실제 값은 스택에...
            // 값형 자료구조: int, bool, 기본자료형 -> 바로 스택에 저장

            // 2. 딕셔너리
            Dictionary<string, int> membership = new Dictionary<string, int>();
            membership.Add("신태욱", 200);
            membership.Add("김하나", 205);

            int value = membership["신태욱"];
            Console.WriteLine("신태욱은 " + value + "번째 회원입니다.");

            // TravelLog();

            // 3. 해시셋(hashset): 중복없는 저장공간
            HashSet<int> memberNum = new HashSet<int>();
            memberNum.Add(5586);
            memberNum.Add(8852);
            memberNum.Add(1435);
            memberNum.Add(1435);

            memberNum.Remove(8852);

            foreach (int num in memberNum)
            {
                Console.WriteLine(num);
            }

            // 4. Stack: 아래에서 위로 데이터를 쌓고, 위에 쌓인 순서대로 데이터 사용
            //           LIFO(Last in First Out)
            // 예) 페이지 뒤로가기, 프로그램 실행취소
            Stack<string> parkingArea = new Stack<string>();
            parkingArea.Push("자동차1");
            parkingArea.Push("자동차2");
            parkingArea.Push("자동차3");

            parkingArea.Pop();
            Console.WriteLine("마지막 자동차는 " + parkingArea.Peek());

            foreach(string car in parkingArea)
            {
                Console.WriteLine(car);
            }

            parkingArea.Clear(); // 전부 지우기

            // 5. Queue: 순서대로 데이터를 사용
            // 예) 붕어빵 타이쿤(순서대로 손님에게 전달), 식당 주문표, 키오스크
            // 프린터 대기열
            Queue<string> kiosk = new Queue<string>();
            kiosk.Enqueue("손님1: 아이스아메리카노 x1");
            kiosk.Enqueue("손님2: 핫초코x1, 초코프라푸치노x1");

            foreach(string order in kiosk)
            {
                Console.WriteLine(order);
            }

            kiosk.Dequeue(); // 손님1 해결

            foreach (string order in kiosk)
            {
                Console.WriteLine(order);
            }
        }

        private static void TravelLog()
        {
            Console.WriteLine("---------------------------------------");

            // 간단한 여행 계획표 만들기
            // - 입력기능: 여행 날짜를 입력한 후, 내용을 입력할 수 있게
            // - 출력기능: 여행 날짜를 입력하면, 내용을 출력하게

            Dictionary<string, string> travelLog = new Dictionary<string, string>();

            Console.WriteLine("여행 계획을 입력해 주세요.");

            while (true)
            {
                // 실습1. 입력모드(1), 검색모드(2) 만들기.
                // "등록을 원하시면 1번을, 검색을 원하시면 2번을 눌러주세요."
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // 등록모드
                        Console.Write("여행 날짜 (예. 260303): ");
                        string date = Console.ReadLine();   // 콘솔에 입력기능

                        Console.Write("내용: ");
                        string content = Console.ReadLine();

                        // 딕셔너리에 저장
                        travelLog[date] = content;

                        if (date.Contains('q') || content.Contains('q'))
                        {
                            Console.WriteLine("프로그램을 종료합니다...");
                            break;
                        }
                        break;
                }
            }
        }
    }
}
