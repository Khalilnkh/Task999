using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Vaqif", "Ramazanov", "3J14", Month.April);
            Console.WriteLine(user1.GetDetails());
            User user2 = new User("BEhram", "Abdulov", "5HGS", Month.October);
            Console.WriteLine(user2.GetDetails());
            User user3 = new User("Resad", "Osmanov", "9USs", Month.February);
            Console.WriteLine(user3.GetDetails());
            User user4 = new User("ULvi", "Ramazanli", "5SS8", Month.May);
            Console.WriteLine(user4.GetDetails());
            User user5 = new User("Revan", "Kerimov", "S8YW", Month.July);
            Console.WriteLine(user5.GetDetails());

        }


    }

}