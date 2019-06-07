using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Siparis.DataAccess.Concart.Entity_Framework;
using System.Data.Entity;
using Siparis.Core;


namespace Siparis.DataAccessTest
{
    [TestClass]
    public class DataAccessTest
    {
        [TestMethod]
        public void GetAllCustomers()
        {
            EntityFrameworkMusteriDAL musteri_dal = new EntityFrameworkMusteriDAL();

            var result= musteri_dal.GetAll();

            Assert.AreEqual(4, result.Count);

        }


        [TestMethod]
        public void GetAllPhones()
        {
            EntityFrameworkTelefonDAL telefon_dal = new EntityFrameworkTelefonDAL();

            var result = telefon_dal.GetAll();

            Assert.AreEqual(4, result.Count);
        }

      


    }
}
