using Client_OrderProject.Entities.Enums;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Client_OrderProject.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (var i in Items)
            {
                sum += i.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.Append(Client.Name);
            sb.Append(" " + Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.AppendLine(" - " + Client.Email);

            sb.AppendLine("Order items:");

            foreach (var item in Items)
            {
                sb.AppendLine(item.Product.Name + ", $" + item.Price + ", " + item.Quantity + ", SubTotal: $" + item.SubTotal());
            }

            sb.AppendLine("Total Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
