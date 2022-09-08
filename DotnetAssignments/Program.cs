
//===========================================assigmnet-2 -------part -1============================================
using System;
namespace Programof
{
    class Program
    {

        public static void Main(string[] args)
        {
            Compare<string> strvalues = new Compare<string>();
            Compare<int> intvalues = new Compare<int>();

            Console.WriteLine("Enter value-1");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string value1 = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Enter value-2");
            string value2 = Console.ReadLine();


            

            Console.WriteLine(strvalues.CompareValues(value1, value2));

            //-------------------------=--------assigment-2 part-2------------------------------------------------------------   



            CompareList<string> c = new CompareList<string>();
                        CompareList<int> cint = new CompareList<int>();

            List<string> ItemList1 = new List<string>()
            {"sa", "ds", "ss"};
            List<string> ItemList2 = new List<string>();
          
            List<int> ItemList3 = new List<int>()
            {1,4,6};
            List<int> ItemList4 = new List<int>()
;
            // Console.WriteLine("Items Added To Inventory Are: "); // Outputs List in reverse order. (Recent input first).
            // var n = Console.ReadLine();
            // int a = Convert.ToInt32(n);
            // Console.WriteLine(a);
            

            // for (int i = 0; i < a; i++) // Continue For Loop until i is < the needed amount.
            // {

            //    Console.WriteLine($"{i + 1}: Enter Item Name To Add To Inventory"); // Asks for user input into array.
               
            //     string ListInput = Console.ReadLine();
            //     if(ListInput!=null && ListInput!=""){
               
            //         // User inputs value into field.
            //         ItemList.Add(ListInput);
                
            //     }

            //}
            Console.WriteLine(c.EmptyList(ItemList1));
            Console.WriteLine(c.EmptyList(ItemList2));
            Console.WriteLine(cint.EmptyList(ItemList3));
            Console.WriteLine(cint.EmptyList(ItemList4));



        }
    }

}



