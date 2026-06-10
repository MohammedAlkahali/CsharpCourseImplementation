namespace Arrays
{
    internal class Program
    {

        // Problem 1: Temperature Log 
        public static void Temp()
        {

            {
                double[] temperatures = { 48.3, 40.5, 43.9, 50.1, 44.1, 30.3, 40.9 };
                for (double i = 0; i < temperatures.Length; i++)
                {
                    Console.Write("The temperature for day " + (i + 1) + " is: ");
                    Console.WriteLine(temperatures[(int)i]);
                }

            }
        }




        // Problem 2: Student Score Board
        public static void Score()
        {
            int[] scores = { 54, 86, 44, 76, 87, 61 };

            foreach (int i in scores)
            {

                {
                    Console.Write("The score of the student ");
                    Console.WriteLine(i);

                }

                Array.Reverse(scores);
                Console.WriteLine(scores);

            }

        }




        // Problem 3: Product Price Finder 
        public static void price()
        {
            double[] prices = { 7.5, 6, 3.8, 9, 4 };

            for (int i = 0 ; i < prices.Length ; i++)
            {
                Console.Write("Price of the product " + (i + 1) + " is: ");
                Console.WriteLine(prices[i] + " OMR");

            }


            int index = Array.IndexOf(prices, 9);
            Console.WriteLine("The index of the number 9 is " + index);
        }




        // Problem 4: Race Finish Times
        public static void Race()
        {
            int[] finishTimes = { 18, 19, 17, 16, 20, 22, 14, 15 };

            foreach (int i in finishTimes)
            {
                Console.Write("The record of the race finish times is : ");
                Console.WriteLine(i);
            }

                Array.Sort(finishTimes);
                Console.WriteLine("The sorted numbers are " + finishTimes);

        }




        // Problem 5: Classroom Grade Report  
        public static void Grade()
        {
            int[] grades = { 88, 76, 90, 63, 80, 89, 69, 72, 92, 83 };
            Array.Sort(grades);
            Array.Reverse(grades);
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("The rank " + (i + 1) + " is: ");
                Console.WriteLine(grades[i]);
            }
        }





        // Problem 6: Warehouse Inventory Check 
        public static void Quantity()
        {
            int[] quantities = { 3, 2, 8, 5, 4, 9, 1, 6 };
            int Total = 0;
            for (int i = 0; i < quantities.Length; i++)
            { 
                Total = Total + quantities[i];  
            }

            Console.WriteLine($"The total is: " + Total);


            double average = (double)Total / quantities.Length;
            Console.WriteLine($"Average stock per slot: {average}");



        }




        // Problem 7: Library Book Shelf Scanner
        public static void Copy()
        {
            int[] copies = { 10, 12, 17, 8, 7, 20, 5, 19, 11 };

            foreach (int i in copies)
            {
                Console.Write("The copies available: ");
                Console.WriteLine(i);
                
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
                            Race();
                            break;
                        case 5:
                            Grade();
                            break;
                        case 6:
                            Quantity();
                            break;
                        case 7:
                            Copy();
                            break;
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
