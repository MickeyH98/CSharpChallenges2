using System;

namespace Challenge2
{
    public class Car 
    {
        public int NumberOfTires { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var car1 = new Car()
            {
                NumberOfTires = 3,
                Year = 1990,
                Make = "Honda",
                Model = "Civic"
            };

            var car2 = new Car()
            {
                NumberOfTires = 4,
                Year = 2016,
                Make = "Toyota",
                Model = "Corolla"
            };

            var car3 = new Car()
            {
                NumberOfTires = 4,
                Year = 2018,
                Make = "Lamborghini",
                Model = "Aventador"
            };

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("The ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(car1.Year);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" " + car1.Make + " ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(car1.Model);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" has ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(car1.NumberOfTires);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" tires.");

            Console.WriteLine(Environment.NewLine);

			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("The ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(car2.Year);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(" " + car2.Make + " ");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write(car2.Model);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(" has ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(car2.NumberOfTires);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(" tires.");

			Console.WriteLine(Environment.NewLine);

			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("The ");
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(car3.Year);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write(" " + car3.Make + " ");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write(car3.Model);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(" has ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write(car3.NumberOfTires);
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(" tires.");

            Console.Write(Environment.NewLine);
			Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Would you like to create your own car? ( Y / N )");
            string userInput = Convert.ToString(Console.ReadLine()).ToUpper();

            if(userInput == "Y"){
                bool repeat = true;
                while(repeat){
                    Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("Please enter your car's Make:");
                    Console.ForegroundColor = ConsoleColor.Green;
					string userMake = Convert.ToString(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("Please enter your car's Model:");
                    Console.ForegroundColor = ConsoleColor.Blue;
					string userModel = Convert.ToString(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("Please enter your car's Year:");
                    Console.ForegroundColor = ConsoleColor.Red;
					int userYear = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("How many tires does your car have?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
					int userTires = Convert.ToInt32(Console.ReadLine());

					var userCar = new Car()
					{
						NumberOfTires = userTires,
                        Make = char.ToUpper(userMake[0]) + userMake.Substring(1), //capitalize 1st char
                        Model = char.ToUpper(userModel[0]) + userModel.Substring(1), //capitalize 1st char
						Year = userYear,
					};

                    Console.Write(Environment.NewLine);

					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("The ");
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(userCar.Year);
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write(" " + userCar.Make + " ");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Write(userCar.Model);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write(" has ");
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write(userCar.NumberOfTires);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write(" tires.");

					Console.Write(Environment.NewLine);

					Console.WriteLine("Would you like to create another car? ( Y / N )");
					string continueAnswer = Convert.ToString(Console.ReadLine()).ToUpper();
					if (continueAnswer == "Y")
					{
						repeat = true;
					}
					else
					{
                        Console.WriteLine("Okay, see ya!");
                        repeat = false;
					}
                }
			}else {
                Console.WriteLine("Fine, dont let the door hit you on the way out.");
            }
        }
    }
}

//2. Make a class car with the properties numberOfTires = 4, year = 2017, 
//and model = "insert your model of choice", and create three instances of it: car1, car2, and car3.