using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise_1
{
    public class class2
    {
        public void PrintFirstFiveValues(List<int> lstInt1)
        {            
            if (lstInt1.Count > 0) 
            {
                Console.WriteLine("\n\nThe first 5 elements on the list are:");     
                for (int i=0 ; i < 5 ; i++) 
                {
                    Console.Write("{0} ", lstInt1[i]);
                }
            }
            else
            {
                 Console.WriteLine("\n\nNot able to get the first elements of the List. Reason: The list is empty");
            }    
        }

        public void PrintSmallestNumber(List<int> lstInt1)
        {
            if (lstInt1.Count > 0) 
                {
                var smallestNumber = lstInt1[0];
                foreach(int number in lstInt1)
                {
                    if (smallestNumber > number)
                    {
                        smallestNumber = number; 
                    }        
                }
                Console.WriteLine("\n\nSmallest number on the list is {0}", smallestNumber);
            }
            else
            {
                Console.WriteLine("\n\nSmallest number on the list was not calculated. Reason: The list is empty ");
            }
        }

        public void PrintDictionary()
        {
            Hashtable ht = new Hashtable();
            ht.Add("MyKey1", 500);
            ht.Add("MyKey2", 100);
            ht.Add("MyKey3", 800);
            ht.Add("MyKey4", 200);
            ht.Add("MyKey5", 700);
            ht.Add("MyKey6", 600);
            Console.WriteLine("\nDictionary:"); 
            foreach(var key in ht.Keys)
            {
                Console.WriteLine("Key: {0}, Value: {1}", key, ht[key]);
            }
        }
    }
}    