using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    /// <summary>
    /// FileStream, StreamReader, StreamWriter를 사용하여
    /// 파일 읽고 쓰기
    /// </summary>
    internal class FileAndStreamStudy
    {
        static void Main21()
        {
            ReadFile();

            WriteFile();

            ReadBinaryFile();

            WriteBinaryFile();
        }

        private static void WriteBinaryFile()
        {
            FileStream fs = new FileStream("binary.dat", FileMode.Append);
            BinaryWriter bw = new BinaryWriter(fs);

            byte[] buf = new byte[3] { 48, 48, 53 };
            bw.Write(buf);
            bw.Close();
            fs.Close();
        }

        private static void ReadBinaryFile()
        {
            FileStream fs = new FileStream("binary.dat", FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(fs);

            byte[] buf = new byte[1024];
            int byteRead = br.Read(buf, 0, 3);
            Console.WriteLine($"{byteRead}개를 읽었습니다.");

            br.Close();
            fs.Close();

            // 이미지, 오디오, 비디오
            // 게임 세이브 데이터, 통신 데이터
        }

        private static void WriteFile()
        {
            FileStream fs = new FileStream("memo.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello World!");
            sw.Close();
            fs.Close();
        }

        private static void ReadFile()
        {
            // 1. FileStream: 파일 열고 닫기가 주 용도, 읽고 쓰기등 기본 입출력기능제공
            FileStream fs = new FileStream("memo.txt", FileMode.OpenOrCreate);

            StreamReader sr = new StreamReader(fs);

            string content = sr.ReadLine(); // 열려있는 파일을 한줄 읽기

            Console.WriteLine(content);

            content = sr.ReadLine();    // 두 번째 줄 읽기

            Console.WriteLine(content);

            content = sr.ReadToEnd();   // 끝 까지 읽기

            // 파일에서 내용을 한줄씩 읽으면서 확인하기
            string line;
            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine($"{i}번째 줄은 {line}입니다.");

                i++;
            }

            sr.Close();
            fs.Close();
        }
    }
}
