using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            String s1;
            int itemSelect;
            Console.Write("Enter Item number or Item");/// user inputs description "plate" or item number
            s1 = Console.ReadLine();
            int.TryParse(s1, out itemSelect);
            if (int.TryParse(s1, out itemSelect))/// Converts string to INT
            {
                GetDetails(itemSelect);/// pass variable to Method
            }
            else
            {
                string s2;
                s2 = Convert.ToString(itemSelect);
                GetDetails1(s2);
            
            }
        }

        public
           static void GetDetails(int entry)/// This method will display Description and Price
        {
            int[] itemNum = { 112, 123, 134, 213, 224, 235 };
            string[] description = { "plate", "cup", "bowl", "vase", "planter", "statue" };
            double[] price = { 16.95, 10.95, 14.25, 21.95, 45.99, 89.99 };

            int x;
          

            
            for (x = 0; x < itemNum.Length; ++x)
            {
                if (entry == itemNum[x])
                {
                    Console.WriteLine
                        ("Description: {0} Price: {1} ",
                        description[x], price[x].ToString("C"));

                }
            }
        }





        public static void GetDetails1(string entry) /// for Some reason it will not pass string to this method.
        {
            int[] itemNum = { 112, 123, 134, 213, 224, 235 };
            string[] description = { "plate", "cup", "bowl", "vase", "planter", "statue" };
            double[] price = { 16.95, 10.95, 14.25, 21.95, 45.99, 89.99 };

            int x;


          
            for (x = 0; x < itemNum.Length; ++x)
            {
                if (entry == description[x])
                {
                    Console.WriteLine
                        ("Item:{0} Price: {1} ",
                        itemNum[x], price[x].ToString("C"));

                }


            }
        }


    };
};
