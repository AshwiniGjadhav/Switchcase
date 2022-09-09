using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.ENGLISH");
            Console.WriteLine("1.HINDI");
            Console.WriteLine("1.MARATHI");
            Console.WriteLine("SELECT YOUR OPTION");

            int num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1:
                      Console.WriteLine("YOU HAVE SELECTED EHGLISH");
                       break;

                case 2:
                     Console.WriteLine("YOU HAVE SELECTED HINDI");
                      break;

                case 3:
                      Console.WriteLine("YOU HAVE SELECTED EHGLISH");
                      break;

               default:
                    Console.WriteLine("YOU INVILID OPTION");
                    break;

            }
        }
    }
}
