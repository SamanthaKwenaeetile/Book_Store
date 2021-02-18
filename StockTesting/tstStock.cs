using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data
        private long tstBookID = 9780545010221;
        private string tstBookName = "Harry Potter and the Deathly Hallows";
        private bool tstInStock = true;
        private int tstNumberAvailable = 59;
        private DateTime tstReleaseDate = new DateTime(2007, 7, 21);

        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }
    }
}
