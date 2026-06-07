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
            
        }
    }
}
