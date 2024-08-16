using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProductInfo : Form
    {
        private int selectedProductNum;
        public ProductInfo(int getProductNum)
        {
            this.selectedProductNum = getProductNum;
            InitializeComponent();
        }

    }
}
