using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Divisor
{    
    /// <summary>
    /// Class 'DivisorList'
    /// </summary>
    public class DivisorList
    {
        // Create constant positive integer, will be used in 'isPositiveInt' 
        public const string POSITIVE_INTEGER = @"^[0-9]*[1-9][0-9]*$"; 

        /// <summary>
        /// Finding divisors for an positive integer
        ///     1. the integer must be postive, which means not 0 or -#
        ///     2. mod algorithm, 
        ///     when num % i equals 0, i is a divisor of num
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static List<int> Divisors(int num) 
        {
            // create List 'divisors' to store results later 
            List<int> divisors = new List<int>();

            // when num is a positive integer, then %
            if (num > 0)
            {                
                // for-clause, i -> {1,...,num+1},  
                for (int i = 1; i < num + 1; i++)
                {
                    // if satisfied, put i in list
                    if (0 == num % i)
                    {
                        divisors.Add(i);
                    }
                }
            }
            else 
            {
                Console.WriteLine("Integer is negative.");                
            }
            // return the list with divisors
            return divisors;
        }           
         
        /// <summary>
        /// Check the input positive integer by regular expression
        /// </summary>
        /// <param name="str_num"></param>
        /// <returns></returns>
        public static bool isPositiveInt(string str_num) 
        {
            return Regex.IsMatch(str_num, POSITIVE_INTEGER);
        }
               
        /// <summary>
        /// Get divisors from user inputs, this time Divisors gets a string 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static List<int> Divisors(string s)
        {
            List<int> divisors = new List<int>();
            if (isPositiveInt(s))
            {
                int num = Int32.Parse(s);               
                for (int i = 1; i < num + 1; i++)
                {
                    if (0 == num % i)
                    {
                        divisors.Add(i);
                    }
                }
            }
            else if (s.Length == 0)
            {
                Console.WriteLine("Input is empty!");
            }
            else 
            {
                Console.WriteLine("Input is not valid integer!");
            }
            return divisors;  
        }
                 
        /// <summary>
        /// print result to console
        /// </summary>
        /// <param name="l"></param>
        public static void printList(List<int> l) 
        {                                 
            List<int> list = l;

            if (l == null) 
            {               
                Console.WriteLine("Can't not print null.");
            }
            else
            {
                int[] array;
                array = list.ToArray();
                Console.Write("{");
                Console.Write(String.Join(",", array));
                Console.WriteLine("}");
            }
        }
        
        /// <summary>
        /// Call method 'Divisors'
        /// </summary>
        public static void Main(){
            // prepare the sample integers
            int n1 = 60;
            int n2 = 42;
            List<int> list = new List<int>();
                     
            // call divisor method  
            list = Divisors(n1);
            //list = DivisorList.Divisors(n1);

            // print sample 1
            Console.WriteLine("\nDivisors of {0} is:", n1);
            printList(list);

            // print sample 2 
            list = DivisorList.Divisors(n2);
            Console.WriteLine("\nDivisors of {0} is:", n2);
            printList(list);

            // Get user input  
            Console.Write("\nEnter a positive integer:");
            string input = Console.ReadLine();
            
            // Call method Divisors(string s)
            list = Divisors(input);
            Console.WriteLine("\nDivisors of \"{0}\" is:", input);
            printList(list);

            Console.ReadLine();
        }
    }   
}
