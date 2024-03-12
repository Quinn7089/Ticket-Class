
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
} while (Ticket.choice == "1" || Ticket.choice == "2") ;












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
