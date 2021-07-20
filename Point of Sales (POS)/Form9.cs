using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Point_of_Sales__POS_
{
    public partial class Inventory : Form
    {
        static Color darkCyanBlueTemp = Color.FromArgb(0x263947);
        static Color gray97Temp = Color.FromArgb(0xF7F7F7);
        static Color grayTemp = Color.FromArgb(0xB1B8BD);
        static Color greenTemp = Color.FromArgb(0x00BF6F);

        Color darkCyanBlue = Color.FromArgb(darkCyanBlueTemp.R, darkCyanBlueTemp.G, darkCyanBlueTemp.B);
        Color gray97 = Color.FromArgb(gray97Temp.R, gray97Temp.G, gray97Temp.B);
        Color gray = Color.FromArgb(grayTemp.R, grayTemp.G, grayTemp.B);
        Color green = Color.FromArgb(greenTemp.R, greenTemp.G, greenTemp.B);

        DatabaseConfig dc = new DatabaseConfig();
        OleDbDataAdapter da;
        public DataTable dt = new DataTable();

        public Inventory()
        {
            InitializeComponent();

            dc.con.Open();
            dc.query = "SELECT * from tblInventory";
            dc.cmd = new OleDbCommand(dc.query, dc.con);
            dc.cmd.ExecuteNonQuery();
            da = new OleDbDataAdapter(dc.cmd);
            da.Fill(dt);
            dtgrdInventory.DataSource = dt;
            dc.reader = dc.cmd.ExecuteReader();

            int count = 0;

            while (dc.reader.Read())
            {
                count = count + 1;
                lblQuantity.Text = dc.reader["Quantity"].ToString();
                lblRecipe.Text = dc.reader["Recipe"].ToString();
            }

            dc.con.Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            btnEmployee.BackColor = darkCyanBlue;
            btnInventory.BackColor = darkCyanBlue;
            btnLogOut.BackColor = darkCyanBlue;

            pnlInventory.BackColor = gray97;
            dtgrdInventory.BackColor = gray;
            btnAddRecipe.BackColor = green;
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

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Manager form3 = new Manager();
            form3.Show();
            this.Hide();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            Recipe form8 = new Recipe(this);
            form8.Show();
        }
    }
}
