using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maciej_Jedrzejko_Kolokwium140616;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maciej_Jedrzejko_Kolokwium140616.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            
            int[] aTooMuch = { 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0 };
            Assert.AreEqual(Program.Cars(aTooMuch), -1);
            //Solved, called method will return value = -1 for given table if it excels value 1 000 000 000
            int[] a1 = { 0, 1, 0, 1, 1 };
            Assert.AreEqual(Program.Cars(a1), 5);
            //Solved, called method will check if for given table it returns known value.

            
        }
    }
}