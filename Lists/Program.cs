namespace Lists
{
    internal class Program
    {
        // Problem 1: Temperature Log 
        public static void Temp()
        {

            {
                List<double> temperatures = new List<double> { 48.3, 40.5, 43.9, 50.1, 44.1, 30.3, 40.9 };
                for (int i = 0; i < temperatures.Count; i++) 
                {
                    Console.Write("The temperature for day " + (i + 1) + " is: ");
                    Console.WriteLine(temperatures[(int)i]);
                }

            }
        }
        // Problem 2: Student Score Board
        public static void Score()
        {
            List<int> scores = new List<int>();
            scores.AddRange(new int[] { 54, 86, 44, 76, 87, 61 });

            foreach (int number in scores)
            {
                Console.Write("The score of the student: ");
                Console.WriteLine(number);
            }
        }

        // Problem 3: Product Price Finder 
        public static void price()
        {
            List<double> prices = new List<double>();
            prices.AddRange(new double[] { 7.5, 6, 3.8, 9, 4 });

            for (int i = 0; i < prices.Count; i++)
            {
                Console.Write("Price of the product " + (i + 1) + " is: ");
                Console.WriteLine(prices[i] + " OMR");
            }

            double target = 3.8;
            int index = prices.IndexOf(target);

            if (index != -1)
            {
                Console.WriteLine("Price " + target + " found at index " + index + " (Product " + (index + 1) + "). ");
            }
            else
            {
                Console.WriteLine("Price " + target + " not found.");
            }
        }
        }
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)

            {
                Console.WriteLine("  Please select from the main menu");
                Console.WriteLine();
                Console.WriteLine("   1) Temperature Log ");
                Console.WriteLine("   2) Student Score Board");
                Console.WriteLine("   3) Product Price Finder  ");
                Console.WriteLine("   4) Race Finish Times ");
                Console.WriteLine("   5) Classroom Grade Report ");
                Console.WriteLine("   6) Warehouse Inventory Check");
                Console.WriteLine("   7) Library Book Shelf Scanner");
                Console.WriteLine("   8) Sales Performance Analyzer");
                Console.WriteLine("   9) Flight Seat Allocation Displayk");
                Console.WriteLine("   10) Hospital Patient Priority Queue ");
                Console.WriteLine("   0) Exit");

                Console.Write("Select: ");

                int Select = int.Parse(Console.ReadLine());

                switch (Select)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("Goodbye!");
                        break;

                    case 1:
                        Temp();
                        break;
                    case 2:
                        Score();
                        break;

                    case 3:
                        price();
                        break;

                    case 4:

                    case 5:

                    case 6:

                    case 7:

                    case 8:

                    case 9:

                    case 10:

                    case 11:

                    default:
                        Console.WriteLine("Invalid option. Please select a valid number.");
                        break;

                }
            }
        }
    }
}
