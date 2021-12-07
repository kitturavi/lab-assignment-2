using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_assignment_2
{
    internal class ascii
    {
        static void Main ()
        {
            Console.WriteLine("Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());
            Char a = Convert.ToChar(num);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
