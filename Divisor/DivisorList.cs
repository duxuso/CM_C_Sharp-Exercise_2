using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Divisor
{    
    /// <summary>
    /// find divisors of an Integer
    /// </summary>
    public class DivisorList
    {
        // constant positive integer
        public const string POSITIVE_INTEGER = @"^[0-9]*[1-9][0-9]*$"; 

        public DivisorList() { }

        // Get divisors
        public static List<int> Divisors(int num) 
        {
            List<int> divisors = new List<int>();

            if (num > 0)
            {                
                for (int i = 1; i < num + 1; i++)
                {
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
            return divisors;
        }

        // Check the input positive integer by regular expression
        public static bool isPositiveInt(string str_num) 
        {
            return Regex.IsMatch(str_num, POSITIVE_INTEGER);
        }

        // Get divisors (user inputs)
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

        // print result to console
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
        
        public static void Main()
        {
            // prepare the sample integers
            int n1 = 60;
            int n2 = 42;
            List<int> list = new List<int>();
                     
            // call divisor method  
            list = DivisorList.Divisors(n1);

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

            list = DivisorList.Divisors(input);
            Console.WriteLine("\nDivisors of \"{0}\" is:", input);
            printList(list);

            Console.ReadLine();
        }
    }   
}
