using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Divisor;
using System.Collections.Generic;

namespace DivisorTest
{
    /// <summary>
    /// Test Class DivisorTests
    /// </summary>
    [TestClass]
    public class DivisorTests
    {
        /// <summary>
        /// The first test, when integer is 60
        /// </summary>
        [TestMethod]
        public void Divisors_CompareDivisorsOfSixty()
        {
            // arrange
            int int_sixty = 60;

            List<int> expected_list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60
            };

            List<int> actual_list = Divisor.DivisorList.Divisors(int_sixty);

           // assert
            CollectionAssert.AreEquivalent(expected_list,actual_list);
        }

        /// <summary>
        /// The second test, when integer is negative
        /// </summary>
        [TestMethod]
        public void Divisors_CompareNegativeInteger()
        {             
            // arrange
            int int_negative = -100;                       
            List<int> expected_list = new List<int>();            
            List<int> actual_list = DivisorList.Divisors(int_negative);

            // assert
            CollectionAssert.AreEquivalent(expected_list,actual_list);
        }

        /// <summary>
        /// The third test, when string is '60', user input method
        /// </summary>
        [TestMethod]
        public void Divisors_InputInteger() { 
            // arrange
            string str_sixty = "60";
            List<int> expected_list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60
            };
            List<int> actual_list = DivisorList.Divisors(str_sixty);

            // assert
            CollectionAssert.AreEquivalent(expected_list, actual_list);
        }

        /// <summary>
        /// The fourth test, when string is '-60'
        /// </summary>
        [TestMethod]
        public void Divisors_InputNegativeInteger()
        {
            // arrange
            string str_sixtyn = "-60";
            List<int> expected_list = new List<int>();
            List<int> actual_list = DivisorList.Divisors(str_sixtyn);

            // assert
            CollectionAssert.AreEquivalent(expected_list, actual_list);
        }

        /// <summary>
        /// The fifth test, when string is empty
        /// </summary>
        [TestMethod]
        public void Divisors_InputEmpty()
        {
            // arrange
            string str_empty = "";
            List<int> expected_list = new List<int>();
            List<int> actual_list = DivisorList.Divisors(str_empty);

            // assert
            CollectionAssert.AreEquivalent(expected_list, actual_list);
        }
    }
}
