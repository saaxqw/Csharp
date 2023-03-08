using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Описать структуру Article, содержащую следующие
//поля: код товара; название товара; цену товара

namespace Csharp_hw3
{
    public class Article
    {
        private string productCode;
        private string title;
        public float Price;
        private ArticleType type;

        public enum ArticleType
        {
            HouseholdChemicals, Foods, Clothes, Furniture
        }

        public string ProductCode { get { return productCode; }
            set
            {
                productCode = value;
            } } 
        public string Title { get { return title; }
            set
            {
                title = value;
            } } 

        public Article()
        {
            this.productCode = string.Empty;
            this.title = string.Empty;
            this.Price = 0;
            this.type = 0;
        }

        public Article(string productCode, string title, int Price, Article.ArticleType Type)
        {
            this.productCode = productCode;
            this.title = title;
            this.Price = Price;
            this.type = Type;
        }

        public Article DeepCopy(Article currentArticle)
        {
            Article newArticle = new Article();

            newArticle.productCode = currentArticle.productCode;
            newArticle.title = currentArticle.title;
            newArticle.Price = currentArticle.Price;
            newArticle.type = currentArticle.type;
            return newArticle;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"product code = {productCode}\n");
            sb.Append($"title = {title}\n");
            sb.Append($"price = {Price}");
            sb.Append($"type = {type}");
            return sb.ToString();
        }

    }
}
