namespace Lists
{
    internal class Program
    {
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

                }
            }
        }
    }
}
