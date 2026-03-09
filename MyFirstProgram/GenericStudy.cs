using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class GenericStudy
    {
        public class GenericList<T>
        {
            private T[] items;
            public int Count { get; }

            public GenericList(int capacity)
            {
                items = new T[capacity];
            }
        }

        public class Cal<T> where T : INumber<T>
        {
            public T Add(T num1, T num2)
            {
                return num1 + num2;
            }

            public void DisplayType(T value)
            {
                Console.WriteLine(typeof(T).Name);
            }
        }

        static void Main32()
        {
            GenericList<int> genericList = new GenericList<int>(5);
        
            var cal = new Cal<int>();
            cal.DisplayType(5);

            MyFirstProgram.Car car = new MyFirstProgram.Car();
            

            List<Person> personList = new List<Person>();
            Person person  = new Person("신태욱", 20);
            Person person1 = new Person("김흥수", 25);
            Person person2 = new Person("김하나", 30);
            personList.Add(person);
            personList.Add(person1);
            personList.Add(person2);

            var newPersonList = personList.Where(p => (p.age <= 25))
                                          .Select(p => p);

            var newPersonList2 = from p in personList
                                 where p.age >= 30 
                                 select p;

            foreach(var p in newPersonList)
            {
                Console.WriteLine($"{p.Name}");
            }

            int num1 = 3;
            float num2 = num1;
            int num3 = (int)num2;
            string num4 = "10";
        }
    }
}
