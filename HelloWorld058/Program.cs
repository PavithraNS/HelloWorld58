using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld058
{

    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Test();
            Laptop laptop = new Laptop();
            laptop.Run();
            Console.Read();
        }
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public static void Test()
        {
            Console.WriteLine("Testing");
        }
    }
}
