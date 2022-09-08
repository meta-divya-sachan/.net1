
// Generic is a class which allows the user to define classes and methods with the placeholder.
//  Generics were added to version 2.0 of the C# language.
//   The basic idea behind using Generic is to allow type (Integer, String, … etc and user-defined types) to be a parameter to methods, classes, and interfaces

using System;
namespace Programof
{
    public class Compare<T>
    {


       
        public bool CompareValues<T>(T value1, T value2) where T : class
        {
           
            if (value1.Equals(value2))
            {


                return true;
            }
            else
            {
                return false;
            }
        }
        // else{
        //     return false;
        // }




    }

}
  
   namespace Programof{

    public class CompareList<T>
    {
        public Boolean EmptyList<T>(List<T> ItemList)
        {

            if (ItemList.Count == 0)
            {
                return true;
            }
            else
            {

                return false;

            }

        }
    }
}