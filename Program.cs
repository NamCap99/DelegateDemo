using System;

namespace MyApp
{
    public class Program
    {
        public static int Sum(int a, int b) => a + b;
        public static int Substract(int a, int b) => a - b;

        public static void Info()
        {
            Console.WriteLine("Action in delegate");
        }
        public static void Main(string[] args)
        {
            Action action;

            action = Info;

            action?.Invoke();
            // action ? (); // starting in C# 9

            Func<int, int, int> cal;
            int a = 10;
            int b = 5;

            cal = Sum;
            int result = cal(a, b);
            cal = Substract;
            int result2 = cal(a, b);
            System.Console.WriteLine($"Sum is {result}");
            System.Console.WriteLine($"Sum is {result2}");

        }
    }
}