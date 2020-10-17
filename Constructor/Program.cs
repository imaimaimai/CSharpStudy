using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Jiro", -90);

            Console.WriteLine($"{p1.name}さん、{p1.age}歳");
            Console.WriteLine($"{p2.name}さん、{p2.age}歳");
        }
    }
}
