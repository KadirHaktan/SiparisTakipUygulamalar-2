using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Siparis.BusinessLogic.Concart;
using Moq;
using Siparis.DataAccess.Abstract;
using Siparis.Entity;
using FluentValidation;
using System.Collections.Generic;

namespace Siparis.BusinessLogicTest
{
    [TestClass]
    public class BusinessLogicTest
    {
       

     
    

        [TestMethod]
        public void SiparisManagerTest1()
        {
            Mock<ISiparisDAL> siparis_dal = new Mock<ISiparisDAL>();

            SiparisManager siparis_manager = new SiparisManager(siparis_dal.Object);

            siparis_manager.Add(new _Siparis
            {
                Urun_ID = 1,
                Musteri_ID = 1003
            });

        }

        [TestMethod]
        public void MusteriManagerTest3()
        {
            Mock<IMusteriDAL> dal = new Mock<IMusteriDAL>();
            Mock<ITelefonDAL> dal1 = new Mock<ITelefonDAL>();

            MusteriManager manager = new MusteriManager(dal.Object);

            var result=manager.GetAllCustomers();

            Assert.AreEqual(null, result);
        }

    }
}
