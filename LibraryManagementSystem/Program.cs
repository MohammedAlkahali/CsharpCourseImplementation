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
        //static bool isBookRegistered = false;
        static int totalBooksBorrowedThisSession = 0;
        static int totalFinesPaidThisSession = 0;
       
        //////////////////////////////////////////////////


        // Function to check if the user registered or not
        public static bool CheckIsRegistered() //(True=yes , false=no)
        {
            if (isMemberRegistered == true) //-> Check if the member registered or not 
            {
                Console.WriteLine("The member registered");
                return true;
            }
            else if(isMemberRegistered == false)
            {
                Console.WriteLine("No member profile found");
                return false;
            }
            else
                return false;
        }



        //Function to register a new member
        public static void RegisterMember()
        {
            Console.Write("Enter the member name: ");
            memberName = Console.ReadLine();

            Console.Write("Enter the member ID: ");
            memberID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the member email: ");
            memberEmail = Console.ReadLine();

            Console.Write("Enter membership expiry date: ");
            membershipExpiryDate = Console.ReadLine();

            Console.Write("Enter the member tier: ");
            memberTier = Convert.ToInt32(Console.ReadLine());

            isMemberRegistered = true;
            Console.WriteLine("The member registered successfully");
            Console.WriteLine();
        }



        // Function to display a the member profile
        public static void DisplayProfile()
        {
            Console.WriteLine("The Member Name: " + memberName.PadLeft(1));
            Console.WriteLine("The Member ID: " + memberID);
            Console.WriteLine("The Member Email: " + memberEmail.PadLeft(1));
            Console.WriteLine("The membership expiry date: " + membershipExpiryDate);
            Console.WriteLine("The Member Tier: " + memberTier);
            Console.WriteLine("Exit");
           
        }


        // Function to Check the name of the book 
        public static bool BookSearchTitle (string SearchBook)
        {
            if  (SearchBook == bookTitle)
            {
                return true;
            }
            else
                return false;
        }

        // Function to search the book 
        public static void RegisterBook()
        {
            Console.WriteLine("Write the name of the book: ");
            bookTitle = Console.ReadLine();

        }


        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)

            {           // Display the main menu for the user to choose

                Console.WriteLine("Welcome to library management system.");
                Console.WriteLine("  Please select from the main menu");
                Console.WriteLine();
                Console.WriteLine("   1) Register a new member");
                Console.WriteLine("   2) Display the member profile");
                Console.WriteLine("   3) Search book by title");
                Console.WriteLine("   4) Borrow a book");
                Console.WriteLine("   5) Return a book");
                Console.WriteLine("   6) Calculate late fine");
                Console.WriteLine("   7) Applying discount for a member");
                Console.WriteLine("   8) Check the borrowing eligibility");
                Console.WriteLine("   9) Register a book");
                Console.WriteLine("   10) Generate ID for a member");
                Console.WriteLine("   11) Display book details");
                Console.WriteLine("   12) Calculate renewal fee");
                Console.WriteLine("   13) Update the email for a member");
                Console.WriteLine("   14) The member details summary");
                Console.WriteLine("   0) Exit");
                Console.Write("Select: ");
               
                int Select = int.Parse(Console.ReadLine());

                switch (Select)
                {
                    // For registering a new member
                    case 1:
                        bool checkRegisteredResult = CheckIsRegistered();

                        if(checkRegisteredResult == false)
                        {
                            RegisterMember();
                        }
                        break;

                    // To display the member profile
                    case 2:
                        checkRegisteredResult = CheckIsRegistered();

                        if (checkRegisteredResult == true)
                            {
                                DisplayProfile();
                            }
                        break;
                        

                    case 3:

                        Console.WriteLine("Enter the book title");

                        if (BookSearchTitle(Console.ReadLine())== true)
                        {
                            Console.WriteLine("The book found");
                        }
                        else
                        {
                            Console.WriteLine("The book not found");
                        }
                        break;



                    case 4:
                        break;





                    case 5:
                        break;





                    case 6:
                        break;





                    case 7:
                        break;





                    case 8:
                        break;





                    case 9:
                        break;





                    case 10:
                        break;





                    case 11:
                        break;





                    case 12:
                        break;





                    case 13:
                        break;





                    case 14:
                        break;





                    case 15:
                        break;




      
                } // Switch (Select)

                
            } // While loop

            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
            Console.Clear(); // clear the console for better user experience

        } // static main
    } // class program
} // namespace
