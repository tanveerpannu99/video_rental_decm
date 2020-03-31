using Microsoft.VisualStudio.TestTools.UnitTesting;
using video_rental_decm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_rental_decm.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 obj = new Form1();

        }
        [TestMethod()]
        public void RentalTest()
        {
            RentalClass obj = new RentalClass();

        }


    }
}