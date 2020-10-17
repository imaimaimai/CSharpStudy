using System;

namespace partial
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(10, 10);

            Console.WriteLine(c.Abs());
        }
    }

    public partial class Complex
    {
        public double Abs()
        {
            return Math.Sqrt(re * re + im * im);
        }
    }
}


