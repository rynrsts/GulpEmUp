using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Point_of_Sales__POS_
{
    public partial class Manager : Form
    {
        static Color darkCyanBlueTemp = Color.FromArgb(0x263947);
        static Color gray97Temp = Color.FromArgb(0xF7F7F7);
        static Color grayTemp = Color.FromArgb(0xB1B8BD);
        static Color greenTemp = Color.FromArgb(0x00BF6F);
        static Color orangeTemp = Color.FromArgb(0xF9BE00);

        Color darkCyanBlue = Color.FromArgb(darkCyanBlueTemp.R, darkCyanBlueTemp.G, darkCyanBlueTemp.B);
        Color gray97 = Color.FromArgb(gray97Temp.R, gray97Temp.G, gray97Temp.B);
        Color gray = Color.FromArgb(grayTemp.R, grayTemp.G, grayTemp.B);
        Color green = Color.FromArgb(greenTemp.R, greenTemp.G, greenTemp.B);
        Color orange = Color.FromArgb(orangeTemp.R, orangeTemp.G, orangeTemp.B);

        DatabaseConfig dc = new DatabaseConfig();
        OleDbDataAdapter da;
        public DataTable dt = new DataTable();

        public Manager()
        {
            InitializeComponent();

            dc.con.Open();
            dc.query = "SELECT * from tblLogIn";
            dc.cmd = new OleDbCommand(dc.query, dc.con);
            da = new OleDbDataAdapter(dc.cmd);
            da.Fill(dt);
            dtgrdUpdate.DataSource = dt;
            dc.con.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            btnEmployee.BackColor = darkCyanBlue;
            btnInventory.BackColor = darkCyanBlue;
            btnLogOut.BackColor = darkCyanBlue;

            pnlEmployee.BackColor = gray97;
            dtgrdUpdate.BackgroundColor = gray;
            dtgrdUpdate.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12);
            dtgrdUpdate.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            txtbxID.BackColor = gray97;
            txtbxFi.BackColor = gray97;
            txtbxSu.BackColor = gray97;
            cmbbxTy.BackColor = gray97;
            txtbxUs.BackColor = gray97;
            txtbxPa.BackColor = gray97;
            btnCreate.BackColor = green;
            btnUpd.BackColor = orange;
        }

        public void datagrid()
        {
            try
            {
                txtbxID.Text = dtgrdUpdate.CurrentRow.Cells[0].Value.ToString();
                cmbbxTy.Text = dtgrdUpdate.CurrentRow.Cells[1].Value.ToString();
                txtbxSu.Text = dtgrdUpdate.CurrentRow.Cells[2].Value.ToString();
                txtbxFi.Text = dtgrdUpdate.CurrentRow.Cells[3].Value.ToString();
                txtbxUs.Text = dtgrdUpdate.CurrentRow.Cells[4].Value.ToString();
                txtbxPa.Text = dtgrdUpdate.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
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

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory form10 = new Inventory();
            form10.Show();
            this.Hide();
        }

        private void dtgrdUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            datagrid();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create form7 = new Create(this);
            form7.Show();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (txtbxUs.Text == "" || txtbxPa.Text == "" || txtbxFi.Text == "" || txtbxSu.Text == "")
            {
                MessageBox.Show("Please fill the empty fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dc.con.Open();
                dc.query = "SELECT * from tblLogIn where Username = @user or Firstname = @first and Surname = @sur";
                dc.cmd = new OleDbCommand(dc.query, dc.con);
                dc.cmd.Parameters.AddWithValue("@user", txtbxUs.Text);
                dc.cmd.Parameters.AddWithValue("@first", txtbxFi.Text);
                dc.cmd.Parameters.AddWithValue("@sur", txtbxSu.Text);
                dc.cmd.ExecuteNonQuery();
                dc.reader = dc.cmd.ExecuteReader();
                int count = 0;

                while (dc.reader.Read())
                {
                    count = count + 1;
                    lblConUser.Text = dc.reader["Username"].ToString();
                    lblConFirst.Text = dc.reader["Firstname"].ToString();
                    lblConSur.Text = dc.reader["Surname"].ToString();
                }

                dc.query = "UPDATE tblLogIn SET [Username] = '" + txtbxUs.Text + "', [Password] = '" + txtbxPa.Text + "', [UserType] = '" + cmbbxTy.Text + "', [Firstname] = '" + txtbxFi.Text + "', [Surname] = '" + txtbxSu.Text + "' WHERE [ID] = @id";
                dc.cmd = new OleDbCommand(dc.query, dc.con);
                dc.cmd.Parameters.AddWithValue("@id", txtbxID.Text);
                dc.cmd.ExecuteNonQuery();

                MessageBox.Show("Data has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
                dc.query = "SELECT * from tblLogIn";
                dc.cmd = new OleDbCommand(dc.query, dc.con);
                da = new OleDbDataAdapter(dc.cmd);
                da.Fill(dt);
                dtgrdUpdate.DataSource = dt;

                dc.con.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtbxUs.Text == "" || txtbxPa.Text == "" || txtbxFi.Text == "" || txtbxSu.Text == "")
            {
                MessageBox.Show("Please select a user", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                dc.con.Open();
                dc.query = "DELETE FROM tblLogIn WHERE [ID] = @id";
                dc.cmd = new OleDbCommand(dc.query, dc.con);
                dc.cmd.Parameters.AddWithValue("@id", txtbxID.Text);
                dc.cmd.ExecuteNonQuery();

                MessageBox.Show("Data has been deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
                dc.query = "SELECT * from tblLogIn";
                dc.cmd = new OleDbCommand(dc.query, dc.con);
                da = new OleDbDataAdapter(dc.cmd);
                da.Fill(dt);
                dtgrdUpdate.DataSource = dt;

                txtbxID.Clear();
                txtbxFi.Clear();
                txtbxSu.Clear();
                cmbbxTy.Text = null;
                txtbxUs.Clear();
                txtbxPa.Clear();

                dc.con.Close();
            }
        }

        private void containeruser_Click(object sender, EventArgs e)
        {

        }

        private void btnTrail_Click(object sender, EventArgs e)
        {
            Trail form11 = new Trail();
            form11.Show();
            this.Hide();
        }

        private void pnlEmployee_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
