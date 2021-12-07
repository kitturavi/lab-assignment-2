using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_assignment_2
{
    internal class Program
    {
        static void Main ()
        {
            Console.WriteLine("Enter the radius of the circle :");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = 3.14 * radius * radius;
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}
