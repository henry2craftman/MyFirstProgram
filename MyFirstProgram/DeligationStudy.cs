using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{

    // 델리게이션(대리인)의 주요 용도
    // 1. 콜백함수 구현(callback function)
    // ex) ChatGPT 서버에 요청을 보내고 받는 즉시 실행되는 함수
    // 2. Unity에서는 버튼 이벤트 처리 시 사용
    // ex) 하나의 버튼으로 여러 기능을 수행(기능 + 이펙트 + 소리)
    // ex2) 게임 캐릭터 스킬시전(공격모션 + 이펙트 + 소리 ...)
    internal class DeligationStudy
    {
        // 1. 대리인 템플릿 만들기
        delegate void template();
        delegate void templateParam(int a, int b); // 두 인자가 있는 메서드를 실행
        delegate string templateStr(string a, string b); // 두 인자와 리턴값이 있는 템플릿

        static void Main()
        {
            template myDelegate; // 대리인
            myDelegate = PrintMessage; // 대리인에게 기능을 등록  -> 캐스팅(castring)
            myDelegate += Add;          // 기능 등록2 -> 멀티 캐스팅
            myDelegate -= Add;          // 기능 등록 취소

            if(myDelegate != null)
                myDelegate(); // 대리인이 등록된 기능을 사용(반드시 기능을 등록 후 사용)

            // 대리인 기능 인덱싱
            Delegate[] delList = myDelegate.GetInvocationList();
            template firstWork = (template)delList[0];
            firstWork();

            templateParam myDelegate2;
            myDelegate2 = Minus;
            myDelegate2(5, 3);

            templateStr myDelegate3;
            myDelegate3 = PrintMessage;
            string result = myDelegate3("Hello ", "World~!");
        }

        static void Minus(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void PrintMessage()
        {
            Console.WriteLine("대리인이 출력합니다.");
        }

        static void Add()
        {
            Console.WriteLine($"A와 B를 더했습니다.");
        }

        static string PrintMessage(string msg1, string msg2)
        {
            return msg1 + msg2;
        }
    }
}
