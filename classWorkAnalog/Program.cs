using System;
using classWorkAnalog.Models;
namespace classWorkAnalog
{
    class Program
    {
        public static bool GetInfo { get; private set; }

        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Apple", "Macbook Air", 8, 512, 999, 1);
            notebook.GetInfo();
            Console.WriteLine("Enter count:");
            string input = Console.ReadLine();
            int notebook_count = Convert.ToInt32(input);

            Notebook[] notebooks = new Notebook[notebook_count];

            for (int i = 0; i < notebook_count; i++)
            {
                Console.WriteLine("brandName:");
                string brandname = Console.ReadLine();

                Console.WriteLine("model:");
                string model = Console.ReadLine();

                Console.WriteLine("ram:");
                int ram = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("storage:");
                int storage = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("price:");
                int price = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("count:");
                int count = Convert.ToInt32(Console.ReadLine());

                notebooks[i] = new Notebook(brandname, model, ram, storage, price, count);
                Console.WriteLine("notebook created");
            }

            foreach (var item in notebooks)
            {
                Console.WriteLine(item.brandname);
            }
        }
    }
}