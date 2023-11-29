using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page_Design_UI
{
    public partial class FMain : Form
    {
        public FMain()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            //haha
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fAccount fr = new fAccount();
            //fr.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNhapHang fr = new FNhapHang();
            fr.ShowDialog();
        }

        private void quảnLíPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQLPhieuNhap fr = new FQLPhieuNhap();
            fr.ShowDialog();
        }
    }
}
