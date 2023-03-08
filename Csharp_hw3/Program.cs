using System;

namespace Csharp_hw3
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nARTICLE");
            Article article1 = new Article("aa0000", "Pizza", 25000, Article.ArticleType.Foods);
            Article article2 = new Article("aa0001", "Pants", 45000, Article.ArticleType.Clothes);
            Article article3 = new Article("aa0002", "Table", 65000, Article.ArticleType.Furniture);
            Console.WriteLine(article1);
            Console.WriteLine(article2);
            Console.WriteLine(article3);


            Console.WriteLine("\nCLIENT");
            Client client1 = new Client("bb0001", "Joker", "Manhattan", "777777777", 30, 13000);
            Console.WriteLine(client1);


            Console.WriteLine("\nREQUEST ITEM");
            RequestItem item1 = new RequestItem(article1, 3);
            Console.WriteLine(item1);



            Console.WriteLine("\nREQUEST");

            List<RequestItem> ItemList1 = new List<RequestItem>();
            ItemList1.Add(item1);
            ItemList1.Add(new RequestItem() { Product = article2, ProductCnt = 1 });
            ItemList1.Add(new RequestItem() { Product = article3, ProductCnt = 2 });
            Request request1 = new Request("cc0001", client1, new DateTime(1582, 10, 5), Request.PayType.Cash, ItemList1);
            request1.PrintRequest();
        }
    }
}