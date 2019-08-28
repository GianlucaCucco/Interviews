using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WFA.morganmckinley.Interview.DAL;
using WFA.morganmckinley.Interview.Models;

namespace WFA.morganmckinley.Interview.Tests
{
    [TestClass]
    public class ModelsTest
    {
        [TestMethod]
        public void TestGetOrderCustomer()
        {
            var order = new Order();
            order.Customer = new Customer();
            order.Id = new Guid("5aa955e7-1739-4e0c-ae94-b31a1f09ef3c");
            order.OrderDate = DateTime.Now;
            order.OrderValue = 33.3m;
            order.ReferenceNumber = "1";
            order.CustomerId = new Guid("7e39f2a7-69cd-4a74-9a63-a3a006e8d998");
            order.Customer.Id = new Guid("7e39f2a7-69cd-4a74-9a63-a3a006e8d998");
            order.Customer.FirstName = "FirstName";
            order.Customer.LastName = "LastName";

            var orderCustomer = OrderCustomerModel.GetOrderCustomer(order);
            Assert.AreEqual(orderCustomer.Id, order.Id);
            Assert.AreEqual(orderCustomer.OrderDate, order.OrderDate);
            Assert.AreEqual(orderCustomer.OrderValue, order.OrderValue);
            Assert.AreEqual(orderCustomer.ReferenceNumber, order.ReferenceNumber);
            Assert.AreEqual(orderCustomer.CustomerName, $"{order.Customer.FirstName} {order.Customer.LastName}");
        }
    }
}
