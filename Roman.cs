
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RomanTest
{
    [TestFixture]
    public class RomanTest
    {

            [TestCase(1,"I")]
            [TestCase(3, "III")]
            [TestCase(9, "IX")]
            [TestCase(1066, "MLXVI")]
            [TestCase(1989, "MCMLXXXIX")]
      

        public void GetOutput_WhenCalled(int num, string roman)
        {
            // a simple example to start you off
            Assert.AreEqual(num , RomanNum.Parse(roman));
        }   
    }

    public class RomanNum
    {
        private static readonly Dictionary<char, int> map =
            new Dictionary<char, int>()
            {
                     {'I', 1 },
                     {'V' , 5 },
                     {'X' , 10 },
                     {'L' , 50 },
                     {'C' , 100 },
                     {'D' , 500 },
                     {'M' , 1000 }
            };

        public static int Parse(string roman)
        {
            int result = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && IsSubtractive(roman[i], roman[i+1]))
                {
                    result -= map[roman[i]];
                }
                else
                {
                    result += map[roman[i]];
                }
            }

            return result;

        }

        private static bool IsSubtractive(char c1, char c2)
        {
            return map[c1] < map[c2];
        }

    }
}