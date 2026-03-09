using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstProgram
{
    #region 면접관을 위한 설계 포인트 (Interview Points)
    /*
     * 1. 인터페이스 추상화: IOperation 인터페이스를 통해 새로운 연산이 추가되어도 
     *    기존의 연산 엔진 코드를 수정할 필요가 없습니다. (Open-Closed Principle 준수)
     * 2. 예외 처리: 사용자 입력의 유효성을 검증하고, 0으로 나누기 등의 런타임 에러를 방어합니다.
     * 3. UX 개선: 콘솔 색상과 박스 드로잉 문자를 사용하여 가독성 높은 인터페이스를 제공합니다.
     * 4. 데이터 관리: 계산 이력을 메모리(List)에 저장하여 사용자에게 다시 보여주는 기능을 포함합니다.
     */
    #endregion

    /// <summary>
    /// 연산자의 행위를 정의하는 공통 인터페이스입니다.
    /// 새로운 연산(예: 나머지, 제곱)을 추가하려면 이 인터페이스를 구현하는 새 클래스만 만들면 됩니다.
    /// </summary>
    public interface IOperation
    {
        string Name { get; }
        string Symbol { get; }
        double Execute(double num1, double num2);
    }

    // 기본 연산 클래스들 (각자의 책임을 가짐 - Single Responsibility Principle)
    public class AddOperation : IOperation
    {
        public string Name => "더하기";
        public string Symbol => "+";
        public double Execute(double num1, double num2) => num1 + num2;
    }

    public class SubtractOperation : IOperation
    {
        public string Name => "빼기";
        public string Symbol => "-";
        public double Execute(double num1, double num2) => num1 - num2;
    }

    public class MultiplyOperation : IOperation
    {
        public string Name => "곱하기";
        public string Symbol => "*";
        public double Execute(double num1, double num2) => num1 * num2;
    }

    public class DivideOperation : IOperation
    {
        public string Name => "나누기";
        public string Symbol => "/";
        public double Execute(double num1, double num2)
        {
            if (num2 == 0) throw new DivideByZeroException("0으로 나눌 수 없습니다.");
            return num1 / num2;
        }
    }

    /// <summary>
    /// 계산기 엔진: 연산들을 관리하고 계산 로직을 수행합니다.
    /// </summary>
    public class CalculatorEngine
    {
        private readonly Dictionary<string, IOperation> _operations = new();
        private readonly List<string> _history = new();

        public CalculatorEngine()
        {
            // 기본 연산 등록
            RegisterOperation(new AddOperation());
            RegisterOperation(new SubtractOperation());
            RegisterOperation(new MultiplyOperation());
            RegisterOperation(new DivideOperation());
        }

        public void RegisterOperation(IOperation op)
        {
            _operations[op.Symbol] = op;
        }

        public IReadOnlyList<string> GetHistory() => _history;

        public double PerformCalculation(double num1, string symbol, double num2)
        {
            if (!_operations.ContainsKey(symbol))
                throw new NotSupportedException($"지원하지 않는 연산자입니다: {symbol}");

            try
            {
                double result = _operations[symbol].Execute(num1, num2);
                _history.Add($"{num1} {symbol} {num2} = {result}");
                return result;
            }
            catch (Exception)
            {
                _history.Add($"{num1} {symbol} {num2} = 에러 발생");
                throw;
            }
        }

        public IEnumerable<string> GetSupportedSymbols() => _operations.Keys;
    }

    /// <summary>
    /// 메인 프로그램 실행 클래스
    /// </summary>
    public class PremiumCalculator
    {
        private static readonly CalculatorEngine Engine = new();

        public static void Mai32n()
        {
            Console.Clear();
            ShowHeader();

            bool isRunning = true;
            while (isRunning)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n[메뉴] 1.계산하기  2.이력보기  3.종료");
                Console.ResetColor();
                Console.Write("입력: ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1": 
                        RunCalculation(); 
                        break;
                    case "2": 
                        ShowHistory(); 
                        break;
                    case "3": 
                        isRunning = false; 
                        break;
                    default: 
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("잘못된 메뉴 선택입니다."); 
                        break;
                }
            }
            
            Console.WriteLine("\n프로그램을 종료합니다. 행운을 빕니다!");
        }

        private static void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("┌──────────────────────────────────────────┐");
            Console.WriteLine("│      Premium Interview Calculator        │");
            Console.WriteLine("│       (SOLID Principles Applied)         │");
            Console.WriteLine("└──────────────────────────────────────────┘");
            Console.ResetColor();
        }

        private static void RunCalculation()
        {
            try
            {
                Console.Write("\n첫 번째 숫자 입력: ");
                double n1 = double.Parse(Console.ReadLine() ?? "0");

                Console.Write($"연산자 입력 ({string.Join(", ", Engine.GetSupportedSymbols())}): ");
                string op = Console.ReadLine() ?? "";

                Console.Write("두 번째 숫자 입력: ");
                double n2 = double.Parse(Console.ReadLine() ?? "0");

                double result = Engine.PerformCalculation(n1, op, n2);
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n결과: {result}");
                Console.ResetColor();
            }
            catch (FormatException)
            {
                PrintError("숫자만 입력 가능합니다.");
            }
            catch (Exception ex)
            {
                PrintError(ex.Message);
            }
        }

        private static void ShowHistory()
        {
            var history = Engine.GetHistory();
            Console.WriteLine("\n--- 계산 이력 ---");
            if (!history.Any()) Console.WriteLine("이력이 없습니다.");
            foreach (var h in history) Console.WriteLine(h);
            Console.WriteLine("----------------");
        }

        private static void PrintError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"오류: {msg}");
            Console.ResetColor();
        }
    }
}
