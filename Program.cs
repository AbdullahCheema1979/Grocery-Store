using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeGame
{
    class Program
    {
        class Market
        {
            String name;
            double price;
            double discount;
            public Market(string name, double price, double discount)
            {
                this.name = name;
                this.price = price;
                this.discount = discount;
            }
            public void output()
            {
                
                Console.WriteLine("product " + name);
                Console.WriteLine("product price" + price);
                Console.WriteLine("Discounted Percent " + discount);
                double finalprice = price * (1 - (discount / 100));
                Console.WriteLine($"Price after discount is {finalprice}");

            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Welcome to E Mart ----------------");
            Console.WriteLine("Enter Product Name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter origional price");
            double price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter discount percent");
            double discount = Convert.ToDouble(Console.ReadLine());
            Market m = new Market(name, price, discount);
            m.output();
        }
    }
}
