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
    public partial class TableManager : Form
    {
        public TableManager()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void TableManager_Load(object sender, EventArgs e)
        {
            
            loadDatagridView();
            btn_active.Enabled = cb_isDelete.Checked;

        }

        private void loadDatagridView()
        {
            if(cb_isDelete.Checked)
            {
                dataGridView1.DataSource = TableTBLL.GetAllTable().Where(x => x.ISDELETE == 1 && x.Name.Contains(txt_search.Text)).Select(x => new { x.TableID, x.Name, x.Note, x.status }).ToList();
            }
            else
            {
                dataGridView1.DataSource = TableTBLL.GetAllTable().Where(x => x.ISDELETE == 0 && x.Name.Contains(txt_search.Text)).Select(x => new { x.TableID, x.Name, x.Note, x.status }).ToList();
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_tableID.Text = string.Empty;
            txt_tableName.Text = string.Empty;
            rtxt_note.Text = string.Empty;
            cb_status.Checked = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tablesT newTable = new tablesT();
            newTable.Name = txt_tableName.Text;
            newTable.Note = rtxt_note.Text;
            string err = TableTBLL.AddTable(newTable);
            if (err.Length > 0)
            {
                MessageBox.Show(err);
                return;
            }
            loadDatagridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tableID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_tableName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            rtxt_note.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if(int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) == 1)
            {
                cb_status.Checked = true;
            }
            else
            {
                cb_status.Checked = false;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_tableID.Text.Length <= 0)
                return;
            tablesT newTable = new tablesT();
            newTable.TableID = int.Parse(txt_tableID.Text);
            newTable.Name = txt_tableName.Text;
            newTable.Note = rtxt_note.Text;
            string err = TableTBLL.EditTable(newTable);
            if (err.Length > 0)
            {
                MessageBox.Show(err);
                return;
            }
            loadDatagridView();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (txt_tableID.Text.Length <= 0)
                return;
            int tableID = int.Parse(txt_tableID.Text);
            string err = TableTBLL.RemoveTable(tableID);
            if (err.Length > 0)
            {
                MessageBox.Show(err);
                return;
            }
            loadDatagridView();
        }

        private void cb_isDelete_CheckedChanged(object sender, EventArgs e)
        {
            loadDatagridView();
            btn_active.Enabled = cb_isDelete.Checked;
            btn_remove.Enabled = !cb_isDelete.Checked;
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            if (txt_tableID.Text.Length <= 0)
                return;
            int tableID = int.Parse(txt_tableID.Text);
            string err = TableTBLL.ActiveTable(tableID);
            if (err.Length > 0)
            {
                MessageBox.Show(err);
                return;
            }
            loadDatagridView();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            loadDatagridView();
        }
    }
}
