using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maciej_Jedrzejko_Kolokwium140616
{
    public class Program
    {
        public static double Cars(int[] carsTable)
        {
            double valueOfCars = 0;
            int amountOfCars = 50;
            for(int i=0;i< amountOfCars; i++) //First get into the array and select a car
            {
                for (int j=0;j< amountOfCars; j++) //Checking if car from previous for loop passes  other cars
                {
                    if (carsTable[i] < carsTable[j]) //if it does so increase valueOfCars by 1
                        valueOfCars++;
                }
                 
            }

            if (valueOfCars > 1000000000) valueOfCars = -1; // tooManyPasses: if theres more then  1 000 000 000 passes  valueOfCars returns -1
            return valueOfCars;
        }
        
   
         

        public static void Main(string[] args)

        {
            int[] a = { 0, 1, 0, 1, 1 };
            Cars(a);
        }
    }
}
