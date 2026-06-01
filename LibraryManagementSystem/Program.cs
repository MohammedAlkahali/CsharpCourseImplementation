namespace LibraryManagementSystem
{
    internal class Program
    {
        // Declare all the variables as a static above the main so functions share access.

        static string memberName = "";
        static int memberID = 0;
        static string memberEmail = "";
        static string membershipExpiryDate = "";
        static string memberTier = "gold";
        static string bookTitle = "";
        static string bookAuthor = "";
        static string bookGenre = "";
        static int numAvailableCopies = 0;
        static bool isMemberRegistered = false;
        static bool isBookRegistered = false;
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
                Console.WriteLine("There is no profile information, please register");
                return false;
            }
            else
                return false;
        }




        // Function to register a new member
        public static void RegisterMember()
        {
            if (isMemberRegistered == false)
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
                memberTier = Console.ReadLine();

                isMemberRegistered = true;
                Console.WriteLine("The member registered successfully");
                Console.WriteLine();
            }
            
        }




        // Function to display a the member profile
        public static void DisplayProfile()
        {
            Console.WriteLine("The Member Name: " + memberName.PadLeft(1));
            Console.WriteLine("The Member ID: " + memberID.ToString());
            Console.WriteLine("The Member Email: " + memberEmail.PadLeft(1));
            Console.WriteLine("The membership expiry date: " + membershipExpiryDate.ToString());
            Console.WriteLine("The Member Tier: " + memberTier.ToString());
            Console.WriteLine("Exit" );
           
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
            Console.Write("Write the title of the book: "); 
        }




        // To reduces available copies by 1
        public static void BorrowBook(ref int copies)
        {
            if (copies > 0)
            {
                copies = Math.Max(copies - 1, 0);
                totalBooksBorrowedThisSession++;
                Console.WriteLine("Book borrowed successfully. Copies remaining: " + copies);
            }
            else
            {
                Console.WriteLine("No copies available to borrow.");
            }
        }




        // Function to return a book
        public static void ReturnBook(ref int copies)
        {
            copies = Math.Min(copies + 1, 99);
            Console.WriteLine("Book returned successfully. Copies now available: " + copies);
        }




        // To calculate the late fine
        public static double CalculateLateFine(int overdueDays)
        {
            double fine = overdueDays * 0.5 * Math.Sqrt(overdueDays);
            fine = Math.Round(fine, 2);
            return fine;
        }




        // To apply discount member
        public static double ApplyDiscount(double Dis)
        {
             Dis = 20.0;

            if (memberTier.ToUpper() == "gold")
            {
                return Dis - (Dis * 0.20); // 20% discount

            }
            else if (memberTier.ToUpper() == "silver")
            {
                return Dis - (Dis * 0.10); // 10% discount
            }
            else
            {
                return Dis;
            }
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
                Console.WriteLine("   0) Exit" );
                
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
                        else
                        {
                            isMemberRegistered = false;
                        }
                        break;
                        
                    // To Search book by title
                    case 3:

                        RegisterBook();
                        
                        if (BookSearchTitle(Console.ReadLine()) == true)  // Read the input and check 
                        {
                            Console.WriteLine("The book found" +bookTitle.ToLower().Substring(3));
                        }
                        else
                        {
                            Console.WriteLine("The book not found");
                        }
                        break;

                    // Borrow a Book 
                    case 4:
                        bool borrowCheck = CheckIsRegistered();
                        if (borrowCheck == true)
                            BorrowBook(ref numAvailableCopies);
                        break;

                    // Return a Book 
                    case 5:
                        bool returnCheck = CheckIsRegistered();
                        if (returnCheck == true)
                            ReturnBook(ref numAvailableCopies);
                        break;

                    // Calculate Late Fine 
                    case 6:
                        bool fineCheck = CheckIsRegistered();
                        if (fineCheck == true)
                        {
                            Console.Write("Enter number of overdue days: ");
                            int days = int.Parse(Console.ReadLine());
                            double fine = CalculateLateFine(days);
                            totalFinesPaidThisSession++;
                            Console.WriteLine("Late fine amount: " + fine + " OMR");
                        }
                        break;

                    // Apply Member Discount
                    case 7:
                        if (isMemberRegistered = false)
                        {
                            Console.WriteLine("The member not regietered. Register first");
                        }
                        else
                        {
                            Console.Write("Enter the book price: ");
                            double Dis = Convert.ToDouble(Console.ReadLine());
                            double FinalPrice = ApplyDiscount(Dis);
                            Console.WriteLine("Discount Price: $" + Dis);
                        }
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


                    case 0:
                        exit = true;
                        Console.WriteLine("Thank you for using the Library System. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please select a valid number.");
                        break;





                } // Switch (Select)
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear(); // clear the console for better user experience
            } // While loop
        } // static main
    } // class program
} // namespace
