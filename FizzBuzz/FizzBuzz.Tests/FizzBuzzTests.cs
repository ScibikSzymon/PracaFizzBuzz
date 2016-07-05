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
        public void GameString()
        {
            var fb = new FizzBuzz();
            fb.GameString = "value";
            Assert.AreEqual(fb.GameString, "value");
        }
        [Test]
        public void Divide_ReturnFizz()
        {
            var fb = new FizzBuzz();
            int sum = fb.DivideBy3(3);
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void Divide_ReturnBuzz()
        {
            var fb = new FizzBuzz();
            int sum = fb.DivideBy5(5);
            Assert.AreEqual(0,sum);
        }
    }
}
