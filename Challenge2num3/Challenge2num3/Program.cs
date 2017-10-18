using System;
using System.Collections.Generic;

namespace Challenge2num3
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, int> r2h = new Dictionary<string, int>
            {
                { "Angel", 19 },
                { "Juan", 19 },
                { "Hunter", 19 },
                { "Britanny", 23 },
                { "Chris", 21 },
                { "Markus", 18 },
                { "Mickey", 19 },
                { "Malik", 21 },
                { "Victoria", 23 },
                { "Ivan", 18 },
                { "Miguel", 21 },
                { "Lesly", 18 },
                { "Ian", 20 },
                { "Teia", 23 },
                { "Lynnette", 19 }
            };

            Console.WriteLine("There are " + r2h.Count + " students in our class.");

            Console.Write(Environment.NewLine);

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var student in r2h)
			{
				Console.Write(student.Key + " ");
			}
            Console.ForegroundColor = ConsoleColor.White;

            r2h.Remove("Lynnette");

            Console.WriteLine(Environment.NewLine);

            Console.Write("Wait,");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Lynnette ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("isnt in our class!");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("After she got kicked out there are " + r2h.Count + " students left.");

			foreach (var student in r2h)
			{
                if(student.Key == "Mickey")
                {
                    Console.Write(Environment.NewLine);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(student.Key);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" is " + student.Value + " years old.");
                }
			}

			bool repeat = true;
            while (repeat)
            {
                Console.Write(Environment.NewLine);
				Console.WriteLine("Would you like to know another student's age? ( Y / N )");
				string userInput = Convert.ToString(Console.ReadLine()).ToUpper();

                if (userInput == "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Who's age would you like to know? Here are all the students names: ");

                    Console.Write(Environment.NewLine);

                    Console.ForegroundColor = ConsoleColor.Yellow;
					foreach (var student in r2h)
					{
						Console.Write(student.Key + " ");
					}
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine(Environment.NewLine);

                    string studentSearch = Convert.ToString(Console.ReadLine()).ToLower();
					foreach (var student in r2h)
					{
						if (student.Key.ToLower() == studentSearch)
						{
							Console.Write(Environment.NewLine);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(student.Key);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" is " + student.Value + " years old.");
						}
					}
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

//3. Create a new dictionary called roadtohire that holds yourself, name and age(example "Nancy", 22). 
//Add each student in your class to the dictionary, as well as a random student, and display your total number of students.
//Once you have done that remove the random student from your roadtohire dictionary, and display your current number of students.
//Finally find yourself in the dictionary and display your name and your age.
