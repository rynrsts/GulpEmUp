using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Point_of_Sales__POS_
{
    public partial class Sales : Form
    {
        DatabaseConfig dc = new DatabaseConfig();
        OleDbDataAdapter da;
        public DataTable dt = new DataTable();
        public Sales()
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            dc.con.Open();
            MessageBox.Show("You have been successfully logged out", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dc.query = "insert into tblaudit ([user],[status],[sdate]) values ('" + containeruser.Text + "', 'Logged out','" + dateOne.Text + "')";
            dc.cmd = new OleDbCommand(dc.query, dc.con);
            dc.cmd.ExecuteNonQuery();
            LogIn form2 = new LogIn();
            form2.Show();
            this.Hide();
            dc.con.Close();
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Manager form9 = new Manager();
            form9.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory form9 = new Inventory();
            form9.Show();
            this.Hide();
        }

        private void btnTrail_Click(object sender, EventArgs e)
        {
            Trail form9 = new Trail();
            form9.Show();
            this.Hide();
        }
    }
}
