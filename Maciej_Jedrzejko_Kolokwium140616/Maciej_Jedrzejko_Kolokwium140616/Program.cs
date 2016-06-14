using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maciej_Jedrzejko_Kolokwium140616
{
    public class Program
    {
        public static double Cars(int[] a)
        {
            double valueOfCars = 0;
            int N = 50;
            for(int i=0;i<N;i++)
            {
                for (int j=0;j<N;j++)
                {
                    if (a[i] < a[j])
                        valueOfCars++;
                }
                 
            }

            if (valueOfCars > 1000000000) valueOfCars = -1; // tooManyPasses: if theres more then 1 000 000 000 valueOfCars = -1
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
