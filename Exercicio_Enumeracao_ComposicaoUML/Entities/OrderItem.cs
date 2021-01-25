namespace Exercicio_Enumeracao_ComposicaoUML.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
