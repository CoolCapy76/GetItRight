using System;

class Program
{
    static void Main(string[] args)
    {
        int check = 0;
        int sum = 0;
        Console.WriteLine("Enter equation in the format 'a sign b' (e.g. 2 + 3)");
        string equation = Console.ReadLine();
        string[] parts = equation.Split(" ");
        int a = Convert.ToInt32(parts[0]);
        string sign = parts[1];
        int b = Convert.ToInt32(parts[2]);

        if (sign == "+")
        {
            sum = a + b;
            Console.WriteLine("Now Enter the asnwer");
            while (check != sum)
            {
                check = Convert.ToInt32(Console.ReadLine());
                if (check == sum) { break; }
                else { Console.WriteLine($"{check} is not right,try again"); }
            }
            Console.WriteLine($"{check} is right,you did it");
        }

        if (sign == "-")
        {
            sum = a - b;
            if (a - b < 0) { Console.WriteLine("Now Enter the asnwer and dont forget the minus"); }
            else { Console.WriteLine("Now Enter the asnwer"); }
            while (check != sum)
            {
                check = Convert.ToInt32(Console.ReadLine());
                if (check == sum) { break; }
                else { Console.WriteLine($"{check} is not right,try again"); }
            }
            Console.WriteLine($"{check} is right,you did it");
        }

        if (sign == "*")
        {
            sum = a * b;
            Console.WriteLine("Now Enter the asnwer");
            while (check != sum)
            {
                check = Convert.ToInt32(Console.ReadLine());
                if (check == sum) { break; }
                else { Console.WriteLine($"{check} is not right,try again"); }
            }
            Console.WriteLine($"{check} is right,you did it");
        }

        if (sign == "/")
        {
            try { sum = a / b; }

            catch (DivideByZeroException) {
                Console.WriteLine("can not divide by zero,restart program");
                Environment.Exit(0);
            }

            Console.WriteLine("Now Enter the asnwer");
            while (check != sum) {
                check = Convert.ToInt32(Console.ReadLine());
                if (check == sum) { break; }
                else { Console.WriteLine($"{check} is not right,try again"); }
            }
            Console.WriteLine($"{check} is right,you did it");
        }

    }

}  