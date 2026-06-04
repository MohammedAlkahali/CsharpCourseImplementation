namespace Stack_Queue
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
                Console.WriteLine("   1) Browser History Tracker                     ");
                Console.WriteLine("   2) Hotel Check-In Queue                        ");
                Console.WriteLine("   3) Text Editor Undo System                     ");
                Console.WriteLine("   4) Hospital Emergency Room Triage              ");
                Console.WriteLine("   5) Parenthesis Validator                       ");
                Console.WriteLine("   6) Print Spooler with Priority Re-Insertion    ");
                Console.WriteLine("   7) Reverse a Sentence Word by Word             ");
                Console.WriteLine("   8) Multi-Level Undo with Redo                  ");
                Console.WriteLine("   9) Ticket Counter Simulation                   ");
                Console.WriteLine("   10) Order Processing Pipeline with Statistics  ");
                Console.WriteLine("   0) Exit                                        ");

                Console.Write("Select: ");

                int Select = int.Parse(Console.ReadLine());
        }
    }
}
