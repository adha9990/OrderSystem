using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace OrderSystem
{
    class ProductController
    {
        private const string FILE = "data.json";
        private List<Product> _products = new List<Product>();
        public ProductController()
        {
            InitializeData();
        }

        /// <summary>
        /// 載入JSON資料
        /// </summary>
        private void InitializeData()
        {
            using (StreamReader r = new StreamReader(FILE))
            {
                string json = r.ReadToEnd();
                JavaScriptSerializer _js = new JavaScriptSerializer();
                _products = _js.Deserialize<List<Product>>(json);
            }
        }
        /// <summary>
        /// 取得全部商品的資料
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
        {
            return _products;
        }
        /// <summary>
        /// 取得所有商品類型
        /// </summary>
        /// <returns></returns>
        public List<string> GetTypes()
        {
            return GetProducts().GroupBy(x => x._type).Select(x => x.FirstOrDefault()._type).ToList<string>();
        }
        /// <summary>
        /// 透過商品類型取得商品
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Product> GetProductByType(string type)
        {
            return GetProducts().Where(x => x._type == type).Select(x => x).ToList();
        }
        /// <summary>
        /// 透過商品編號取得商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(string id)
        {
            return GetProducts().Where(x => x._id == id).Select(x => x).FirstOrDefault();
        }
    }
}
