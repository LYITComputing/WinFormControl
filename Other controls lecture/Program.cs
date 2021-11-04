using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Other_controls_lecture
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //List<int> numbers = new List<int>();
            //numbers.Add(3);
            //numbers.Add(32);
            //numbers.Add(54);
            //numbers.Add(74);
            //numbers.Add(21);
            //int sum = 0;
            //foreach (int num in numbers)
            //{
            //    sum += num;
            //}
            //Console.WriteLine("The total of all of the numbers in the list is: " + sum.ToString());

            //Console.WriteLine("The capactiy of the numbers list is: " + numbers.Capacity.ToString()); 
            //Console.WriteLine("The count of the numbers list is: " + numbers.Count.ToString());
            //bool cont = numbers.Contains(21);
            //Console.WriteLine(cont);

            //int index = numbers.BinarySearch(54);
            //Console.WriteLine(index);
            //numbers.Sort();

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}



            /*
            Item myItem = new Item();
            Weapon myWeapon = new Weapon();
            Armour myArmour = new Armour();

            List <Weapon> Inventory = new List<Weapon>();
            //List <Item> Inventory = new List<Item>();

            Inventory.Add(myWeapon);
            Inventory.Add(myArmour); //ERROR with a list of weapons

            foreach (Item element in Inventory){
                Console.WriteLine(element.ItemName);
            }
            */


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPayment());
            //Application.Run(new UserInfo());


        }
    }
}
