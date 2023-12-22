using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class PublicClass
    {
        private int field;
        public int Property { get; set; }
        public PublicClass()
        {
            Print("Hello");
        }
        public PublicClass(int initialPropertyValue)
        {
            Property = initialPropertyValue;
        }
        public void VoidMetod(int parameter)
        {
            int number1 = 100;
            int result = IntMetod(number1);
            Console.WriteLine("Результат" + result);
        }
        private int IntMetod(int number)
        {
            return number;
        }
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }


    }
}

