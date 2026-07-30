using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("742 Paradise Cove Dr", "Miami", "FL", "USA");
        Customer customer1 = new Customer("Dwayne Johnson", address1);

        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Gaming PC", "GPC100", 1499.99, 1));
        products1.Add(new Product("Xbox Console", "XBX200", 499.99, 1));
        products1.Add(new Product("Bluetooth Headset", "BTH300", 79.99, 2));

        Order order1 = new Order(products1, customer1);

        Address address2 = new Address("88 Yorkville Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Simu Liu", address2);

        List<Product> products2 = new List<Product>();
        products2.Add(new Product("Gaming Mouse", "GM400", 59.99, 1));
        products2.Add(new Product("Mechanical Keyboard", "MK500", 89.99, 1));

        Order order2 = new Order(products2, customer2);

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
            Console.WriteLine();
        }
    }
}