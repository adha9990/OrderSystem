using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class Main : Form
    {
        private ProductController _productController = new ProductController();
        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 表單讀取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoad(object sender, EventArgs e)
        {
            CreateProductTabControl();

        }
        /// <summary>
        /// 產生商品類型頁籤集合
        /// </summary>
        private void CreateProductTabControl()
        {
            foreach (string type in _productController.GetTypes())
            {
                TabPage tabPage = new TabPage();

                tabPage.Text = type;

                _productTabControl.TabPages.Add(tabPage);

                CreateProductTabPageButton(tabPage, type);
            }
        }
        /// <summary>
        /// 產生商品頁籤按鈕
        /// </summary>
        private void CreateProductTabPageButton(TabPage tabPage, string type)
        {
            int count = 0;

            foreach (Product product in _productController.GetProductByType(type))
            {
                Button button = new Button();
                button.Tag = product._id;
                button.Size = new Size(80, 80);
                button.Location = new Point(10 + 85 * (count % 6), 5 + 80 * (count / 6));
                button.BackgroundImage = Image.FromFile(product._imageLink);
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.Click += new EventHandler(ClickProductButton);
                //button
                tabPage.Controls.Add(button);

                count++;
            }
        }
        /// <summary>
        /// 商品按鈕被點擊時觸發事件
        /// </summary>
        private void ClickProductButton(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string id = button.Tag.ToString();
            Product product = _productController.GetProductById(id);

            _productDescriptionLabel.Text = product._description;
            _productPriceLabel.Text = "建議售價:"+product._price.ToString()+"元";
        }
    }
}
