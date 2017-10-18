using System;

namespace Challenges2
{
    class Program
    {
		public static double Divider(int num1, int num2)
		{
			double result = num1 / num2;
			return result;
		}

		public static double Multiplier(int num1, int num2)
		{
			double result = num1 * num2;
			return result;
		}

        public static double Adder(int num1, int num2)
        {
            double result = num1 + num2;
			return result;
		}

		public static double Subtractor(int num1, int num2)
		{
			double result = num1 - num2;
			return result;
		}

        static void Main(string[] args)
        {
			bool repeat = true;
            int num1;
            string operation;
            int num2;

            Console.WriteLine("Calculator App Initialized");

            while (repeat)
            {
				Console.Write(Environment.NewLine);

				Console.WriteLine("Please enter a number.");
                Console.ForegroundColor = ConsoleColor.Red;
                try
                {
					num1 = Convert.ToInt32(Console.ReadLine());
				}
                catch(Exception)
                {
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please enter an operation. ( +  -  *  / )");
                Console.ForegroundColor = ConsoleColor.White;
				try
				{
					operation = Convert.ToString(Console.ReadLine());

				}
				catch (Exception)
				{
					continue;
				}

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please enter a second number");
                Console.ForegroundColor = ConsoleColor.Blue;
				try
				{
					num2 = Convert.ToInt32(Console.ReadLine());

				}
				catch (Exception)
				{
					continue;
				}

                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = Adder(num1, num2);
                        break;
                    case "-":
                        result = Subtractor(num1, num2);
                        break;
                    case "*":
                        result = Multiplier(num1, num2);
                        break;
                    case "/":
                        result = Divider(num1, num2);
                        break;
                    default:
                        continue;
                }

				//Console.Write(Environment.NewLine);

				//Console.WriteLine(num1 + " " + operation + " " + num2 + " = " + result);

				Console.Write(Environment.NewLine);

                Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(num1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" " + operation + " ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(num2);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" = ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(result);

                Console.Write(Environment.NewLine);

                Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Want to make another calculation? Y / N");
                string againInput = Console.ReadLine().ToUpper();

                if (againInput == "Y")
                {
                    continue;
                }
				else
				{
                    Console.WriteLine("Okay, see ya!");
                    repeat = false;
				}
            }
        }
    }
}

//1. Write a method that divides two numbers(provided as parameters). 
//Tip: you will need to use the modifiers public and static. Do not hardcode the two numbers.