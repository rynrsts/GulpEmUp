using System;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Point_of_Sales__POS_
{
    public partial class LogIn : Form
    {
        static Color gray97Temp = Color.FromArgb(0xF7F7F7);
        static Color darkCyanBlueTemp = Color.FromArgb(0x263947);
        
        Color gray97 = Color.FromArgb(gray97Temp.R, gray97Temp.G, gray97Temp.B);
        Color darkCyanBlue = Color.FromArgb(darkCyanBlueTemp.R, darkCyanBlueTemp.G, darkCyanBlueTemp.B);

        DatabaseConfig dc = new DatabaseConfig();

        public LogIn()
        {
            InitializeComponent();
            //con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\raymon\\My Documents\\Visual Studio 2015\\Projects\\Point of Sales (POS) - Gulp 'Em Up\\Point of Sales.accdb";
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            pcbxLogIn.BackColor = darkCyanBlue;
            lblUser.BackColor = darkCyanBlue;
            txtbxUser.BackColor = gray97;
            lblPass.BackColor = darkCyanBlue;
            txtbxPass.BackColor = gray97;
            btnLogin.BackColor = gray97;
            btnLogin.ForeColor = darkCyanBlue;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxUser.Text))
            {
                MessageBox.Show("Please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxUser.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtbxPass.Text))
            {
                MessageBox.Show("Please enter your password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxPass.Focus();
                return;
            }

            try
            {
                dc.con.Open();
                dc.query = "select * from tblLogin where STRCOMP(Username, @user, 0)=0 and STRCOMP(Password, @pass, 0)=0";
                dc.cmd = new OleDbCommand(dc.query, dc.con);
                dc.cmd.Parameters.AddWithValue("@user", txtbxUser.Text);
                dc.cmd.Parameters.AddWithValue("@pass", txtbxPass.Text);
                dc.cmd.ExecuteNonQuery();
                dc.reader = dc.cmd.ExecuteReader();

                int count = 0;

                while (dc.reader.Read())
                {
                    count += 1;
                    lblUserType.Text = dc.reader["UserType"].ToString();
                }

                if (count == 1)
                {
                    POSGulpEmUp pos = new POSGulpEmUp();
                    Manager man = new Manager();
                    Inventory inv = new Inventory();                   

                    pos.containeruser.Text = txtbxUser.Text;
                    man.containeruser.Text = txtbxUser.Text;
                    inv.containeruser.Text = txtbxUser.Text;                   

                    MessageBox.Show("You have been successfully logged in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dc.query = "insert into tblaudit ([user],[status],[sdate]) values ('"+txtbxUser.Text+"', 'Logged in','"+dateTimePicker1.Text+"')";
                    dc.cmd = new OleDbCommand(dc.query, dc.con);
                    dc.cmd.ExecuteNonQuery();

                    if (lblUserType.Text == "Cashier")
                    {
                        POSGulpEmUp form1 = new POSGulpEmUp();
                        form1.Show();
                        this.Hide();
                    }
                    else if (lblUserType.Text == "Manager")
                    {
                        Manager form3 = new Manager();
                        form3.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbxUser.Text = "";
                    txtbxPass.Text = "";
                    txtbxUser.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxUser.Focus();
            }

            dc.con.Close();
        }
    }
}
