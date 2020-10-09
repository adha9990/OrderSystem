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
        private Controller _controller = new Controller();
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
            //Product products = new Product();
            //products.JsonLoad();
        }
        
    }
}
