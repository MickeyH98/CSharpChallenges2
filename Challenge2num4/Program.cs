using System;

namespace Challenge2num4
{
	public class Car
	{
		public int NumberOfTires { get; set; }
		public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
        public string Type { get; set; }
	}

    class Program
    {
        static void Main(string[] args)
        {
			var dreamCar = new Car()
			{
				NumberOfTires = 4,
				Year = 2018,
				Make = "Lamborghini",
				Model = "Aventador",
                Type = "Coupe"
			};

			var hateCar = new Car()
			{
				NumberOfTires = 4,
				Year = 2008,
				Make = "Toyota",
				Model = "Prius",
				Type = "Sedan"
			};

			bool repeat = true;
            while (repeat)
            {
                Console.Clear();
				Console.WriteLine("Would you like to see a car I love or a car I hate?");
				Console.WriteLine("( Love / Hate )");
				string userInput = Convert.ToString(Console.ReadLine()).ToLower();

				if (userInput == "love")
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("I would LOVE a ");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(dreamCar.Year);
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write(" " + dreamCar.Make + " ");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Write(dreamCar.Model);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write(" which is a ");
					Console.ForegroundColor = ConsoleColor.Magenta;
					Console.Write(dreamCar.Type);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write(" and has ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write(dreamCar.NumberOfTires);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write(" tires.");

                    Console.Write(Environment.NewLine);

                    Console.WriteLine("It looks a little something like this: ");

                    Console.Write(Environment.NewLine);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("                              _.-=\"_-         _");
                    Console.WriteLine("                         _.-=\"   _-          | ||\"\"\"\"\"\"\"---._______     __..");
                    Console.WriteLine("             ___.===\"\"\"\"-.______-,,,,,,,,,,,,`-''----\" \"\"\"\"\"       \"\"\"\"\"  __'");
                    Console.WriteLine("      __.--\"\"     __        ,'                   o \\           __        [__|");
                    Console.WriteLine(" __-\"\"=======.--\"\"  \"\"--.=================================.--\"\"  \"\"--.=======:");
                    Console.WriteLine("]       [w] : /        \\ : |========================|    : /        \\ :  [w] :");
                    Console.WriteLine("V___________:|          |: |========================|    :|          |:   _-\"");
					Console.WriteLine(" V__________: \\        / :_|=======================/_____: \\        / :__-\"");
					Console.WriteLine(" -----------'  \"-____-\"  `-------------------------------'  \"-____-\"");
                    Console.ForegroundColor = ConsoleColor.White;
                }
				else if (userInput == "hate")
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("I would HATE a ");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(hateCar.Year);
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write(" " + hateCar.Make + " ");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Write(hateCar.Model);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write(" which is a ");
					Console.ForegroundColor = ConsoleColor.Magenta;
					Console.Write(hateCar.Type);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write(" and has ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write(hateCar.NumberOfTires);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write(" tires.");

					Console.Write(Environment.NewLine);

					Console.WriteLine("It looks a little something like this: ");

                    Console.Write(Environment.NewLine);

                    Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine(@"   -           __                 ");
					Console.WriteLine(@" --          ~( @\   \            ");
					Console.WriteLine(@"---   _________]_[__/_>________   ");
					Console.WriteLine(@"     /  ____ \ <>     |  ____  \  ");
					Console.WriteLine(@"    =\_/ __ \_\_______|_/ __ \__D ");
					Console.WriteLine(@"________(__)_____________(__)_____");
                    Console.ForegroundColor = ConsoleColor.White;
				}
				else
				{
					continue;
				}

                Console.Write(Environment.NewLine);

                Console.WriteLine("Would you like to see the other? ( Y / N )");
                string userContinue = Convert.ToString(Console.ReadLine()).ToUpper();

                if(userContinue == "Y")
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

//4. Make a class Vehicle with the properties Type, NumberOfTires, Year, and Model.
//Then write a constructor that takes in those 4 properties as parameters and sets the values of the properties.
//Once your constructor is complete create two instances of Vehicle, 
//the first one should be your dream car and 
//the second should be your i would hate car. 
//Finally display the model of your dream car and the model of your hate car.