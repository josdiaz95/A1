namespace Assignment1
{
    internal class Program
    {



        static void Main(string[] args)
        {

            string fileInSystem = "ticketSystem.txt";

            Console.WriteLine("Read data from file : 1");
            Console.WriteLine("Create file from data : 2");
            Console.WriteLine("End by pressing: 3.");
            int userResponse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------");

            switch (userResponse)
            {
                case 1:
                    if (File.Exists(fileInSystem))
                    {
                        StreamReader read = new StreamReader(fileInSystem);
                        {
                            //Skipping all lines we are not interested in
                            for (int i = 1; i < 3; i++)
                            {
                                read.ReadLine();
                            }
                            //Specific line we want to read
                            Console.WriteLine(read.ReadLine());
                        }

                    }
                    else
                    {
                        Console.WriteLine("ERROR: File is non existent.");
                    }

                    break;


                case 2:

                    string[] headers = { "Ticket ID", "Summary", "Status", "Priority", "Submitter", "Assigned", "Watchers" };
                    string[] ticket = new string[7];
                    StreamWriter write = new StreamWriter(fileInSystem);

                    Console.WriteLine(" Please folow the prompts below: ");

                    Console.WriteLine("What is the ticket ID");
                    ticket[0] = Console.ReadLine();
                    Console.WriteLine();


                    Console.WriteLine("Provide summary");
                    ticket[1] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("What is the status");
                    ticket[2] = Console.ReadLine();
                    Console.WriteLine();


                    Console.WriteLine("Priority");
                    ticket[3] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Submitter");
                    ticket[4] = Console.ReadLine();
                    Console.WriteLine();


                    Console.WriteLine("Assigned");
                    ticket[5] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("How Many watchers are there? ");
                    int numWatchers = int.Parse(Console.ReadLine());
                    string[] watchers = new string[numWatchers];
                    //write.Write("{0,5}", watchers);

                    for (int i = 0; (i < numWatchers); i++)
                    {
                        Console.WriteLine("Please enter a watcher");
                        watchers[i] = Console.ReadLine() + "|";

                    }

                    for (int i = 0; i < watchers.Length; i++)
                    {
                        ticket[6] += watchers[i];
                    }

                    foreach (var head in headers)
                    {
                        write.Write("{0,-15}", head);
                    }


                    write.WriteLine("\n");


                    foreach (var item in ticket)
                    {
                        write.Write("{0,-15}", item);
                    }

                    Console.WriteLine("You have created a ticket.");
                    write.Close();

                    break;


                case 3:

                    Console.WriteLine("Thank you for using the Ticket System.");

                    break;


            }


        }


    }

}