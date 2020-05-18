using System;
using System.Collections.Generic;

namespace Exercise_1
{
    public class class1
    {
        public string StringComparison(string str1, string str2)
        {
            if (! String.IsNullOrEmpty(str1) && ! String.IsNullOrEmpty(str2))
            {
                if (str1 == str2)
                {
                    return "Strings are equal"; 
                }
                return "Strings are not equal"; 
            }    
            return "Comparison was not made. At least one of the strings is null or empty"; 
        }

        public void VerifyBiggestNumber(List<int> lstInt1)
        {
            if (lstInt1.Count > 0) 
                {
                var biggestNumber = 0; 
                foreach(int number in lstInt1)
                {
                    if (biggestNumber < number)
                    {
                        biggestNumber = number; 
                    }        
                }
                Console.WriteLine("\nBiggest number on the list is {0}", biggestNumber);
            }
            else
            {
                Console.WriteLine("\nBiggest number on the list was not calculated. Reason: The list is empty ");
            }
        }

        public void SortList(List<string> lstStr1)
        {
            if (lstStr1.Count > 0) 
            {
                lstStr1.Sort(); 
                Console.WriteLine("\nList sorted asc: ");
                foreach(string str in lstStr1)
                {
                    Console.Write("{0} ", str);
                }
                lstStr1.Reverse();
                Console.WriteLine("\nList sorted desc: ");
                foreach(string str in lstStr1)
                {
                    Console.Write("{0} ", str);
                }
            }
            else
            {
                Console.WriteLine("\nList was not sorted. Reason: The list is empty ");
            }
        }

        public int CountStringLength(string str1)
        {
            var strLenght = 0; 
            if (!String.IsNullOrEmpty(str1))
            {
                char[] char1 = str1.ToCharArray(); 
                foreach(char ch in char1)
                {
                    strLenght ++; 
                }    
                Console.WriteLine("\n ");           
            }
            else
            {
                Console.WriteLine("\n\nString is null. ");
            }   
            return strLenght;            
        }
    }
}