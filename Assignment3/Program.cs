using Assignment3.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        public static void Main(string[] args) {
            SLL userList = new SLL();

            userList.AddLast(new User(1, "Alice", "alice@example.com", "password1"));
            userList.AddLast(new User(2, "Bob", "bob@example.com", "password2"));
            userList.AddLast(new User(3, "Charlie", "charlie@example.com", "password3"));

            Console.WriteLine("Users in the list:");
            DisplayUsers(userList);

            userList.AddFirst(new User(0, "Dave", "dave@example.com", "password4"));
            Console.WriteLine("\nAfter adding Dave at the beginning:");
            DisplayUsers(userList);

            userList.RemoveLast();
            Console.WriteLine("\nAfter removing the last user:");
            DisplayUsers(userList);

            userList.Replace(new User(2, "Bob Updated", "bob.updated@example.com", "newpassword"), 1);
            Console.WriteLine("\nAfter replacing Bob:");
            DisplayUsers(userList);

            User userAtIndex1 = userList.GetValue(1);
            Console.WriteLine($"\nUser at index 1: {userAtIndex1.Name}");
        }

        static void DisplayUsers(SLL userList)
        {
            for (int i = 0; i < userList.Count(); i++)
            {
                User user = userList.GetValue(i);
                Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
            }
        }
    }
    
}
