using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OrderSystem.Helper
{
    class Json
    {
        /// <summary>
        /// 載入JSON資料
        /// </summary>
        public void JsonLoad()
        {
            using (StreamReader r = new StreamReader("product.json"))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject(json);
                Product myDeserializedClass = JsonConvert.DeserializeObject<Product>(json);

            }
        }
    }
}
