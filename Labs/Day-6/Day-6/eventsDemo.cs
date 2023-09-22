using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    delegate void OrderEventHandler();
    class Order
    {
        public event OrderEventHandler onOrderCreated;
        public void Create()
        {
            Console.WriteLine("Order Created");
            //SMS.send();
            //Email.send();
            if (onOrderCreated != null)
            {
                onOrderCreated();
            }
        }
    }
    class SMS
    {
        public static void send()
        {
            Console.WriteLine("SMS sent");
        }
    }
    class Email
    {
        public static void send()
        {
            Console.WriteLine("Email sent");
        }
    }
    internal class eventsDemo
    {
        public static void Main3()
        {
            var Order = new Order();
            Order.onOrderCreated += Email.send;
            Order.onOrderCreated -= Email.send;
            Order.onOrderCreated += SMS.send;
            Order.Create();
        }
    }
}
