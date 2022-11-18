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


        [TestCase(1, "1")]

        [TestCase(5, "Buzz")]
        [TestCase(20, "Buzz")]
        [TestCase(200, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(45, "FizzBuzz")]
        [TestCase(7, "Pop")]
        [TestCase(28, "Pop")]
        [TestCase(77, "Pop")]
        [TestCase(21, "FizzPop")]
        [TestCase(63, "FizzPop")]
        [TestCase(126, "FizzPop")]
        [TestCase(35, "BuzzPop")]
        [TestCase(70, "BuzzPop")]
        [TestCase(140, "BuzzPop")]
        [TestCase(105, "FizzBuzzPop")]
        [TestCase(210, "FizzBuzzPop")]
        [TestCase(315, "FizzBuzzPop")]
        
        [TestCase(2, "Fuzz")]
        [TestCase(8, "Fuzz")]
        [TestCase(4, "Fuzz")]
        
        [TestCase(9, "Bizz")]
        [TestCase(12, "FuzzBizz")]

        public void GetOutput_WhenCalled(int num, string res)
        {
            // a simple example to start you off
            Assert.AreEqual(res, FizzBuzz2(num));
        }


       private string FizzBuzz2(int num)
       {
            if (num % 5 == 0 && num % 7 == 0 && num % 3 == 0)
                return "FizzBuzzPop";

            if (num %3 == 0 && num % 5 == 0)
                return "FizzBuzz";
            if (num % 3 == 0 && num % 7 == 0)
                return "FizzPop";

            if (num % 5 == 0 && num % 7 == 0)
                return "BuzzPop";

            if (num % 2 == 0 && num % 3 == 0)
                return "FuzzBizz";

            if (num % 3 == 0) 
            return "Bizz";

            if (num % 5 == 0)
                return "Buzz";
            if (num % 7 == 0)
                return "Pop";
            
            if (num % 2 == 0)
                return "fuzz";


            if (num == 1)
                return "1";

            return "";
        }
}
}
