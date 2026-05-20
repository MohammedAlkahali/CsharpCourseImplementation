namespace LibraryManagementSystem
{
    internal class Program
    {
        // Declare all the variables as a static above the main so functions share access.

        static string memberName = "";
        static int memberID = 0;
        static string memberEmail = "";
        static string membershipExpiryDate = "";
        static int memberTier = 0;
        static string bookTitle = "";
        static string bookAuthor = "";
        static string bookGenre = "";
        static int numAvailableCopies = 0;
        static bool isMemberRegistered = false;
        static bool isBookRegistered = false;
        static int totalBooksBorrowedThisSession = 0;
        static int totalFinesPaidThisSession = 0;
        //////////////////////////////////////////////////
        

        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)

            {           // Display the main menu for the user to choose

                Console.WriteLine("Hello and welcome to library management system.");
                Console.WriteLine("      Please select from the main menu");
                Console.WriteLine();
                Console.WriteLine("     1) Register a new member");
                Console.WriteLine("     2) Display the member profile");
                Console.WriteLine("     3) Search book by title");
                Console.WriteLine("     4) Borrow a book");
                Console.WriteLine("     5) Return a book");
                Console.WriteLine("     6) Calculate late fine");
                Console.WriteLine("     7) Applying discount for a member");
                Console.WriteLine("     8) Check the borrowing eligibility");
                Console.WriteLine("     9) Register a book");
                Console.WriteLine("     10) Generate ID for a member");
                Console.WriteLine("     11) Display book details");
                Console.WriteLine("     12) Calculate renewal fee");
                Console.WriteLine("     13) Update the email for a member");
                Console.WriteLine("     14) The member details summary");
                Console.WriteLine();
                Console.Write("Select: ");
                int Select = int.Parse(Console.ReadLine());

            } // While loop
        } // static main
    } // class program
} // namespace
