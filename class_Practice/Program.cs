using System;
using class_Practice.Models;

namespace Class_ProductBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter quantity: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Book[] arr = new Book[length];

            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write("Genre: ");
                string Genre = Console.ReadLine();

                Console.Write("No: ");
                int No = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                string Name = Console.ReadLine();

                Console.Write("Price: ");
                int Price = Convert.ToInt32(Console.ReadLine());

                Console.Write("Count: ");
                int Count = Convert.ToInt32(Console.ReadLine());
                arr[i] = new Book(Genre, No, Name, Price, Count);
                Console.WriteLine("ⓘ Item created succesfully");

            }
            Console.WriteLine();
            Console.Write("Press Enter to see options.");
            Console.ReadLine();
            Console.WriteLine(" 1.Filter books by price range\n 2.Show all books.\n 0.Terminate program");


            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    double minPrice = GetInputDouble("Min. price:",-1);
                    double maxPrice = GetInputDouble("Max. price:",0);
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i].Price <= maxPrice && arr[i].Price > minPrice)
                            {
                                Console.WriteLine($"No: {arr[i].No} ");
                                Console.WriteLine($"Name: {arr[i].Name} ");
                                Console.WriteLine($"Price: {arr[i].Price}");
                                Console.WriteLine($"Genre: {arr[i].Genre}");
                            }
                        }
                              break;

                case 2:

                        for (int i = 0; i < arr.Length; i++)
                        { 
                            Console.WriteLine($"No: {arr[i].No} ");
                            Console.WriteLine($"Name: {arr[i].Name} ");
                            Console.WriteLine($"Price: {arr[i].Price}");
                            Console.WriteLine($"Genre: {arr[i].Genre}");
                        }
                              break;



                case 0:
                            Console.WriteLine("**********************");
                            Console.WriteLine("Program was terminated");
                            Console.WriteLine("**********************");
                    break;
            }
            static double GetInputDouble(string text,double min, double max = int.MaxValue)
            {
                double input;
                do
                {

                    Console.WriteLine(text);
                    input = Convert.ToDouble(Console.ReadLine());
                }
                while (input < min || input > max);

                return input;
            }
        }
    }
}