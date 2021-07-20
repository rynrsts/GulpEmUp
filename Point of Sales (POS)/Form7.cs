using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Point_of_Sales__POS_
{
    public partial class Create : Form
    {
        static Color darkCyanBlueTemp = Color.FromArgb(0x263947);
        static Color gray97Temp = Color.FromArgb(0xF7F7F7);
        static Color greenTemp = Color.FromArgb(0x00BF6F);

        Color darkCyanBlue = Color.FromArgb(darkCyanBlueTemp.R, darkCyanBlueTemp.G, darkCyanBlueTemp.B);
        Color gray97 = Color.FromArgb(gray97Temp.R, gray97Temp.G, gray97Temp.B);
        Color green = Color.FromArgb(greenTemp.R, greenTemp.G, greenTemp.B);

        DatabaseConfig dc = new DatabaseConfig();
        OleDbDataAdapter da;
        Manager form3;

        public Create(Manager manager)
        {
            form3 = manager;

            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {
            txtbxFN.BackColor = gray97;
            txtbxSN.BackColor = gray97;
            cmbbxUT.BackColor = gray97;
            txtbxUN.BackColor = gray97;
            txtbxPW.BackColor = gray97;
            btnAdd.BackColor = green;
            btnCancel.BackColor = darkCyanBlue;
        }

        public void clear()
        {
            txtbxUN.Clear();
            txtbxPW.Clear();
            cmbbxUT.Text = null;
            txtbxFN.Clear();
            txtbxSN.Clear();
        }

        private void txtbxFN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back);
        }

        private void txtbxSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back);
        }

        private void txtbxUN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back);
        }

        private void txtbxPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxSN.Text) || string.IsNullOrEmpty(txtbxFN.Text) || string.IsNullOrEmpty(txtbxUN.Text) || string.IsNullOrEmpty(txtbxPW.Text))
            {
                MessageBox.Show("Please fill the empty fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dc.con.Open();
                dc.query = "select * from tblLogin where Username = @user or Firstname = @first and Surname = @sur";
                dc.cmd = new OleDbCommand(dc.query, dc.con);
                dc.cmd.Parameters.AddWithValue("@user", txtbxUN.Text);
                dc.cmd.Parameters.AddWithValue("@first", txtbxFN.Text);
                dc.cmd.Parameters.AddWithValue("@sur", txtbxSN.Text);
                dc.cmd.ExecuteNonQuery();
                dc.reader = dc.cmd.ExecuteReader();

                int count = 0;

                while (dc.reader.Read())
                {
                    count += 1;
                    lblUser.Text = dc.reader["Username"].ToString();
                    lblFirst.Text = dc.reader["Firstname"].ToString();
                    lblSur.Text = dc.reader["Surname"].ToString();
                }

                if (count == 1)
                {
                    if (txtbxUN.Text == lblUser.Text)
                    {
                        MessageBox.Show("Username already existed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clear();
                    }
                    else if ((txtbxFN.Text == lblFirst.Text) && (txtbxSN.Text == lblSur.Text))
                    {
                        MessageBox.Show("Name already existed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clear();
                    }
                }
                else
                {
                    dc.query = "insert into tblLogin ([UserType], [Surname], [Firstname], [Username], [Password]) values(@usert, @sur, @first, @user, @pass)";
                    dc.cmd = new OleDbCommand(dc.query, dc.con);
                    dc.cmd.Parameters.AddWithValue("@usert", cmbbxUT.Text);
                    dc.cmd.Parameters.AddWithValue("@sur", txtbxSN.Text);
                    dc.cmd.Parameters.AddWithValue("@first", txtbxFN.Text);
                    dc.cmd.Parameters.AddWithValue("@user", txtbxUN.Text);
                    dc.cmd.Parameters.AddWithValue("@pass", txtbxPW.Text);
                    dc.cmd.ExecuteNonQuery();

                    MessageBox.Show("Data has been created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    form3.dt.Clear();
                    dc.query = "SELECT * from tblLogIn";
                    dc.cmd = new OleDbCommand(dc.query, dc.con);
                    da = new OleDbDataAdapter(dc.cmd);
                    da.Fill(form3.dt);
                    form3.dtgrdUpdate.DataSource = form3.dt;

                    this.Close();
                }

                dc.con.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
