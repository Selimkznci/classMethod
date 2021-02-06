using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManeger
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi :" + customer.Name);
        }
        public void Del(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.Name + " Müşteri Silindi");
        }
        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine("Customer ID : " + customer.Id);
                Console.WriteLine("Müşteri İsmi : " + customer.Name);
                Console.WriteLine("Müşteri Soyadı : " + customer.SurName);
                Console.WriteLine("Müşteri Şehiri : " + customer.City);
                Console.WriteLine("Müşteri Telefonu : " + customer.Phone);
                Console.WriteLine("------------------------------");
            }
        }
    }
}
