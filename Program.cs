
string file = "ticketData.txt";

ticket Ticket = new ticket();

do
{
    Console.WriteLine("1) Read Data from file.");
    Console.WriteLine("2) Create File from data");
    Console.WriteLine("Enter any other key to exit");


    Ticket.choice = Console.ReadLine();

    if (Ticket.choice == "1")
    {
        if (File.Exists(file))
        {

            StreamReader sr = new StreamReader(file);

            while (!sr.EndOfStream)
            {

                string newPerson = sr.ReadLine();

                Console.WriteLine(newPerson);

            }
            sr.Close();

        }
        else
        {
            Console.WriteLine("File does not exist");
        }
    }
    else if (Ticket.choice == "2")
    {
        StreamWriter sw = new StreamWriter(file);

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Enter Ticket (Y/N)?");

            string resp = Console.ReadLine();

            if (resp != "Y") { break; }

            Console.WriteLine("Enter Ticket ID:");

            Ticket.ticketID = Console.ReadLine();

            Console.WriteLine("Enter Summary:");

            Ticket.Summary = Console.ReadLine();

            Console.WriteLine("Enter Status:");

            Ticket.Status = Console.ReadLine();

            Console.WriteLine("Enter priority:");

            Ticket.priority = Console.ReadLine();

            Console.WriteLine("Enter Submitter:");

            Ticket.Submitter = Console.ReadLine();

            Console.WriteLine("Enter assigend:");

            Ticket.assigend = Console.ReadLine();


            Console.WriteLine("Enter watching:");

            Ticket.watching = Console.ReadLine();

            sw.WriteLine(Ticket.ticketID + ", " + Ticket.Summary + ", " + Ticket.Status + ", " + Ticket.priority + ", "
            + Ticket.Submitter + ", " + Ticket.assigend + ", " + Ticket.watching);

        }
        sw.Close();
    }
} while (Ticket.choice == "1" || Ticket.choice == "2");












public class ticket
{

    public string ticketID { get; set; }

    public string Summary { get; set; }

    public string Status { get; set; }

    public string priority { get; set; }

    public string Submitter { get; set; }

    public string assigend { get; set; }

    public string watching { get; set; }

    public string choice { get; set; }

}
