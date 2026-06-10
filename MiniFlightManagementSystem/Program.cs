namespace MiniFlightManagementSystem
{
    internal class Program
    {

        static List<String> passengerNames = new List<String>()

        {
            "Mohammed", "Ahmed", "Luqman", "Ali", "Salem"
        };

        static List<String> ticketNumbers = new List<String>()
        {
            "TKT-001", "TKT-002", "TKT-003", "TKT-004", "TKT-005"
        };

        static string[] flightNumbers = { "FN-101", "FN-102", "FN-103", "FN-104", "FN-105", "FN-106" };

        static List<String> availableDates = new List<String>()
        {
            "1 - 7 - 2026", "3 - 7 - 2026", "5 - 7 - 2026"
        };

        static Dictionary<string, string> bookingRecord = new Dictionary<string, string>();

        static Queue<String> checkedInQueue = new Queue<string>();

        static Stack<string> boardingStack = new Stack<string>();

        static List<string> cancelledTickets = new List<string>();

        static Dictionary<string, string> passengerSeatMap = new Dictionary<string, string>();

        static Queue<string> waitlistQueue = new Queue<string>();

        static int seatRow = 10;

        static char seatLetter = 'A';
        // ====================================================================================================================================================================================
        // CASE 1 - REGISTER NEW PASSENGER
        public static void NewPassenger(List<string> passengerNames, List<string> ticketNumbers)
        {
            // Prompt the clerk to enter the new passenger's full name.
            Console.Write("Enter the passenger full name: ");
            string name = Console.ReadLine();


            // Validate that the name is not empty 
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine();
                Console.WriteLine("The name can't be empty, please write a name!");
                Console.WriteLine();
                return;
            }

            // Validate name does not already exist in passengerNames
            bool nameExist = false;
            foreach (string existingName in passengerNames)
            {
                if (string.Equals(existingName, name))
                {
                    Console.WriteLine("The name of the passenger already exists.");
                    nameExist = true;
                    return;
                }
            }


            // Auto-generate the ticket ID using the format TKT-XXX
            string ticketId = "TKT-" + (ticketNumbers.Count + 1).ToString("D3");


            // Add the passenger name to passengerNames and the generated ticket ID to ticketNumbers
            passengerNames.Add(name);
            ticketNumbers.Add(ticketId);


            //  Display a success confirmation
            Console.WriteLine();
            Console.WriteLine("Passenger registered successfully!");
            Console.WriteLine("Name: " + name + " | Ticket ID: " + ticketId);
            Console.WriteLine();
        }




        // ====================================================================================================================================================================================
        // CASE 02 - VIEW ALL PASSENGER
        public static void ViewPassenger(List<string> passengerNames, List<string> ticketNumbers, List<string> cancelledTickets)
        {
            //  Check if passengerNames is empty
            if (passengerNames.Count == 0)
            {
                Console.WriteLine("There is no passengers registered yet");
                return;
            }


            //  Display a formatted table header
            Console.WriteLine("No. | Passenger Name | Ticket ID | Status");
            Console.WriteLine();


            //  Iterate over passengerNames using a for loop 
            for (int i = 0; i < passengerNames.Count; i++)
            {
                //  check whether it exists in cancelledTickets
                string status = "Active";
                if (cancelledTickets.Contains(ticketNumbers[i]))
                {
                    status = "CANCELLED";
                }
                else
                    Console.WriteLine((i + 1) + "   |    " + passengerNames[i] + "      |  " + ticketNumbers[i] + "  |  " + status);


                //  Display the total passenger
                Console.WriteLine();
                Console.WriteLine("The total passenger: " + passengerNames.Count);
                Console.WriteLine();
            }
        }




        // ====================================================================================================================================================================================
        // CASE 03 - BOOK A FLIGHT TICKET 
        public static void BookFlight(List<string> ticketNumbers, string[] flightNumbers, List<String> availableDates, Dictionary<string, string> bookingRecord, List<string> cancelledTickets)
        {
            // Prompt for a ticket ID
            Console.WriteLine();
            Console.Write("Enter the ticket ID: ");
            string ticketID = Console.ReadLine();

            if (!ticketNumbers.Contains(ticketID))
            {
                Console.WriteLine();
                Console.WriteLine("Error, not found");
                return;
            }

            if (cancelledTickets.Contains(ticketID))
            {
                Console.WriteLine();
                Console.WriteLine("The ticket is cancelled");
                return;
            }


            //  Check if the ticket is already in bookingRecord
            if (bookingRecord.ContainsKey(ticketID))
            {
                Console.WriteLine();
                Console.WriteLine("the ticket already has a booking");
                return;
            }


            // Display all available flight numbers
            for (int i = 0; i < flightNumbers.Length; i++)
            {
                Console.WriteLine(i + 1 + ") " + flightNumbers[i]);
            }


            // Prompt the user to select a flight
            Console.WriteLine();
            Console.Write("Select a flight by the number: ");
            int FlightNum;

            if (!int.TryParse(Console.ReadLine(), out FlightNum))
            {
                Console.WriteLine();
                Console.WriteLine("Enter a valid number");
                return;
            }

            if (FlightNum < 0 || FlightNum >= flightNumbers.Length)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number");
                return;
            }


            // Display all available dates
            for (int i = 0; i < availableDates.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + availableDates[i]);
            }


            //  Prompt the user to select a date 
            Console.WriteLine();
            Console.Write("Select a dates: ");

            int DateNum;

            if (!int.TryParse(Console.ReadLine(), out DateNum))
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number");
                return;
            }
            if (DateNum < 0 || DateNum >= availableDates.Count)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number");
                return;
            }


            //  Store the booking in bookingRecord
            bookingRecord.Add(ticketID, flightNumbers[FlightNum] + "|" + availableDates[DateNum]);
            int index = ticketNumbers.IndexOf(ticketID);
            string passengerName = passengerNames[index];


            //  Display a booking confirmation showing ticket ID, passenger name, flight, and date
            Console.WriteLine("Booking successfully confirmed");
            Console.WriteLine();
            Console.WriteLine("Ticket: " + ticketID + " | Passenger: " + passengerName);
            Console.WriteLine("Flight: " + flightNumbers[FlightNum] + " | Date: " + availableDates[DateNum]);
        }




        // ====================================================================================================================================================================================
        // CASE 04 - VIEW BOOKING DETAILS
        public static void ViewBooking(List<string> ticketNumbers, List<String> passengerNames, Dictionary<string, string> bookingRecord, List<string> cancelledTickets)
        {
            // Prompt for a ticket ID
            Console.WriteLine();
            Console.Write("Enter the ticket ID: ");
            string ticketID = Console.ReadLine();

            if (!ticketNumbers.Contains(ticketID))
            {
                Console.WriteLine();
                Console.WriteLine("Error, not found");
                return;
            }



            // Retrieve the passenger name from passengerNames
            int index = ticketNumbers.IndexOf(ticketID);
            string passengerName = passengerNames[index];


            //  Check if the ticket is in cancelledTickets
            if (cancelledTickets.Contains(ticketID))
            {
                Console.WriteLine("This ticket has been cancelled");
                return;
            }

            // Use the Dictionary to retrieve the booking value. 
            if (!bookingRecord.ContainsKey(ticketID))
            {
                Console.WriteLine("No booking found for this ticket.");
                return;
            }

            //  Split the retrieved value 
            string value = bookingRecord[ticketID];        // get "FN-101|date"
            string[] parts = value.Split('|');             // break at the |
            string flight = parts[0];                       // before the | = flight
            string date = parts[1];                         // after the | = date


            Console.WriteLine();
            Console.WriteLine("===== BOOKING DETAILS =====");
            Console.WriteLine("Passenger : " + passengerName);
            Console.WriteLine("Ticket ID : " + ticketID);
            Console.WriteLine("Flight    : " + flight);
            Console.WriteLine("Date      : " + date);
            Console.WriteLine("===========================");
        }




        // Case 05 Update a Booking
        public static void UpdateBooking(List<string> ticketNumbers, Dictionary<string, string> bookingRecord,
                                         string[] flightNumbers, List<string> availableDates, List<string> cancelledTickets)
        {
            // Requirement 1
            // Prompt for ticket ID
            Console.WriteLine();
            Console.Write("Enter the ticket ID: ");
            string ticketID = Console.ReadLine();

            // Validate it exists
            if (!ticketNumbers.Contains(ticketID))
            {
                Console.WriteLine("Ticket not found.");
                return;
            }

            // Validate is not cancelled
            if (cancelledTickets.Contains(ticketID))
            {
                Console.WriteLine("This ticket has been cancelled.");
                return;
            }

            // Validate has an existing booking in bookingRecord
            if (!bookingRecord.ContainsKey(ticketID))
            {
                Console.WriteLine("No booking found for this ticket.");
                return;
            }


        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)

            {           // Display the main menu to choose

                Console.WriteLine("=============================================\r\nWELCOME TO SKY WINGS FLIGHT MANAGEMENT SYSTEM\r\n=============================================");
                Console.WriteLine("  Please select from the main menu");
                Console.WriteLine();
                Console.WriteLine("   1)  Register New Passenger");
                Console.WriteLine("   2)  View All Passengers");
                Console.WriteLine("   3)  Book a Flight Ticket");
                Console.WriteLine("   4)  View Booking Detail");
                Console.WriteLine("   5)  Update a Booking");
                Console.WriteLine("   6)  Cancel a Ticket");
                Console.WriteLine("   7)  Passenger Check-In");
                Console.WriteLine("   8)  Board Passengers (Boarding Stack)");
                Console.WriteLine("   9)  Generate Flight Manifes");
                Console.WriteLine("   10) Manage Waitlist & Seat Assignment");
                Console.WriteLine("   0)  Exit");
                Console.WriteLine(" =============================================");

                Console.Write("   -> Select: ");

                int Select = int.Parse(Console.ReadLine());

                switch (Select)
                {
                    // For registering a new Passenger
                    case 1:
                        NewPassenger(passengerNames, ticketNumbers);
                        break;


                    // To View All Passengers
                    case 2:
                        ViewPassenger(passengerNames, ticketNumbers, cancelledTickets);
                        break;


                    // To Book a Flight Ticket
                    case 3:
                        BookFlight(ticketNumbers, flightNumbers, availableDates, bookingRecord, cancelledTickets);
                        break;


                    // View Booking Detail
                    case 4:
                        ViewBooking(ticketNumbers, passengerNames, bookingRecord, cancelledTickets);
                        break;


                    // Update a Booking
                    //case 5:
                    //    UpdateBooking(ticketNumbers, bookingRecord, flightNumbers, availableDates, cancelledTickets);
                    //    break;


                    //// Cancel a Ticket
                    //case 6:
                    //    CancelTicket(ticketNumbers, passengerNames, cancelledTickets, bookingRecord, checkedInQueue, boardingStack);
                    //    break;


                    //// Passenger Check-In
                    //case 7:
                    //    PassengerCheckIn(ticketNumbers, passengerNames, cancelledTickets, checkedInQueue, waitlistQueue, bookingRecord);
                    //    break;


                    //// Board Passengers (Boarding Stack)
                    //case 8:
                    //    BoardPassengers(checkedInQueue, boardingStack, passengerSeatMap);
                    //    break;


                    // Generate Flight Manifes
                    case 9:
                        break;


                    // Manage Waitlist & Seat Assignment
                    case 10:
                        break;


                    case 0:
                        exit = true;
                        Console.WriteLine("Thank you for using our System. Goodbye!");
                        break;


                    default:
                        Console.WriteLine("Invalid option. Please select a valid number.");
                        break;


                } // Switch

                Console.WriteLine("press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            } // While
        } // Main
    } // Program
} // Namespace