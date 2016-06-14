using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maciej_Jedrzejko_Kolokwium140616
{
    public class Program
    {
        public static int Cars(int[] a)
        {
            int valueOfCars = 0;
            int N = 50;
            for(int i=0;i<50;i++)
            {
                if (a[i] < a[i + 1])
                   valueOfCars ++; 
            }
            //Todo checking whole array, not only next car in it
            
            return valueOfCars;
        }
        //Todo method Cars(int[] a) resolving problem given on paper.

         

        public static void Main(string[] args)

        {
            int[] a = { 0, 1, 0, 1, 1 };
            Cars(a);
        }
    }
}
