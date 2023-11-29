using BLL;
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
    public partial class FQLPhieuNhap : Form
    {
        IncomingsBLL incomingsBLL= new IncomingsBLL();
        public FQLPhieuNhap()
        {
            InitializeComponent();
        }

        private void FQLPhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = incomingsBLL.GetAllIncomings();
        }
    }
}
