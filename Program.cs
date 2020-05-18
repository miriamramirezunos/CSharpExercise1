using System;
using System.Collections.Generic; 

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var myclass1 = new class1();
                var str1 = "string one"; 
                var str2 = "string two"; 
                var strEqual = ""; 
                strEqual = myclass1.StringComparison(str1, str2); 
                Console.WriteLine("String Comparison Result: {0}", strEqual);

                List<int> myIntList = new List<int> {8, 2, 10, 4, 5, 1, 50, 6, 7, 9, 3};
                myclass1.VerifyBiggestNumber(myIntList);

                List<string> myStrList = new List<string> {"g", "b", "z", "e", "a", "d", "h", "c", "f"};
                myclass1.SortList(myStrList); 

                var str3 = "count this string lenght"; 
                var strLenght = 0; 
                strLenght = myclass1.CountStringLength(str3); 
                Console.Write("String Lenght: {0}", strLenght);

                var myclass2 = new class2();
                List<int> myIntList2 = new List<int> {5, 3, 7, 2, 50, 1, 4, 6};
                myclass2.PrintFirstFiveValues(myIntList2); 

                List<int> myIntList3 = new List<int> {80, 20, 10, 40, 50, 1, 500, 60, 70, 90, 30};
                myclass2.PrintSmallestNumber(myIntList3);

                myclass2.PrintDictionary(); 
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message); 
            }
        }
    }
}
