using System;

namespace DateTimePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Username = "test user";

            bool check = true;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Share status");
                Console.WriteLine("2. Get status by title");
                Console.WriteLine("3. Quit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Status status = new Status("test status", "test content");
                        user.ShareStatus(status);
                        break;
                    case "2":
                        Console.WriteLine("title:");
                        string title = Console.ReadLine();
                        Console.WriteLine(user.GetStatusByTitle(title));
                        break;
                    case "3":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("wrong input!!!");
                        break;
                }
            } while (check);
        }
    }
}
