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
    public partial class FMain : Form
    {
        Employee _employee;
        public FMain(Employee emp)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            _employee = emp;
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            //haha
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyAccount f = new MyAccount(_employee);
            f.ShowDialog();
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

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeManager fr = new EmployeeManager();
            fr.ShowDialog();
        }

        private void quảnLíLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLíSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FqlSanPham fr = new FqlSanPham();
            fr.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fthongke fthongke = new Fthongke();
            fthongke.ShowDialog();
        }

        private void quảnLíBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableManager tableManager = new TableManager();
            tableManager.ShowDialog();
        }

        private void quảnLíNguyênViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FqlNguyenLieu fr = new FqlNguyenLieu();
            fr.ShowDialog();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales fr = new Sales();
            fr.ShowDialog();
        }
    }
}
