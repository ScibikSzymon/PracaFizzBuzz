using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void Divide_ReturnFizz()
        {
            var fb = new FizzBuzz();
            string returnString = fb.DivideBy3(3);
            Assert.AreEqual("Fizz", returnString);
        }

        [Test]
        public void Divide_ReturnBuzz()
        {
            var fb = new FizzBuzz();
            string returnString = fb.DivideBy5(5);
            Assert.AreEqual("Buzz",returnString);
        }
    }
}
