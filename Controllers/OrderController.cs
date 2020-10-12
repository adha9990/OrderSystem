using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class OrderController
    {
        private List<Product> products = new List<Product>();
        /// <summary>
        /// 取得訂單總價
        /// </summary>
        public int GetAmount() {
            int total = 0;
            foreach(Product product in products)
            {
                total += product._price;
            }
            return total;
        }
        /// <summary>
        /// 新增訂單
        /// </summary>
        public void AddOrder(Product product)
        {
            products.Add(product);
        }
    }
    
}
