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
            //Todo test unit checking if car passed beyond 1 000 000 000 return -1

            //Todo test unit checking if car passed counting  method works properly
            int[] a1 = { 0, 1, 0, 1, 1 };
            Assert.AreEqual(Program.Cars(a1), 5);


            Assert.Fail();
        }
    }
}