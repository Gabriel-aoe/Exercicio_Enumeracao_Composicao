using System;
using Exercicio_Enumeracao_ComposicaoUML.Entities.Enums;

namespace Exercicio_Enumeracao_ComposicaoUML.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public void AddItem(OrderItem item)
        {

        }
        public void RemoveItem(OrderItem item)
        {

        }
    }
}
