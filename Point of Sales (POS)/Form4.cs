using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Point_of_Sales__POS_
{
    public partial class Void : Form
    {
        static Color darkCyanBlueTemp = Color.FromArgb(0x263947);
        static Color gray97Temp = Color.FromArgb(0xF7F7F7);

        Color darkCyanBlue = Color.FromArgb(darkCyanBlueTemp.R, darkCyanBlueTemp.G, darkCyanBlueTemp.B);
        Color gray97 = Color.FromArgb(gray97Temp.R, gray97Temp.G, gray97Temp.B);

        DatabaseConfig dc = new DatabaseConfig();
        POSGulpEmUp POSGEU;
        DatabaseConfig con = new DatabaseConfig();
        OleDbDataAdapter da;

        public Void(POSGulpEmUp POS)
        {
            POSGEU = POS;
            InitializeComponent();
        }

        private void Void_Load(object sender, EventArgs e)
        {
            txtbxUsename.BackColor = gray97;
            txtbxPassword.BackColor = gray97;
            btnCancel.BackColor = darkCyanBlue;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxUsename.Text))
            {
                MessageBox.Show("Please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxUsename.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtbxPassword.Text))
            {
                MessageBox.Show("Please enter your password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxPassword.Focus();
                return;
            }

            try
            {
                dc.con.Open();
                dc.query = "select * from tblLogin where STRCOMP(Username, @user, 0)=0 and STRCOMP(Password, @pass, 0)=0";
                dc.cmd = new OleDbCommand(dc.query, dc.con);
                dc.cmd.Parameters.AddWithValue("@user", txtbxUsename.Text);
                dc.cmd.Parameters.AddWithValue("@pass", txtbxPassword.Text);
                dc.cmd.ExecuteNonQuery();
                dc.reader = dc.cmd.ExecuteReader();

                int count = 0;

                while (dc.reader.Read())
                {
                    count += 1;
                    lblManager.Text = dc.reader["UserType"].ToString();
                }
                if (count == 1)
                {
                    if (lblManager.Text == "Cashier")
                    {
                        MessageBox.Show("Manager is needed to verify the void", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (lblManager.Text == "Manager")
                    {
                        MessageBox.Show("Void complete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con.con.Open();
                        con.cmd = new OleDbCommand("DELETE * FROM tblinvoice", con.con);
                        con.cmd.ExecuteNonQuery();
                        da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "tblinvoice");
                        POSGEU.dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                        con.con.Close();

                        POSGEU.txtbxTotal.Clear();
                        POSGEU.pprice = 0;
                        POSGEU.txtbxDiscount.Clear();
                        POSGEU.txtbxPayable.Clear();

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbxUsename.Text = "";
                    txtbxPassword.Text = "";
                    txtbxUsename.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxUsename.Focus();
            }

            dc.con.Close();        
        }
    }
}
