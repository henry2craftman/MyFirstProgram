using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class ExceptionStudy
    {
        static void Main23()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };

                for (int i = 0; i < numbers.Length + 1; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("프로그램 종료");
            }

            Console.WriteLine("기능2 작동");
        }
    }
}
