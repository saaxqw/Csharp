using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Описать структуру RequestItem содержащую поля:
//товар; количество единиц товара.

namespace Csharp_hw3
{
    public class RequestItem
    {
        public Article Product;
        private int productCnt;
        public int ProductCnt { get { return productCnt; } set { productCnt = value; } }

        public RequestItem()
        {
            productCnt = 0;
            
        }
        public RequestItem(Article product, int productCnt)
        {
            this.Product = product.DeepCopy(product);
            this.productCnt = productCnt;
        }

        public RequestItem DeepCopy(RequestItem current)
        {
            RequestItem copied = new RequestItem();

            copied.Product = current.Product.DeepCopy(current.Product);
            copied.productCnt = current.productCnt;

            return copied;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"product = {Product}\n");
            sb.Append($"product cnt = {productCnt}");

            return sb.ToString();
        }


    }
}
