using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzerTest
    {

        [TestCase(1, 1)]
        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(123,"Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(20, "Buzz")]
        [TestCase(200, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(45, "FizzBuzz")]
        [TestCase(315, "FizzBuzz")]
        public void GetOutput_WhenCalled(int num, string res)
        {
            // a simple example to start you off
            Assert.AreEqual(res, FizzBuzz2(num));
        }


       private string FizzBuzz2(int num)
       {
            if (num %3 == 0 && num % 5 == 0)
                return "FizzBuzz";
            if (num % 3 == 0) 
            return "Fizz";
            if (num % 5 == 0)
                return "Buzz";

            return "";
        }
}
}
