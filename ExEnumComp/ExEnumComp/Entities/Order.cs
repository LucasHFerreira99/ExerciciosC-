using ExEnumComp.Entities.Enums;
using System.Text;
using System.Globalization;

namespace ExEnumComp.Entities
{
    internal class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; } 
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>(); 

        public Order() { }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
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
            foreach (OrderItem item in Items)
            {
                sum += item.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            double sum=0; 

            sb.Append("Order moment: ");
            sb.AppendLine(Date.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");

            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
                sum += item.subTotal();
            }
            sb.Append("Total price: $");
            sb.AppendLine(sum.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }

    }
}
