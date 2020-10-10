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
                //tabPage.Tag = type;

                _productTabControl.TabPages.Add(tabPage);
            }
        }
        /// <summary>
        /// 產生商品頁籤按鈕
        /// </summary>
        private void CreateProductTabPageButton()
        {
            // 新增 Button
            //Button _button = new Button();
            //_button.Name = "_product" + _p._id + "TabPageButton";
            //_button.Size = new Size(80, 80);
            //_button.BackgroundImage = Image.FromFile(_p._imageLink);
            //_button.BackgroundImageLayout = ImageLayout.Stretch;
            //_tabPage.Controls.Add(_button);
        }
        
    }
}
