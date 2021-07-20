using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Point_of_Sales__POS_
{
    public partial class Pay : Form
    {
        static Color darkCyanBlueTemp = Color.FromArgb(0x263947);
        static Color gray97Temp = Color.FromArgb(0xF7F7F7);
        static Color greenTemp = Color.FromArgb(0x00BF6F);

        Color darkCyanBlue = Color.FromArgb(darkCyanBlueTemp.R, darkCyanBlueTemp.G, darkCyanBlueTemp.B);
        Color gray97 = Color.FromArgb(gray97Temp.R, gray97Temp.G, gray97Temp.B);
        Color green = Color.FromArgb(greenTemp.R, greenTemp.G, greenTemp.B);

        POSGulpEmUp POSGEU;
        DatabaseConfig con = new DatabaseConfig();
        OleDbDataAdapter da;

        double totalPayable;
        double tendered;
        double change;
        string changeS;

        public Pay(POSGulpEmUp POS)
        {
            POSGEU = POS;
            InitializeComponent();
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            txtbxTotalPay.BackColor = gray97;
            txtbxTendered.BackColor = gray97;
            txtbxChange.BackColor = gray97;
            btnPay.BackColor = green;
        }

        private void txtbxTendered_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxTendered.Text))
            {
                txtbxChange.Clear();
                return;
            }

            string actualdata = string.Empty;
            char[] entereddata = txtbxTendered.Text.ToCharArray();
            foreach (char aChar in entereddata.AsEnumerable())
            {
                if (Char.IsDigit(aChar))
                {
                    actualdata = actualdata + aChar;
                }
                else
                {
                    actualdata.Replace(aChar, ' ');
                    actualdata.Trim();
                }
            }
            txtbxTendered.Text = actualdata;

            try
            {
                totalPayable = Convert.ToDouble(txtbxTotalPay.Text);
                tendered = Convert.ToDouble(txtbxTendered.Text);
                change = tendered - totalPayable;
                changeS = Convert.ToString(change);
                txtbxChange.Text = changeS;
            }
            catch (Exception)
            {
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            POSGEU = new POSGulpEmUp();
            MessageBox.Show("Thank you for purchasing!");
            con.con.Open();
            con.cmd = new OleDbCommand("DELETE * FROM tblinvoice", con.con);
            con.cmd.ExecuteNonQuery();
            da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblinvoice");
            POSGEU.dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
            con.query = "insert into tblaudit ([user],[status],[sdate]) values ('" + containeruser.Text + "', 'Transaction','" + dateOne.Text + "')";
            con.cmd = new OleDbCommand(con.query, con.con);
            con.con.Close();

            POSGEU.txtbxTotal.Clear();
            POSGEU.pprice = 0;
            POSGEU.txtbxDiscount.Clear();
            POSGEU.txtbxPayable.Clear();
            POSGEU.Refresh();
            this.Close();
        }
    }
}
