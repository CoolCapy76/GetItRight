using System;


    class Program
    {

        

        static void Main(string[] args)
        {
        double check = 0;
        double sum;
        Console.WriteLine("Enter equation in the format: num1 operator num2 (example: 1 + 1)");
        string input = Console.ReadLine();
        string[] inputs = input.Split(" ");
        double num1 = Convert.ToDouble(inputs[0]);
        string op = inputs[1];
        double num2 = Convert.ToDouble(inputs[2]);


        switch (op)
        {
            case "+":
                sum = num1 + num2;
                Console.WriteLine("The result is " + sum);
                break;

            case "-":
                sum = num1 - num2;
                Console.WriteLine("The result is " + sum);
                break;

            case "*":
                sum = num1 * num2;
                Console.WriteLine("The result is " + sum);
                break;

            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    sum = num1 / num2;
                    Console.WriteLine("The result is " + sum);
                }
                break;

            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}
    

