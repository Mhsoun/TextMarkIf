using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMarkIf
{
    class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your mark!");
            _ = float.TryParse(Console.ReadLine(), out float mark);

            if (mark < 0f || mark > 4f)
            {
                if (mark == 5)
                {
                    Console.WriteLine("Pass");
                }
                else if (mark >= 6f && mark < 7.8f)
                {
                    Console.WriteLine("Good");
                }
                else if (mark >= 7.8f && mark < 9.10f)
                {
                    Console.WriteLine("Notable");
                }
                else if (mark <= 9.10f && mark <= 100f)
                {
                    Console.WriteLine("Excellent");
                }
                else
                {
                    Console.WriteLine("Value must be between 0 to 10");
                }
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}

