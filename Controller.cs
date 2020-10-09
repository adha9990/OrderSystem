using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace OrderSystem
{
    class Controller
    {
        public const string FILE = "data.json";
        private List<Product> _products = new List<Product>();
        public Controller()
        {
            InitializeData();
        }

        /// <summary>
        /// 載入JSON資料
        /// </summary>
        void InitializeData()
        {

            using (StreamReader r = new StreamReader(FILE))
            {
                string json = r.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                _products = js.Deserialize<List<Product>>(json);
            }
        }

    }
}
