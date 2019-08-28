using System;
using System.Collections.Generic;

namespace WFA.morganmckinley.Interview.Models
{
    public partial class Order
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string ReferenceNumber { get; set; }
        public decimal OrderValue { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
