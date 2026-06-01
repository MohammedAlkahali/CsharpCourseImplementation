namespace Arrays
{
    internal class Program
    {

        // Problem 1: Temperature Log 
        public static void temp()
        {

            {
                double[] temperatures = new double[] { 48.3, 40.5, 43.9, 50.1, 44.1, 30.3, 40.9 };
                for (double i = 0; i < temperatures.Length; i++)
                {
                    Console.Write("The temperature for day " + (i + 1) + " is: ");
                    Console.WriteLine(temperatures[(int)i]);
                    
                }

            }
        }
        {
            Console.WriteLine("Hello, World!");
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
                        temp();


                        break;
                    case 2:
                    case 3:
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

                } // Switch
            } // While
        } // Main
    } // Program
} // Namespace