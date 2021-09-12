using System;

namespace HashFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter the string message:");
                string message = Console.ReadLine();
                Console.WriteLine("MD-5 Hash: " + MD.MD5(message));
                Console.WriteLine("SHA-256 Hash: " + SHA.SHA256(message));
            }
        }
    }
}
