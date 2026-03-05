using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    // 템플릿, 형식 -> 설명서
    public class Person // 일반클래스: new 키워드로 객체를 만들기 위해 사용
    {
        private string name;
        public string Name // 속성(property): 읽기전용 or 쓰기전용 or 모든권한
        {
            get // 읽기전용
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int age;
        public string Hobby { get; set; }
        public int Ballance { get; }


        public Person() { }

        // 생성자(constructor): 클래스를 객체화할 때 초기화용
        // 생성자의 오버로드
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;

            Greet();
        }

        public void Greet()
        {
            Console.WriteLine("안녕하십니까~");
        }

        // 다형성 -> 메서드의 오버로드
        public void Greet(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    // 정적클래스: 객체화 하지 않아도 사용 가능한 클래스
    // : 알고리즘, 방법이 있는 메서드를 보관용.
    //public static class Util
    //{
    //    public static int Add(int a, int b)
    //    {
    //        return a + b;
    //    }
    //}

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Walk()
        {

        }
        public void Run()
        {

        }
        public void Sleep()
        {

        }
    }

    // 고양이(Cat) 클래스: 동물(Animal)의 기능을 이어받아 만든 고양이 설명서입니다.
    // 'Cat : Animal'은 고양이가 동물의 한 종류임을 컴퓨터에게 알려주는 것입니다.
    public class Cat : Animal
    {
        // 고양이가 어떤 종류(품종)인지 저장하는 곳입니다. (예: 페르시안, 샴 등)
        public string Breed { get; set; }

        // 새로운 고양이를 만들 때(태어날 때) 이름과 나이를 정해주는 과정입니다.
        public Cat(string name, int age) : base(name, age)
        {
            // 동물로서의 기본 정보(이름, 나이)를 설정합니다.
            base.Name = name;
            base.Age = age;

            // 고양이가 태어나자마자 기분이 좋아서 소리를 냅니다.
            Growl();
        }

        // 고양이가 기분 좋을 때 내는 '그르릉' 소리 기능을 정의합니다.
        public void Growl()
        {
            Console.WriteLine("그르릉...");
        }
    }

    public class Vehicle
    {
        public virtual void Honk()
        {
            Console.WriteLine("경적을 울립니다.");
        }
    }

    public class Car : Vehicle
    {
        // 다형성
        // 재정의: virtual - override 는 필수가 아닌 선택
        public override void Honk()
        {
            base.Honk();

            Console.WriteLine("빵빵");
        }
    }

    // abstract 클래스: 실제 구현이 없는 기능만 정의한 탬플릿 형태의 클래스
    //                  자식 클래스는 실제 구현을 필수적으로 해야함.
    //                  추상클래스는 객체화 못함.
    // 재정의2 - abstract - override
    // ex) 전화하기, 문자하기, 알람
    public abstract class Galaxy
    {
        public abstract void Call();
        public abstract void SendMessage();
        public abstract void Alarm();
    }

    public class GalaxyS26 : Galaxy
    {
        public override void Alarm()
        {
            
        }

        public override void Call()
        {
            
        }

        public override void SendMessage()
        {
            
        }

        public virtual void PrivacyDisplay()
        {

        }
    }

    internal class ClassStudy
    {
        static void Main43()
        {
            // Object, 객체 or 인스턴스
            Person person = new Person("신태욱", 20); // 참조형 -> 객체화, 인스턴싱
            //person.name = "신태욱";
            //person.age = 20;
            //person.Greet("안녕하세요. 저는 " + person.name + "이고, " + person.age + "살 입니다.");

            Person person2 = new Person();
            person2.Name = "김흥수";
            person2.age = 25;
            person2.Greet();

            //int sum = Util.Add(6, 10);
            //Console.WriteLine("sum: " + sum);

            Cat cat = new Cat("별이", 8);
            cat.Sleep();

            // 면접용 프리미엄 계산기를 실행하려면 아래 주석을 해제하세요.
            // PremiumCalculator.Start();
        }
    }
}
