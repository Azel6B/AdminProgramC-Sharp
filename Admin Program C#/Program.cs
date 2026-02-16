using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Program_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // Create a new user
            User myUser = new User("Admin", "Kalebaan 76", "adadadadad@gmail.com", "06 17385904", 27);
            Console.WriteLine($"Created user: {myUser.Name}");
            Console.WriteLine($"Created Email: {myUser.Email}");
            Console.WriteLine($"Created Phone: {myUser.Phone}");
            Console.WriteLine($"Created Address: {myUser.Address}");
            Console.WriteLine($"Created Age: {myUser.Age}");
            Console.WriteLine($"User Info: {myUser.GetUserInfo()}");
        }
    }
}