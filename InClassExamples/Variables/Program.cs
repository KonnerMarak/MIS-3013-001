//Konner Marak

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an string names firstName
            string firstName;



            //assign a value to first name
            firstName = "Konner";


            //Creat an int named favoriteNumber and assign your favorite number to it
            int favoriteNumber = 13;

            double crazyNumber = 7.767 * favoriteNumber;


            string lastName = "Marak";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName + "has the favorite number of " + favoriteNumber + "\nwhich equates to a crazy number of " + crazyNumber);
            // MAKE IT DYNAMIC
            Console.WriteLine("please enter your first name: >>");
            firstName = Console.ReadLine();

            Console.WriteLine("please enter your last name: >>");
            lastName = Console.ReadLine();


            Console.WriteLine("please enter your favorite number: >>");
            string favoriteNumberAsString = Console.ReadLine();
            favoriteNumber = Convert.ToInt32(Console.ReadLine(););



            Console.WriteLine(fullName + "has the favorite number of " + favoriteNumber + "\nwhich equates to a crazy number of " + crazyNumber);
            Console.ReadKey();

        }
    }
}
