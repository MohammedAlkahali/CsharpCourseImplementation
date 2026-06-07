namespace MiniFlightManagementSystem
{
    internal class Program
    {

        List<String> passengerNames = new List<String>()

        {
            "Mohammed", "Ahmed", "Luqman", "Ali", "Salem"
        };

        List<int> ticketNumbers = new List<int>()
        {
            10, 20, 30, 40, 50
        };

        string[] flightNumbers = { "FN-101", "FN-102", "FN-103", "FN-104", "FN-105", "FN-106" };

        List<String> availableDates = new List<String>()
        {
            "1 - 7 - 2026", "3 - 7 - 2026", "5 - 7 - 2026"
        };

        Dictionary<int, string> bookingRecord = new Dictionary<int, string>();

        Queue<String> checkedInQueue = new Queue<string>();

        Stack<string> boardingStack = new Stack<string>();

        List<string> cancelledTickets = new List<string>();

        Dictionary<string,string> passengerSeatMap = new Dictionary<string,string>();

        Queue<string> waitlistQueue = new Queue<string>();

        static void Main(string[] args)
        {
            
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
