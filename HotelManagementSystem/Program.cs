namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring all the variables 
            string guestName = "";
            int guestPhone = 0;
            int roomNum = 0;
            string roomType = "";
            int nightlyRate = 0;
            DateTime checkInDate = DateTime.Today;
            DateTime checkOutDate = DateTime.Today; 
            int NumOfNights = 0;
            string roomNotes = "";
            int disPercentage = 0;
            int loyaltyPoints = 0;
            bool isRegistered = false;
            bool isCurrCheckedIn = false;

            Random random = new Random();  // --> To generate auto number
            bool exit = false;

            /////////////////////////////


            while (true)
            {      // Display the main menu for the user to choose
                Console.WriteLine("WELCOME TO HOTEL MANAGEMENT SYSTEM");
                Console.WriteLine();
                Console.WriteLine("1) Register New Guest");
                Console.WriteLine("2) View Guest Information");
                Console.WriteLine("3) Check-In Guest");
                Console.WriteLine("4) Check-Out & Bill");
                Console.WriteLine("5) Apply Discount");
                Console.WriteLine("6) Upgrade Room");
                Console.WriteLine("7) Add Room Service Note");
                Console.WriteLine("8) Search Guest by Name");
                Console.WriteLine("9) Calculate Loyalty Points");
                Console.WriteLine("10) Print Receipt");
                Console.WriteLine("11) Edit Guest Name");
                Console.WriteLine("0) Exit");
                Console.WriteLine();

                Console.Write("Please choose to continue: ");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    // If the user choose to Register New Guest
                    case 1:  

                        Console.WriteLine();
                        Console.WriteLine("--REGISTERING A NEW GUEST--");
                        Console.WriteLine();

                        Console.Write("Enter the guest name: ");
                        guestName = Console.ReadLine().Trim();

                        Console.Write("Enter the guest phone number: ");
                        guestPhone = int.Parse(Console.ReadLine().Trim());

                        Console.Write("Enter the room type: ");
                        roomType = Console.ReadLine().Trim();

                        Console.Write("Enter the nightly rate: ");
                        nightlyRate = int.Parse(Console.ReadLine().Trim());

                        // Auto-generate room number.
                        roomNum = random.Next(1, 1000);

                        Console.WriteLine("The guest added successfully !!");
                        Console.WriteLine("The room number is: " + roomNum);
                        break;

                    // If the user choose to View Guest Information
                    case 2:
                        Console.WriteLine("--VIEW GUEST INFORMATION--");
                        Console.WriteLine();
                        if(isRegistered = false)
                        {
                            Console.WriteLine("There is no information with this name");
                        }
                        else
                        {
                            Console.WriteLine("Guest Name: " + guestName.ToUpper()) ;
                            Console.WriteLine("Guest Phone Number: " + guestPhone.ToString());
                            Console.WriteLine("Room Type: " + roomType.ToString());
                            Console.WriteLine("Nightly Rate: " + nightlyRate.ToString());
                        }
                        break;

                    // If the user choose to Check-In Guest
                    case 3:
                        Console.WriteLine("--CHECK IN GUEST--");
                        Console.WriteLine() ;
                        checkInDate = DateTime.Now;
                        Console.WriteLine("Check in date is " + checkInDate.ToString());
                        

                        break;

                    // If the user choose to Check-Out & Bill
                    case 4:
                        break;

                    // If the user choose to Apply Discount
                    case 5:
                        break;

                    // If the user choose to Upgrade Room
                    case 6:
                        break;

                    // If the user choose to Add Room Service Note
                    case 7:

                        break;

                    // If the user choose to Search Guest by Name
                    case 8:
                        break;

                    // If the user choose to Calculate Loyalty Points
                    case 9:
                        break;

                    // If the user choose to Print Receipt
                    case 10:
                        break;

                    // If the user choose to Edit Guest Name
                    case 11:
                        break;

                    // If the user choose to Exit
                    case 0:
                        exit = true;
                        break;

                    // if the user enter a number outside the list above
                    default:
                        Console.WriteLine("invalid option please try again");
                        break;
                }

                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

        } // main
    } // class program
} // name space
