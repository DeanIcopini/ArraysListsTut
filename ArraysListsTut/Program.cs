using System;
using System.Collections.Generic;


namespace ArraysListsTut
{
    class Program
    {
        static void Main()
        {
            // Arrays are used primarily when there is a fixed number of items that you are working with (like items that took place in the past, maybe within a designated time frame). Or if you are storing a very large quantity of items i.e. bytes in a picture.
            // Lists are used when the data items you are working with have the potential to change.

            // LIST EXAMPLES

            //List<int> intList = new List<int>();
            // To change data type:
            List<string> intList = new List<string>();
            intList.Add("4");
            intList.Add("10");
            intList.Remove("10");

            Console.WriteLine(intList[0]);
            Console.Read();

            // ARRAY EXAMPLES

            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //// The above code can also be written like:
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000};

            //// A faster way
            //int[] numArray2 = { 2, 5, 10, 200, 5000, 620, 2300 };

            //// To change an item in an array
            //numArray2[5] = 650;
            
            //Console.WriteLine(numArray1[2]);
            //Console.Read();
        }
    }
}
