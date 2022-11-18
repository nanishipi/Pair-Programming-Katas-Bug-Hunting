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
        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(123,"Fizz")]
        public void GetOutput_WhenCalled(int num, string res)
        {
            // a simple example to start you off
            Assert.AreEqual(res, FizzBuzz2(num));
        }


       public static string FizzBuzz2(int num)
       {
            if (num % 3 == 0) 
            return "Fizz";

            return "";
        }
}
}
