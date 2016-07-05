using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string gameString { get; set; }
        public int DivideBy3(int a)
        {
            return a%3;
        }

        public int DivideBy5(int a)
        {
            return a%5;
        }

        public void Start()
        {
            for (int i = 0; i < 100; i++)
            {
                if (DivideBy3(i) == 0)
                {
                    gameString += "Fizz";
                }
                else if (DivideBy5(i) == 0)
                {
                    gameString += "Buzz";
                }
                else
                {
                    gameString += i.ToString();
                }
            }
        }
    }
}
