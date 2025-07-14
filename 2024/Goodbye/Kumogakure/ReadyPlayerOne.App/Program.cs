using ReadyPlayerOne.App.People;

namespace ReadyPlayerOne.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nJumbo, Rafiki!\nAhmed is the 9th Raikage.\n");

            TableServers tableServers = new TableServers();
            //tableServers.ListServers();

            Person myPerson = new Person("Ahmed", "Omar", 30, "AhmedOmar@email.ai");
            myPerson.Greeting();
        }
    }
}
