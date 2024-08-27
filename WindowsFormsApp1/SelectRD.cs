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
    public partial class SelectRD : Form
    {
        public bool selectReconditioned = false;
        public SelectRD()
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            R_SelectProductNum r_SelectProductNum = new R_SelectProductNum();
            r_SelectProductNum.Show();
        }

        private void selectDefectiveButton_Click(object sender, EventArgs e)
        {
            this.Close();
            D_SelectProductNum d_SelectProductNum = new D_SelectProductNum();
            d_SelectProductNum.Show();
        }
    }
}
