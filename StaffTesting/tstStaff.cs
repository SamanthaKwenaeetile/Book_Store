using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //instance of a class
            clsStaff Record = new clsStaff();
            Assert.IsNotNull(Record);

        }
    }
}
