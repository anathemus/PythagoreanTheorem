using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTheorem
{
    class Pythagorean 
    {
        public int a, b, c;
        public String[] coversion;

        public Pythagorean(String[] conversion) 
        {
            a = Convert.ToInt32(conversion[0]);
            b = Convert.ToInt32(conversion[1]);
            c = Convert.ToInt32(conversion[2]);
            if ((a*a)+(b*b) > (c*c))
            {
                Console.WriteLine("Acute");
            }
            else if ((a*a)+(b*b) == (c*c))
            {
                Console.WriteLine("Right");
            }
            else 
            {
                Console.WriteLine("Obtuse");
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            
            Pythagorean triangle = new Pythagorean(split_elements);

            Console.ReadLine();
        }
    }
}
