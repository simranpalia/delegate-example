using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSampleApp
{

    class Program
    {
        public delegate int AddNumbers(int a, int b);

        public class TestClass
        {
            public void addNumbersVoid(int n1, int n2)
            {
                int res = n1 + n2;
            }

            public int addNumbersInt(int n1, int n2)
            {
                return n1 + n2;
            }
        }

        static void Main(string[] args)
        {
            AddNumbers addNumbersObj = new AddNumbers(new TestClass().addNumbersInt);
            Console.WriteLine(addNumbersObj(5, 5));
            Console.ReadLine();
        }
    }
}
