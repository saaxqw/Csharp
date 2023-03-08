using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Описать структуру Client содержащую поля: код
//клиента; ФИО; адрес; телефон; количество заказов
//осуществленных клиентом; общая сумма заказов
//клиента.

namespace Csharp_hw3
{
    public class Client
    {
        private string clientCode;
        private string fio;
        private string address;
        private string phone;
        private int ordersCnt;
        private int totalOrdersSum;
        private ClientType type;

        public enum ClientType
        {
            Inconsiderable, So_So, Significant, Topmost
        }
        public string ClientCode
        {
            get { return clientCode; }
            set
            {
                clientCode = value;
            }
        }
        public string Fio
        {
            get { return fio; }
            set
            {
                fio = value;
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }
        public int OrdersCnt
        {
            get { return ordersCnt; }
            set
            {
                ordersCnt = value;
            }
        }
        public int TotalOrdersSum
        {
            get { return totalOrdersSum; }
            private set
            {
                totalOrdersSum = value;
            }
        }

        public Client()
        {
            this.clientCode = string.Empty;
            this.fio = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.ordersCnt = 0;
            this.totalOrdersSum = 0;
            this.type = 0;
        }

        public Client(string clientCode, string fio, string address, string phone, int ordersCnt, int totalOrdersSum)
        {
            this.clientCode = clientCode;
            this.fio = fio;
            this.address = address;
            this.phone = phone;
            this.ordersCnt = ordersCnt;
            this.totalOrdersSum = totalOrdersSum;
            if (this.TotalOrdersSum < 1000)
            {
                this.type = ClientType.Inconsiderable;
            }
            else if (this.TotalOrdersSum > 1000 && this.TotalOrdersSum <= 5000)
            {
                this.type = ClientType.So_So;
            }
            else if (this.TotalOrdersSum > 5000 && this.TotalOrdersSum <= 25000)
            {
                this.type = ClientType.Significant;
            }
            else
            {
                this.type = ClientType.Topmost;
            }
        }

        public Client DeepCopy(Client currentClient)
        {
            Client newClient = new Client();

            newClient.clientCode = currentClient.clientCode;
            newClient.fio = currentClient.fio;
            newClient.address = currentClient.address;
            newClient.phone = currentClient.phone;
            newClient.ordersCnt = currentClient.ordersCnt;
            newClient.TotalOrdersSum = currentClient.TotalOrdersSum;
            newClient.type = currentClient.type;

            return newClient;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"client code = {clientCode}\n");
            sb.Append($"fio = {fio}\n");
            sb.Append($"address = {address}\n");
            sb.Append($"phone = {phone}\n");
            sb.Append($"orders cnt = {OrdersCnt}\n");
            sb.Append($"total orders sum = {totalOrdersSum}");
            sb.Append($"type = {type}");
            return sb.ToString();
        }


    }
}
