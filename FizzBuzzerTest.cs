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
        [TestCase(1,1)]
        [TestCase(2, 2)]
        [TestCase(4, 4)]
      
       


        public void GetOutput_WhenCalled(int num, int res)
        {
            // a simple example to start you off
            Assert.AreEqual(num, FizzBuzz1(res));
        }


        public static int FizzBuzz1(int res)
        {
            return res;

        }
}
}
