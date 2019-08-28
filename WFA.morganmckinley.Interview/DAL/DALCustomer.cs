using DevExpress.XtraWaitForm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WFA.morganmckinley.Interview.Models;

namespace WFA.morganmckinley.Interview.DAL
{
    public static class DALCustomer
    {
        public static bool ThreadSleepEnable = true;
        public const int ThreadSleepInSeconds = 3;
        public static void ValidateCustomer(string firstName, string lastName, Action<bool> callback,Action<Exception> failcallback)
        {
            RunInASeparatedThread(ValidateCustomerThread, new Tuple<string, string, Action<bool>, Action<Exception>>(firstName, lastName, callback,failcallback));
        }
        public static void SaveCustomer(Guid customerId, string firstName, string lastName, Action callback, Action<Exception> failcallback)
        {
            RunInASeparatedThread(SaveCustomerThread, new Tuple<Guid,string,string, Action, Action<Exception>>(customerId,firstName,lastName,callback,failcallback));
        }
        public static void GetOrdersWithCustomers(Action<List<OrderCustomerModel>> callback, Action<Exception> failcallback)
        {
            RunInASeparatedThread(GetOrdersWithCustomersThread, new Tuple<Action<List<OrderCustomerModel>>, Action<Exception>>(callback, failcallback));
        }
        public static void GetCustomerById(Guid customerId,Action<Customer> callback, Action<Exception> failcallback)
        {
            RunInASeparatedThread(GetCustomerByIdThread, new Tuple<Guid, Action<Customer>, Action<Exception>>(customerId, callback, failcallback));
        }
        private static void ValidateCustomerThread(object obj)
        {
            var tobject = obj as Tuple<string, string, Action<bool>, Action<Exception>>;
            try
            {
                bool ret;
                if (ThreadSleepEnable)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(ThreadSleepInSeconds));
                }
                using (var db = new OrdersContext())
                {
                    ret = !db.Customer.Any(x => x.FirstName.Equals(tobject.Item1) && x.LastName.Equals(tobject.Item2));
                }
                tobject.Item3.Invoke(ret);
            }
            catch (Exception ex)
            {
                tobject.Item4.Invoke(ex);
            }
        }
        private static void SaveCustomerThread(object obj)
        {
            var tobject = obj as Tuple<Guid, string, string, Action, Action<Exception>>;
            try
            {
                if (ThreadSleepEnable)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(ThreadSleepInSeconds));
                }
                using (var db = new OrdersContext())
                {
                    var customer = db.Customer.FirstOrDefault(x => x.Id.Equals(tobject.Item1));
                    customer.FirstName = tobject.Item2;
                    customer.LastName = tobject.Item3;

                    db.SaveChanges();
                }
                tobject.Item4.Invoke();
            }
            catch (Exception ex)
            {
                tobject.Item5.Invoke(ex);
            }
}
        private static void GetOrdersWithCustomersThread(object obj )
        {
            var tobject = obj as Tuple<Action<List<OrderCustomerModel>>, Action<Exception>>;
            try
            {
                var ret = new List<OrderCustomerModel>();
                if (ThreadSleepEnable)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(ThreadSleepInSeconds));
                }
                using (var db = new OrdersContext())
                {
                    ret = db.Order.Include(nameof(Customer)).Select(OrderCustomerModel.GetOrderCustomer).ToList();
                }
                tobject.Item1.Invoke(ret);
            }
            catch (Exception ex)
            {
                tobject.Item2.Invoke(ex);
            }
          
        }
        private static void GetCustomerByIdThread(object obj)
        {
            var tobject = obj as Tuple<Guid, Action<Customer>, Action<Exception>>;
            try
            {
                Customer customerRet;
                if (ThreadSleepEnable)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(ThreadSleepInSeconds));
                }
                using (var db = new OrdersContext())
                {
                    customerRet = db.Customer.FirstOrDefault(x => x.Id.Equals(tobject.Item1));
                }

                tobject.Item2.Invoke(customerRet);
            }
            catch (Exception ex)
            {
                tobject.Item3.Invoke(ex);
            }
        }
        private static void RunInASeparatedThread(ParameterizedThreadStart _ParameterizedThreadStart, object obj)
        {
            new Thread(_ParameterizedThreadStart).Start(obj);
        }
    }
}
