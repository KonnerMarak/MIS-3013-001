﻿//Konner Marak

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
        

            Console.ReadKey();

        }
    }
}
