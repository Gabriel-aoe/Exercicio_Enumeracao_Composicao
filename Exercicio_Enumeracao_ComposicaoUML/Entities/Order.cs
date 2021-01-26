using System;
using System.Collections.Generic;
using Exercicio_Enumeracao_ComposicaoUML.Entities;
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
        
    }
}
