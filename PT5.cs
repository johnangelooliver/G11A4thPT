using System;

namespace IntroToCSG11 //<-- Name of your solution/project
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("[1] Addition");
            Console.WriteLine("[2] Subtraction");
            Console.WriteLine("[3] Multiplication");
            Console.WriteLine("[4] Division");
            Console.Write("Enter Choice: ");
            var choice = Console.ReadLine();
            switch (Convert.ToInt32(choice))
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Good Bye!");
                    break;
            }
            Console.ReadLine();
        }

        private static void Addition()
        {
            Console.Write("Enter 1st Number: ");
            var num1 = Console.ReadLine();
            Console.Write("Enter 2nd Number: ");
            var num2 = Console.ReadLine();
            Console.WriteLine("The result of " + num1 + " and " + num2 + " is " + PerformOperation(int.Parse(num1), int.Parse(num2), '+'));
        }
        
        private static void Subtraction()
        {
            Console.Write("Enter 1st Number: ");
            var num1 = Console.ReadLine();
            Console.Write("Enter 2nd Number: ");
            var num2 = Console.ReadLine();
            Console.WriteLine("The result of " + num1 + " and " + num2 + " is " + PerformOperation(int.Parse(num1), int.Parse(num2), '-'));
        }
        
        private static void Multiplication()
        {
            Console.Write("Enter 1st Number: ");
            var num1 = Console.ReadLine();
            Console.Write("Enter 2nd Number: ");
            var num2 = Console.ReadLine();
            Console.WriteLine("The result of " + num1 + " and " + num2 + " is " + PerformOperation(int.Parse(num1), int.Parse(num2), '*'));
        }
        
        private static void Division()
        {
            Console.Write("Enter 1st Number: ");
            var num1 = Console.ReadLine();
            Console.Write("Enter 2nd Number: ");
            var num2 = Console.ReadLine();
            Console.WriteLine("The result of " + num1 + " and " + num2 + " is " + PerformOperation(int.Parse(num1), int.Parse(num2), '/'));
        }

        private static int PerformOperation(int num1, int num2, char operation)
        {
            var result = 0;
            if (operation == '+')
                result = num1 + num2;
            else if (operation == '-')
                result = num1 - num2;
            else if (operation == '*')
                result = num1 * num2;
            else if (operation == '/') result = num1 / num2;
            
            return result;
        }
    }
}
