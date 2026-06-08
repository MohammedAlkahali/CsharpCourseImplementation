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

        static  List<String> availableDates = new List<String>()
        {
            "1 - 7 - 2026", "3 - 7 - 2026", "5 - 7 - 2026"
        };

        static Dictionary<string, string> bookingRecord = new Dictionary<string, string>();

        static  Queue<String> checkedInQueue = new Queue<string>();

        static Stack<string> boardingStack = new Stack<string>();

        static List<string> cancelledTickets = new List<string>();

        static Dictionary<string,string> passengerSeatMap = new Dictionary<string,string>();

        static Queue<string> waitlistQueue = new Queue<string>();

        // ==========================================================================================

        // Case 1 - Register New Passenger
        public static void NewPassenger(List<string> passengerNames, List<string> ticketNumbers)
        {
            Console.Write("Enter the passenger full name: ");
            string name = Console.ReadLine();

            // 1st Requirement
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine();
                Console.WriteLine("The name can't be empty, please write a name!");
                Console.WriteLine();
                return;
            }

            // 2nd Requirement
            bool nameExist = false;
            foreach (string existingName in passengerNames)
            {
                if (string.Equals(existingName, name))
                {
                    nameExist = true;
                    break;
                }
            }

            if (nameExist)
            {
                Console.WriteLine();
                Console.WriteLine("The name of the passenger already exists.");
                Console.WriteLine();
                return;
            }

            // 3rd Requirement
            string ticketId = "TKT-" + (ticketNumbers.Count + 1).ToString("D3");

            // 4th Requirement
            passengerNames.Add(name);
            ticketNumbers.Add(ticketId);

            // 5th Requirement
            Console.WriteLine();
            Console.WriteLine("Passenger registered successfully!");
            Console.WriteLine("Name: " + name + " | Ticket ID: " + ticketId);
            Console.WriteLine();

        }

        // ==========================================================================================

        // Case 02 View All Passengers

        public static void ViewPassenger (List<string> passengerNames, List<string> ticketNumbers, List<string> cancelledTickets)
        {
            // 1st requirment 
            if(passengerNames.Count == 0)
            {
                Console.WriteLine("There is no passengers registered yet");
                return;
            }

            // 2nd requirement 
            Console.WriteLine("No. | Passenger Name | Ticket ID | Status");
            Console.WriteLine();

            // 3rd requirement 
            for (int i = 0; i < passengerNames.Count; i++ )
            {
                string status = "Active";

                if (cancelledTickets.Contains(ticketNumbers[i]))
                {
                    status = "CANCELLED";
                }
                else
                    Console.WriteLine((i+1) + "   |    " + passengerNames[i] + "      |  " + ticketNumbers[i] + "  |  " + status);

                Console.WriteLine();
                Console.WriteLine("The total passenger: " +passengerNames.Count);
                Console.WriteLine();
            }
            
        }

        // ==========================================================================================

        // Case 03 Book a Flight Ticket
        public static void BookFlight (List<string> ticketNumbers, string[] flightNumbers, List<String> availableDates, Dictionary<string, string> bookingRecord, List<string> cancelledTickets)
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
                Console.WriteLine( i + 1 + ") " + flightNumbers[i]);
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
            Console.Write("Select a date from dates available: ");

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

        // ==========================================================================================

        // Case 04 View Booking Details


        static void Main(string[] args)
            {
            bool exit = false;
            while (exit == false)

            {           // Display the main menu for the user to choose

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
                        break;

                    // Update a Booking
                    case 5:
                        break;

                    // Cancel a Ticket
                    case 6:
                        break;

                    // Passenger Check-In
                    case 7:
                        break;
                    // Board Passengers (Boarding Stack)
                    case 8:
                        break;

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
            } // While
        } // Main
    } // Program
} // Namespace
