using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Exercicio_Enumeracao_ComposicaoUML.Entities.Enums;

namespace Exercicio_Enumeracao_ComposicaoUML.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
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
            double Total = 0;
            foreach (OrderItem item in Items)
            {
                Total += item.SubTotal();
            }
            return Total;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate.ToString("dd/MM/yyyy") + ")" + " - " + Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.Append(item.Product.Name.ToString());
                sb.Append(", " + item.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: " + item.Quantity);
                sb.AppendLine(", Subtotal: $" + item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
