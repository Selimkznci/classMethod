using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Customer1 = new Customer();
            Customer1.Name = "Selim";
            Customer1.SurName = "Kazancı";
            Customer1.City = "Kahramanmaraş";
            Customer1.Phone=1111111111;

            Customer Customer2 = new Customer();
            Customer2.Name = "Sueda";
            Customer2.SurName = "Türk";
            Customer2.City = "Kayseri";
            Customer2.Phone = 1345411111;

            Customer Customer3 = new Customer();
            Customer3.Name = "Yaşar";
            Customer3.SurName = "Sayar";
            Customer3.City = "Kahramanmaraş";
            Customer3.Phone = 1111487642;

            Customer Customer4 = new Customer();
            Customer4.Name = "Turgut";
            Customer4.SurName = "Koç";
            Customer4.City = "Rize";
            Customer4.Phone = 1111121111;

            Customer Customer5 = new Customer();
            Customer5.Name = "Emre";
            Customer5.SurName = "Sabancı";
            Customer5.City = "Konya";
            Customer5.Phone = 1345411211;

            Customer Customer6 = new Customer();
            Customer6.Name = "Avni";
            Customer6.SurName = "Arıkan";
            Customer6.City = "Osmaniye";
            Customer6.Phone = 1111487632;

            Customer[] customers = new Customer[] { Customer1, Customer2, Customer3, Customer4, Customer5, Customer6 };
            CustomerManeger customerManeger = new CustomerManeger();
            customerManeger.Add(Customer1);
            customerManeger.Add(Customer2);
            customerManeger.Add(Customer3);
            customerManeger.Add(Customer4);
            customerManeger.Add(Customer5);
            Console.Write("----> Delete : ");
            customerManeger.Del(Customer6);

            customerManeger.List(customers);
        }
    }
}
