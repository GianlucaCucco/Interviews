using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.morganmckinley.Interview.Models
{
    public class OrderCustomerModel
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string ReferenceNumber { get; set; }
        public decimal OrderValue { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public static OrderCustomerModel GetOrderCustomer(Order order)
        {
            var ret = new OrderCustomerModel();
            ret.Id = order.Id;
            ret.CustomerId = order.CustomerId;
            ret.ReferenceNumber = order.ReferenceNumber;
            ret.OrderValue = order.OrderValue;
            ret.OrderDate = order.OrderDate;
            ret.CustomerName = $"{order.Customer.FirstName} {order.Customer.LastName}";
            return ret;
        }
    }
}
