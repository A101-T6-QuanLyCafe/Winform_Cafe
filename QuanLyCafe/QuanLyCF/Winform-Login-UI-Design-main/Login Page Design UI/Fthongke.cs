﻿using BLL;
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
    public partial class Fthongke : Form
    {
        OrdersBLL ordersBLL = new OrdersBLL();
        public Fthongke()
        {
            InitializeComponent();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (dtpBD.Value > dtpKT.Value || dtpKT.Value<dtpBD.Value)
                { MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc !!"); } 
            else {
                try
                {
                    dataGridView1.DataSource = ordersBLL.GetOrdersByDateRange(dtpBD.Value, dtpKT.Value);
                    if (dataGridView1.Rows.Count <= 0) return;
                    float doanhthu = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        doanhthu += float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }
                    txtTongDoanhThu.Text = doanhthu.ToString() + " $";
                }
                catch (Exception)
                {

                   
                }
              
            }
        }

        private void txtTongDoanhThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpBD_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
