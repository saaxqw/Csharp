using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Описать структуру Request содержащую поля: код
//заказа; клиент; дата заказа; перечень заказанных товаров;
//сумма заказа(реализовать вычисляемым свойством).

namespace Csharp_hw3
{
    public class Request
    {
        private string codeOrder;
        private Client client;
        private DateTime dateOrder;
        private List<RequestItem> items;
        private PayType payment;

        public enum PayType
        {
            Cash, Check, Credit
        }

        public float Sum
        {
            get
            {
                float Sum = 0;
                foreach (RequestItem item in items)
                {
                    Sum += item.ProductCnt * item.Product.Price;
                }
                return Sum;
            }
        }

        public Request(string codeOrder, Client client, DateTime dateOrder, Request.PayType payment, List<RequestItem> items)
        {
            this.codeOrder = codeOrder;
            this.client = client.DeepCopy(client);
            this.dateOrder = dateOrder;
            this.items = items.Select(item => (RequestItem)item.DeepCopy(item)).ToList();
            this.payment = payment;
        }

        public void PrintRequest()
        {
            Console.WriteLine("\n #{0} - {2}\n\n{1} \n\n Payment: {3} \n", codeOrder, client, dateOrder.ToString("yyyy/MM/dd"), payment);
            int i = 0;
            foreach (RequestItem item in items)
            {
                i++;
                Console.WriteLine("{0}.{1}", i, item);
            }
            Console.WriteLine("\nTotal Sum = {0}", Sum);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"#{codeOrder} - {client}");
            sb.Append($"{dateOrder.ToString("yyyy/MM/dd")}");
            sb.Append($"Payment: {payment}");
            int i = 0;
            foreach (RequestItem item in items)
            {
                i++;
                sb.Append($"{i}.{item}");
            }
            sb.Append($"Total Sum = {Sum}");

            return sb.ToString();
        }
    }
}
