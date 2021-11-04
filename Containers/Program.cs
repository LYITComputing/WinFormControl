using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containers
{

    public static class StringExtensions
    {

        class Program
        {
            static void Main(string[] args)
            {
                //ListIntDemo();

                ListStringDemo();


            }

            static public void ListIntDemo()
            {
                //Create a list of numbers. Note that we must specify the type
                List<int> numbers = new List<int>();

                //Initialise the random number generator
                var rand = new Random();

                //Lets add ten random numbers
                for (int index = 0; index < 10; index++)
                {
                    numbers.Add(rand.Next(101));
                    //numbers.Add(index);
                }
                //Try to add some text
                //Results in compiler Error CS1503  Argument 1: cannot convert from 'string' to 'int'
                //numbers.Add("Some text");

                double sum = 0;
                //Print out each number
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                    sum += number;
                }

                Console.WriteLine($"The total of all the numbers is: {sum}");
                Console.WriteLine($"The mean is : {sum / numbers.Count}");


            }

            static public void ListStringDemo()
            {

                //List<string> counties = new List<string> { "Carlow", "Cavan", "Clare", "Cork", "Donegal", "Dublin", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Waterford", "Westmeath", "Wexford", "Wicklow", "Antrim", "Armagh", "Derry", "Down", "Fermanagh", "Monaghan", "Tyrone" };

                List<string> counties = new List<string> { "Carlow", "Cavan", "Clare", "Cork", "Donegal", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Waterford", "Westmeath", "Wexford", "Wicklow", "Antrim", "Armagh", "Derry", "Down", "Fermanagh", "Tyrone" };

                Console.WriteLine("Unordered list of counties");
                int index = 0;
                foreach (string county in counties)
                {
                    index++;
                    Console.WriteLine($"{index}: {county}");

                }

                Console.WriteLine("\nSorting the list of counties\n");
                counties.Sort();
                Console.WriteLine("Ordered list of counties");
                index = 0;
                foreach (string county in counties)
                {
                    index++;
                    Console.WriteLine($"{index}: {county}");
                }

                Console.Write("\nName the missing county: ");
                string missingCounty = Console.ReadLine();


                //Check to see if they are correct
                if (counties.Contains(missingCounty))
                {
                    int location = counties.BinarySearch(missingCounty);
                    Console.WriteLine($"The list already contains the county {missingCounty} and it is at index {location}");

                }
                if(missingCounty == "Dublin")
                {

                    Console.WriteLine("Congratulations you found the missing county");
                }
                else
                {
                    Console.WriteLine("I don't believe that is a county!");
                }


            }
        }
    }
        
}


//http://blog.stevex.net/string-formatting-in-csharp/ 