namespace ReadyPlayerOne.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nJumbo, Rafiki!\nAhmed is the 9th Raikage.\n");

            TableServers tableServers = new TableServers();

            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("");
                }
                Console.WriteLine("The next Server is: " + tableServers.GetNextServer());
            }



            Console.WriteLine("\nPress any key to exit.");




            Console.ReadLine();
        }
    }
}
