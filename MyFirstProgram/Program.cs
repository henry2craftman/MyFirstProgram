class Program
{
    // 프로그램 실행시 진입하는 함수
    // 오직 1개 -> static(정적) -> 스테틱메서드
    // 메서드(클래스 내에서 사용될때) vs 함수(일반기능을 나타낼때)
    static void Main()
    {
        Console.WriteLine("안녕하신가요~");

        // 변수(variable): 타입 / 이름 / 값
        int number = 5;         // 4바이트
        long longNumber = 230;  // 8바이트
        bool isActive = true;   // true or false
        float value = 3.14f;    // 4바이트
        double doubleVale = 3.421412; // 8바이트
        char code = 'A';        // 2바이트
        
        // 참조형 변수
        string name = "신태욱"; // 문자들의 배열

        // 아키텍처
        // 64bit 기반의 아키텍처

        int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string[] books = new string[5];
        books[0] = "삼국지";
        books[1] = "오만과편견";
        books[2] = "퓨처셀프";
        books[3] = "도덕경";
        books[4] = "노자";
        // books[5] = "하하하"; // IndexOutOfRangeException: 배열의 범위를 벗어남.

        string[] names = new string[3] { "신태욱", "김흥수", "이하나" };

        Console.WriteLine(names.Length); // 배열의 길이 속성(property)
        Console.WriteLine(names.Rank);   // 배열의 차원

        string[] names2 = new string[3];
        names.CopyTo(names2, 0);
        Console.WriteLine(names2[0]);

        Array.Reverse(names);
        Console.WriteLine(names[0]);

        // 2차원 배열(2x2 책꽂이)
        string[,] bookShelf =
        {
            { "퓨처셀프", "삼국지" },
            { "도덕경", "노자"}
        };
    }
}