using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Point_of_Sales__POS_
{
    public partial class Recipe : Form
    {
        static Color darkCyanBlueTemp = Color.FromArgb(0x263947);
        static Color gray97Temp = Color.FromArgb(0xF7F7F7);
        static Color greenTemp = Color.FromArgb(0x00BF6F);

        Color darkCyanBlue = Color.FromArgb(darkCyanBlueTemp.R, darkCyanBlueTemp.G, darkCyanBlueTemp.B);
        Color gray97 = Color.FromArgb(gray97Temp.R, gray97Temp.G, gray97Temp.B);
        Color green = Color.FromArgb(greenTemp.R, greenTemp.G, greenTemp.B);

        DatabaseConfig dc = new DatabaseConfig();
        OleDbDataAdapter da;
        Inventory form9;

        public Recipe(Inventory inv)
        {
            form9 = inv;

            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            cmbbxRecipe.BackColor = gray97;
            txtbxQuantity.BackColor = gray97;
            btnAdd.BackColor = green;
            btnCancel.BackColor = darkCyanBlue;
        }

        private void txtbxQuantity_TextChanged(object sender, EventArgs e)
        {
            string actualdata = string.Empty;
            char[] entereddata = txtbxQuantity.Text.ToCharArray();
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
            txtbxQuantity.Text = actualdata;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbbxRecipe.Text == "" || txtbxQuantity.Text == "")
            {
                MessageBox.Show("Nothing to be added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int quantity = Convert.ToInt32(txtbxQuantity.Text);
                int totalquan = 0;
                int total = 0;
                dc.con.Open();
                dc.query = "SELECT * from tblInventory where Recipe = @recipe";
                dc.cmd = new OleDbCommand(dc.query, dc.con);
                dc.cmd.Parameters.AddWithValue("@user", cmbbxRecipe.Text);
                dc.cmd.ExecuteNonQuery();
                dc.reader = dc.cmd.ExecuteReader();

                int count = 0;

                while (dc.reader.Read())
                {
                    count = count + 1;
                    lblConID.Text = dc.reader["ID"].ToString();
                    totalquan = Convert.ToInt32(dc.reader["Quantity"].ToString());
                }
                if (count == 1)
                {
                    total = totalquan + quantity;
                    dc.query = "UPDATE tblInventory SET [Recipe] = '" + cmbbxRecipe.Text + "', [Quantity] = '" + total + "' WHERE [ID] = @id";
                    dc.cmd = new OleDbCommand(dc.query, dc.con);
                    dc.cmd.Parameters.AddWithValue("@id", lblConID.Text);
                    dc.cmd.ExecuteNonQuery();
                    MessageBox.Show("Recipe added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    form9.dt.Clear();
                    dc.query = "SELECT * from tblInventory";
                    dc.cmd = new OleDbCommand(dc.query, dc.con);
                    da = new OleDbDataAdapter(dc.cmd);
                    da.Fill(form9.dt);
                    form9.dtgrdInventory.DataSource = form9.dt;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
