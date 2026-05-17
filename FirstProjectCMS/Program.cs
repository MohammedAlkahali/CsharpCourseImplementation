namespace FirstProjectCMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First: Declare all the variables

            int ID = 0;

            string Pname = "";

            int Page = 0;

            int Pphone = 0;

            string Pemail = "";

            bool isP1Active = false;

            //string P1name = ""; int P1age = 0; int P1phone = 0; string P1email = ""; bool isP1Active = false;

            //string P2name = ""; int P2age = 0; int P2phone = 0; string P2email = ""; bool isP2Active = false;


            // Second: Display the main menu

            Console.WriteLine("-WELCOME TO CLINIC MANAGEMENT SYSTEM-");
            Console.WriteLine("");
            Console.WriteLine("1) Register a new patient");
            Console.WriteLine("2) Display the patient information");
            Console.WriteLine("3) Update the patient information");
            Console.WriteLine("4) Delete a patient");
            Console.WriteLine("0) Exit");
            Console.WriteLine(); 

            // Asking the user to choose a service
            Console.Write("Please choose a service to procced: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: // Adding a new patient
                    if (isP1Active == true)
                    {
                        Console.WriteLine("The patient already exist !!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter the patient ID");
                        ID = int.Parse(Console.ReadLine());

                        Console.Write("Enter the patient name: ");  //| Asking to write the patient name 
                        Pname = Console.ReadLine();                    //| Read the name of the patient and store it in the variable

                        Console.Write("Enter the patient age: ");
                        Page = int.Parse(Console.ReadLine());

                        Console.Write("Enter the patient phone number: ");
                        Pphone = int.Parse(Console.ReadLine());

                        Console.Write("Enter the patient Email: ");
                        Pemail = Console.ReadLine();

                        isP1Active = true; // After the patient added, we will convert it to true

                        Console.WriteLine("The patient added successfully");
                    }
                    break;

                case 2: // Display the patient information
                    break;

                case 3: // Update the patient information
                    Console.WriteLine();
                    Console.WriteLine("1) Update the patient name");
                    Console.WriteLine("2) Update the patient Phone number");
                    Console.WriteLine("3) Update the patient Email");
                    Console.WriteLine();
                    Console.Write("Choose an option to update: ");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.Write("Write the new name: ");
                        Pname = Console.ReadLine();
                        Console.WriteLine("The name updated sucessfully.");
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Write the new phone number: ");
                        Pphone = int.Parse(Console.ReadLine());
                        Console.WriteLine("The phone number updated sucessfully.");
                    }
                    else if (choice == 3)
                    {
                        Console.Write("Write the new Email: ");
                        Pemail = Console.ReadLine();
                        Console.WriteLine("The email updated sucessfully.");
                    }
                    else
                    {
                        Console.WriteLine("invalid option please try again");
                    }
                break;


                case 4:
                    break; 

                case 5:
                    break;


            }
        }
    }
}
