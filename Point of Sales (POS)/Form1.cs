using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Point_of_Sales__POS_
{
    public partial class POSGulpEmUp : Form
    {
        static Color blueTemp = Color.FromArgb(0xCDE5FF);
        static Color darkCyanBlueTemp = Color.FromArgb(0x263947);
        static Color darkSlateGrayTemp = Color.FromArgb(0x2F4F4F);
        static Color gray97Temp = Color.FromArgb(0xF7F7F7);
        static Color grayTemp = Color.FromArgb(0xB1B8BD);
        static Color greenTemp = Color.FromArgb(0x00BF6F);
        static Color lightYellowTemp = Color.FromArgb(0xFDEFBF);
        static Color orangeTemp = Color.FromArgb(0xF9BE00);

        Color blue = Color.FromArgb(blueTemp.R, blueTemp.G, blueTemp.B);
        Color darkCyanBlue = Color.FromArgb(darkCyanBlueTemp.R, darkCyanBlueTemp.G, darkCyanBlueTemp.B);
        Color darkSlateGray = Color.FromArgb(darkSlateGrayTemp.R, darkSlateGrayTemp.G, darkSlateGrayTemp.B);
        Color gray97 = Color.FromArgb(gray97Temp.R, gray97Temp.G, gray97Temp.B);
        Color gray = Color.FromArgb(grayTemp.R, grayTemp.G, grayTemp.B);
        Color green = Color.FromArgb(greenTemp.R, greenTemp.G, greenTemp.B);
        Color lightYellow = Color.FromArgb(lightYellowTemp.R, lightYellowTemp.G, lightYellowTemp.B);
        Color orange = Color.FromArgb(orangeTemp.R, orangeTemp.G, orangeTemp.B);

        //Sales form10 = new Sales();

        DatabaseConfig dc = new DatabaseConfig();
        DatabaseConfig con = new DatabaseConfig();
        OleDbDataAdapter da;
        DataTable dt;
        int add = 0;
        int addtotal = 0;
        double aprice = 0;
        double ptotal = 0;

        DataTable tb = new DataTable();
        int itotal = 0;
        double price;
        public double pprice;
        string totalShow;

        public POSGulpEmUp()
        {
            InitializeComponent();

            con.con.Open();
            con.query = "SELECT qty, item, each, total from tblinvoice";
            con.cmd = new OleDbCommand(con.query, con.con);
            con.cmd.ExecuteNonQuery();
            da = new OleDbDataAdapter(con.cmd);
            dt = new DataTable();
            da.Fill(dt);
            dtgrdScreen.DataSource = dt;
            con.cmd = new OleDbCommand("SELECT * from tblInventory", con.con);
            con.cmd.ExecuteNonQuery();
            con.reader = con.cmd.ExecuteReader();

            int count = 0;

            while (con.reader.Read())
            {
                count = count + 1;
                int quan = int.Parse(con.reader["Quantity"].ToString());
                string recipe = con.reader["Recipe"].ToString();

                if (count >= 1)
                {
                    if ("Wings" == recipe)
                    {
                        if (quan < 3)
                        {
                            rdBtn01ThreePcs.Enabled = false;
                        }
                        if (quan < 6)
                        {
                            rdBtn01SixPcs.Enabled = false;
                        }
                        if (quan < 9)
                        {
                            rdBtn01NinePcs.Enabled = false;
                        }
                    }
                    else if ("Onion rings" == recipe)
                    {
                        if (quan < 3)
                        {
                            rdBtn02ThreePcs.Enabled = false;
                        }
                        if (quan < 6)
                        {
                            rdBtn02SixPcs.Enabled = false;
                        }
                        if (quan < 9)
                        {
                            rdBtn02NinePcs.Enabled = false;
                        }
                    }
                    else if ("Potato" == recipe)
                    {
                        if (quan < 3)
                        {
                            btnEnterMojo.Enabled = false;
                        }
                    }
                    else if ("Nachos" == recipe)
                    {
                        if (quan < 3)
                        {
                            btnEnterNach.Enabled = false;
                        }
                    }
                    else if ("Sandwich" == recipe)
                    {
                        if (quan < 3)
                        {
                            rdBtn05ThreePcs.Enabled = false;
                        }
                        if (quan < 6)
                        {
                            rdBtn05SixPcs.Enabled = false;
                        }

                    }
                    else if ("Dynamite" == recipe)
                    {
                        if (quan < 3)
                        {
                            rdBtn06ThreePcs.Enabled = false;
                        }
                        if (quan < 6)
                        {
                            rdBtn06SixPcs.Enabled = false;
                        }
                        if (quan < 9)
                        {
                            rdBtn06NinePcs.Enabled = false;
                        }
                    }
                    else if ("R Lemonade" == recipe)
                    {
                        if (quan < 1)
                        {
                            rdBtn13Red.Enabled = false;
                        }
                    }
                    else if ("B Lemonade" == recipe)
                    {
                        if (quan < 1)
                        {
                            rdBtn12Blue.Enabled = false;
                        }
                    }
                    else if ("P Lemonade" == recipe)
                    {
                        if (quan < 1)
                        {
                            rdBtn11Pinky.Enabled = false;
                        }
                    }
                    else if ("Iced Coffee" == recipe)
                    {
                        if (quan < 1)
                        {
                            btnEnterIced.Enabled = false;
                        }
                    }
                    else if ("Coffee Jelly" == recipe)
                    {
                        if (quan < 1)
                        {
                            btnEnterCoffee.Enabled = false;
                        }
                    }
                    else if ("Ch Milkshake" == recipe)
                    {
                        if (quan < 1)
                        {
                            rdBtn14Choco.Enabled = false;
                        }
                    }
                    else if ("Co Milkshake" == recipe)
                    {
                        if (quan < 1)
                        {
                            rdBtn14Cookies.Enabled = false;
                        }
                    }
                    else if ("M Milkshake" == recipe)
                    {
                        if (quan < 1)
                        {
                            rdBtn14Mango.Enabled = false;
                        }
                    }
                    else if ("P Milkshake" == recipe)
                    {
                        if (quan < 1)
                        {
                            rdBtn14Pandan.Enabled = false;
                        }
                    }
                    else if ("S Milkshake" == recipe)
                    {
                        if (quan < 1)
                        {
                            rdBtn14Straw.Enabled = false;
                        }
                    }


                }
            }
            con.con.Close();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            btnLogOut.BackColor = darkCyanBlue;

            dtgrdScreen.BackgroundColor = gray;
            dtgrdScreen.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12);
            dtgrdScreen.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            pblTransaction.BackColor = lightYellow;
            txtbxTotal.BackColor = lightYellow;
            txtbxDiscount.BackColor = lightYellow;
            txtbxPayable.BackColor = lightYellow;
            btnDiscount.BackColor = orange;
            btnPrint.BackColor = green;

            btnSnacks.BackColor = darkSlateGray;
            btnDrinks.BackColor = darkSlateGray;
            panel1.BackColor = blue;
            pnlSnacks.BackColor = blue;
            pnlDrinks.BackColor = blue;
            grpbx01Bundle.BackColor = blue;
            grpbx14Flavor.BackColor = blue;
            grpbx05Bundle.BackColor = blue;
            grpbxFront.BackColor = blue;
            grpbx10Flavor.BackColor = blue;
            grpbx06Bundle.BackColor = blue;
            grpbx02Bundle.BackColor = blue;
            txtbxQty.BackColor = gray97;
            btnEnterCoffee.BackColor = orange;
            btnEnterIced.BackColor = orange;
            btnEnterNach.BackColor = orange;
            btnEnterMojo.BackColor = orange;
            btnEnter.BackColor = orange;
        }

        public void hide()
        {
            grpbxFront.Show();

            rdBtn01ThreePcs.Hide();
            rdBtn01SixPcs.Hide();
            rdBtn01NinePcs.Hide();
            grpbx01Bundle.Hide();

            rdBtn02ThreePcs.Hide();
            rdBtn02SixPcs.Hide();
            rdBtn02NinePcs.Hide();
            grpbx02Bundle.Hide();

            rdBtn05ThreePcs.Hide();
            rdBtn05SixPcs.Hide();
            grpbx05Bundle.Hide();

            rdBtn06ThreePcs.Hide();
            rdBtn06SixPcs.Hide();
            rdBtn06NinePcs.Hide();
            grpbx06Bundle.Hide();

            rdBtn11Pinky.Hide();
            rdBtn12Blue.Hide();
            rdBtn13Red.Hide();
            grpbx10Flavor.Hide();

            rdBtn14Choco.Hide();
            rdBtn14Cookies.Hide();
            rdBtn14Mango.Hide();
            rdBtn14Pandan.Hide();
            rdBtn14Straw.Hide();
            grpbx14Flavor.Hide();

            rdBtn01ThreePcs.Checked = false;
            rdBtn01SixPcs.Checked = false;
            rdBtn01NinePcs.Checked = false;

            rdBtn02ThreePcs.Checked = false;
            rdBtn02SixPcs.Checked = false;
            rdBtn02NinePcs.Checked = false;

            rdBtn05ThreePcs.Checked = false;
            rdBtn05SixPcs.Checked = false;

            rdBtn06ThreePcs.Checked = false;
            rdBtn06SixPcs.Checked = false;
            rdBtn06NinePcs.Checked = false;

            rdBtn11Pinky.Checked = false;
            rdBtn12Blue.Checked = false;
            rdBtn13Red.Checked = false;

            rdBtn14Choco.Checked = false;
            rdBtn14Cookies.Checked = false;
            rdBtn14Mango.Checked = false;
            rdBtn14Pandan.Checked = false;
            rdBtn14Straw.Checked = false;

            txtbxQty.Hide();
            txtbxQty.Clear();
            btnEnter.Hide();
            btnEnterMojo.Hide();
            btnEnterNach.Hide();
            btnEnterIced.Hide();
            btnEnterCoffee.Hide();
        }

        public void quantity()
        {
            txtbxQty.Show();
            btnEnter.Show();
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

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            pnlSnacks.Show();
            panel1.Hide();
            pnlDrinks.Hide();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            pnlDrinks.Show();
            panel1.Hide();
            pnlSnacks.Hide();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            hide();
            rdBtn01ThreePcs.Show();
            rdBtn01SixPcs.Show();
            rdBtn01NinePcs.Show();
            grpbx01Bundle.Show();
            grpbxFront.Hide();
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            hide();
            rdBtn02ThreePcs.Show();
            rdBtn02SixPcs.Show();
            rdBtn02NinePcs.Show();
            grpbx02Bundle.Show();
            grpbxFront.Hide();
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            hide();
            txtbxQty.Show();
            btnEnterMojo.Show();
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            hide();
            txtbxQty.Show();
            btnEnterNach.Show();
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            hide();
            rdBtn05ThreePcs.Show();
            rdBtn05SixPcs.Show();
            grpbx05Bundle.Show();
            grpbxFront.Hide();
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            hide();
            rdBtn06ThreePcs.Show();
            rdBtn06SixPcs.Show();
            rdBtn06NinePcs.Show();
            grpbx06Bundle.Show();
            grpbxFront.Hide();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            hide();
            rdBtn11Pinky.Show();
            rdBtn12Blue.Show();
            rdBtn13Red.Show();
            grpbx10Flavor.Show();
            grpbxFront.Hide();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            hide();
            txtbxQty.Show();
            btnEnterIced.Show();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            hide();
            txtbxQty.Show();
            btnEnterCoffee.Show();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            hide();
            rdBtn14Choco.Show();
            rdBtn14Cookies.Show();
            rdBtn14Mango.Show();
            rdBtn14Pandan.Show();
            rdBtn14Straw.Show();
            grpbx14Flavor.Show();
            grpbxFront.Hide();
        }

        private void rdBtn01ThreePcs_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn01SixPcs_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn01NinePcs_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }
        private void rdBtn02ThreePcs_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn02SixPcs_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn02NinePcs_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn05ThreePcs_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn05SixPcs_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn06ThreePcs_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn06SixPcs_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn06NinePcs_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn11Pinky_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn12Blue_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn13Red_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn14Choco_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn14Cookies_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn14Mango_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn14Pandan_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void rdBtn14Straw_CheckedChanged(object sender, EventArgs e)
        {
            quantity();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxQty.Text))
            {
                MessageBox.Show("Please enter quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxQty.Focus();
                return;
            }

            try
            {
                int conv = Convert.ToInt32(txtbxQty.Text);

                if (rdBtn01ThreePcs.Checked == true)
                {
                    price = conv * 65;
                    itotal = conv * 3;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("3 pcs. Spicy Buffalo Wings w/ Fries" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '3 pcs. " + lbl01.Text + " w/ Fries', '65', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    //form10.dataGridView1.DataSource = ds.Tables["tblinvoice"];

                    con.con.Close();
                }
                else if (rdBtn01SixPcs.Checked == true)
                {
                    price = conv * 120;
                    itotal = conv * 6;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("6 pcs. Spicy Buffalo Wings w/ Fries" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '6 pcs. " + lbl01.Text + " w/ Fries', '120', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn01NinePcs.Checked == true)
                {
                    price = conv * 175;
                    itotal = conv * 9;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("9 pcs. Spicy Buffalo Wings w/ Fries" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '9 pcs. " + lbl01.Text + " w/ Fries', '175', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn02ThreePcs.Checked == true)
                {
                    price = conv * 39;
                    itotal = conv * 3;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("3 pcs. Cheezy Onion Rings w/ Fries" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '3 pcs. " + lbl02.Text + " w/ Fries', '39', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn02SixPcs.Checked == true)
                {
                    price = conv * 59;
                    itotal = conv * 6;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("6 pcs. Cheezy Onion Rings w/ Fries" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '6 pcs. " + lbl02.Text + " w/ Fries', '59', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn02NinePcs.Checked == true)
                {
                    price = conv * 79;
                    itotal = conv * 9;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("9 pcs. Cheezy Onion Rings w/ Fries" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '9 pcs. " + lbl02.Text + " w/ Fries', '79', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn05ThreePcs.Checked == true)
                {
                    price = conv * 65;
                    itotal = conv * 3;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("3 pcs. Monte Cristo Sandwich w/ Fries" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '3 pcs. " + lbl05.Text + " w/ Fries', '65', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn05SixPcs.Checked == true)
                {
                    price = conv * 105;
                    itotal = conv * 6;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("6 pcs. Monte Cristo Sandwich w/ Fries" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '6 pcs. " + lbl05.Text + " w/ Fries', '105', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn06ThreePcs.Checked == true)
                {
                    price = conv * 39;
                    itotal = conv * 3;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("3 pcs. Dynamite w/ Fries" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '3 pcs. " + lbl06.Text + " w/ Fries', '39', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    //form10.dataGridView1.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn06SixPcs.Checked == true)
                {
                    price = conv * 59;
                    itotal = conv * 6;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("6 pcs. Dynamite w/ Fries" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '6 pcs. " + lbl06.Text + " w/ Fries', '59', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn06NinePcs.Checked == true)
                {
                    price = conv * 79;
                    itotal = conv * 9;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("9 pcs. Dynamite w/ Fries" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '9 pcs. " + lbl06.Text + " w/ Fries', '79', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn11Pinky.Checked == true)
                {
                    price = conv * 25;
                    itotal = conv * 1;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("Pinky Dust Lemonade" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, 'Pinky Dust " + lbl11.Text + "', '25', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn12Blue.Checked == true)
                {
                    price = conv * 25;
                    itotal = conv * 1;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("Blue Ocean Lemonade" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, 'Blue Ocean " + lbl11.Text + "', '25', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn13Red.Checked == true)
                {
                    price = conv * 25;
                    itotal = conv * 1;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("Bloody Red Lemonade" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, 'Bloody Red " + lbl11.Text + "', '25', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn14Choco.Checked == true)
                {
                    price = conv * 79;
                    itotal = conv * 1;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("Choco Hot Fudge Milkshake" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, 'Choco Hot Fudge " + lbl14.Text + "', '79', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn14Cookies.Checked == true)
                {
                    price = conv * 79;
                    itotal = conv * 1;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("Cookies N Cream Milkshake" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, 'Cookies N Cream " + lbl14.Text + "', '79', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn14Mango.Checked == true)
                {
                    price = conv * 79;
                    itotal = conv * 1;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("Mango Graham Milkshake" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, 'Mango Graham " + lbl14.Text + "', '79', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn14Pandan.Checked == true)
                {
                    price = conv * 79;
                    itotal = conv * 1;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("Pandan Milkshake" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, 'Pandan " + lbl14.Text + "', '79', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }
                else if (rdBtn14Straw.Checked == true)
                {
                    price = conv * 79;
                    itotal = conv * 1;
                    con.con.Open();
                    con.query = "SELECT qty, item, each, total from tblinvoice";
                    con.cmd = new OleDbCommand(con.query, con.con);
                    con.cmd.ExecuteNonQuery();
                    con.reader = con.cmd.ExecuteReader();

                    int count = 0;

                    while (con.reader.Read())
                    {
                        count = count + 1;
                        container.Text = con.reader["item"].ToString();
                        add = int.Parse(con.reader["qty"].ToString());
                        aprice = int.Parse(con.reader["total"].ToString());
                    }

                    if ("Strawberry Milkshake" == container.Text)
                    {
                        addtotal = add + conv;
                        ptotal = aprice + price;
                        con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                        con.cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, 'Strawberry " + lbl14.Text + "', '79', @total)", con.con);
                        con.cmd.Parameters.AddWithValue("@qty", conv);
                        con.cmd.Parameters.AddWithValue("@total", price);
                        con.cmd.ExecuteNonQuery();
                    }

                    da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblinvoice");
                    dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                    con.con.Close();
                }

                hide();
                pprice += price;
                totalShow = Convert.ToString(pprice);
                txtbxTotal.Text = totalShow;
                txtbxPayable.Text = totalShow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxQty.Focus();
            }
        }

        private void btnEnterMojo_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxQty.Text))
            {
                MessageBox.Show("Please enter quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxQty.Focus();
                return;
            }

            try
            {
                int conv = Convert.ToInt32(txtbxQty.Text);
                price = conv * 59;
                itotal = conv * 1;
                con.con.Open();
                con.query = "SELECT qty, item, each, total from tblinvoice";
                con.cmd = new OleDbCommand(con.query, con.con);
                con.cmd.ExecuteNonQuery();
                con.reader = con.cmd.ExecuteReader();

                int count = 0;

                while (con.reader.Read())
                {
                    count = count + 1;
                    container.Text = con.reader["item"].ToString();
                    add = int.Parse(con.reader["qty"].ToString());
                    aprice = int.Parse(con.reader["total"].ToString());
                }

                if (lbl03.Text == container.Text)
                {
                    addtotal = add + conv;
                    ptotal = aprice + price;
                    con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                    con.cmd.ExecuteNonQuery();
                }
                else
                {
                    con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '" + lbl03.Text + " w/ Fries', '59', @total)", con.con);
                    con.cmd.Parameters.AddWithValue("@qty", conv);
                    con.cmd.Parameters.AddWithValue("@total", price);
                    con.cmd.ExecuteNonQuery();
                }

                da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tblinvoice");
                dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                con.con.Close();

                hide();
                pprice += price;
                totalShow = Convert.ToString(pprice);
                txtbxTotal.Text = totalShow;
                txtbxPayable.Text = totalShow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxQty.Focus();
            }
        }

        private void btnEnterNach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxQty.Text))
            {
                MessageBox.Show("Please enter quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxQty.Focus();
                return;
            }

            try
            {
                int conv = Convert.ToInt32(txtbxQty.Text);
                price = conv * 59;
                con.con.Open();
                con.query = "SELECT qty, item, each, total from tblinvoice";
                con.cmd = new OleDbCommand(con.query, con.con);
                con.cmd.ExecuteNonQuery();
                con.reader = con.cmd.ExecuteReader();

                int count = 0;

                while (con.reader.Read())
                {
                    count = count + 1;
                    container.Text = con.reader["item"].ToString();
                    add = int.Parse(con.reader["qty"].ToString());
                    aprice = int.Parse(con.reader["total"].ToString());
                }

                if (lbl04.Text == container.Text)
                {
                    addtotal = add + conv;
                    ptotal = aprice + price;
                    con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                    con.cmd.ExecuteNonQuery();
                }
                else
                {
                    con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '" + lbl04.Text + "', '59', @total)", con.con);
                    con.cmd.Parameters.AddWithValue("@qty", conv);
                    con.cmd.Parameters.AddWithValue("@total", price);
                    con.cmd.ExecuteNonQuery();
                }

                da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tblinvoice");
                dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                con.con.Close();
                this.Refresh();
                Refresh();
                hide();
                pprice += price;
                totalShow = Convert.ToString(pprice);
                txtbxTotal.Text = totalShow;
                txtbxPayable.Text = totalShow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxQty.Focus();
            }
        }

        private void btnEnterIced_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxQty.Text))
            {
                MessageBox.Show("Please enter quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxQty.Focus();
                return;
            }

            try
            {
                int conv = Convert.ToInt32(txtbxQty.Text);
                price = conv * 34;
                con.con.Open();
                con.query = "SELECT qty, item, each, total from tblinvoice";
                con.cmd = new OleDbCommand(con.query, con.con);
                con.cmd.ExecuteNonQuery();
                con.reader = con.cmd.ExecuteReader();

                int count = 0;

                while (con.reader.Read())
                {
                    count = count + 1;
                    container.Text = con.reader["item"].ToString();
                    add = int.Parse(con.reader["qty"].ToString());
                    aprice = int.Parse(con.reader["total"].ToString());
                }

                if (lbl12.Text == container.Text)
                {
                    addtotal = add + conv;
                    ptotal = aprice + price;
                    con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                    con.cmd.ExecuteNonQuery();
                }
                else
                {
                    con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '" + lbl12.Text + "', '34', @total)", con.con);
                    con.cmd.Parameters.AddWithValue("@qty", conv);
                    con.cmd.Parameters.AddWithValue("@total", price);
                    con.cmd.ExecuteNonQuery();
                }

                da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tblinvoice");
                dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                con.con.Close();

                hide();
                pprice += price;
                totalShow = Convert.ToString(pprice);
                txtbxTotal.Text = totalShow;
                txtbxPayable.Text = totalShow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxQty.Focus();
            }
        }

        private void btnEnterCoffee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxQty.Text))
            {
                MessageBox.Show("Please enter quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxQty.Focus();
                return;
            }

            try
            {
                int conv = Convert.ToInt32(txtbxQty.Text);
                price = conv * 59;
                con.con.Open();
                con.query = "SELECT qty, item, each, total from tblinvoice";
                con.cmd = new OleDbCommand(con.query, con.con);
                con.cmd.ExecuteNonQuery();
                con.reader = con.cmd.ExecuteReader();


                if (lbl13.Text == container.Text)
                {
                    addtotal = add + conv;
                    ptotal = aprice + price;
                    con.cmd = new OleDbCommand("UPDATE tblinvoice SET [qty] = '" + addtotal + "', [total] = '" + ptotal + "' WHERE [item] = '" + container.Text + "'", con.con);
                    con.cmd.ExecuteNonQuery();
                }
                else
                {
                    con.cmd = new OleDbCommand("INSERT INTO tblinvoice([qty], [item], [each], [total]) VALUES(@qty, '" + lbl13.Text + "', '59', @total)", con.con);
                    con.cmd.Parameters.AddWithValue("@qty", conv);
                    con.cmd.Parameters.AddWithValue("@total", price);
                    con.cmd.ExecuteNonQuery();

                }

                da = new OleDbDataAdapter("SELECT qty, item, each, total from tblinvoice", con.con);
                DataSet ds = new DataSet();
                da.Fill(ds, "tblinvoice");
                dtgrdScreen.DataSource = ds.Tables["tblinvoice"];
                con.con.Close();

                hide();
                pprice += price;
                totalShow = Convert.ToString(pprice);
                txtbxTotal.Text = totalShow;
                txtbxPayable.Text = totalShow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxQty.Focus();
            }
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxTotal.Text))
            {
                MessageBox.Show("Nothing to void", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Void form4 = new Void(this);
                form4.Show();
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxTotal.Text))
            {
                MessageBox.Show("Please order first before discounting", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Discount form5 = new Discount(this);
                form5.Show();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxTotal.Text))
            {
                MessageBox.Show("Please order first before paying", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                payment();

            }
        }

        public void payment()
        {
            con.con.Open();
            con.query = "SELECT qty, item from tblinvoice";
            con.cmd = new OleDbCommand(con.query, con.con);
            con.cmd.ExecuteNonQuery();
            con.reader = con.cmd.ExecuteReader();
            int count = 0;
            int total = 0;

            while (con.reader.Read())
            {
                count = count + 1;
                container.Text = con.reader["item"].ToString();
                containerqty.Text = con.reader["qty"].ToString();
                int quan = int.Parse(con.reader["qty"].ToString());

                if (count >= 1)
                {
                    if ("3 pcs. Spicy Buffalo Wings w/ Fries" == container.Text)
                    {
                        quan = quan * 3;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Wings" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("3 pcs. Spicy Buffalo Wings is out of stock!");
                                    rdBtn01ThreePcs.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("3 pcs. Spicy Buffalo Wings is out of stock!");
                                    rdBtn01ThreePcs.Enabled = false;
                                }
                                else if (total == 0)
                                {
                                    con.query = "UPDATE tblInventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn01ThreePcs.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblInventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    else if ("6 pcs. Spicy Buffalo Wings w/ Fries" == container.Text)
                    {
                        quan = quan * 6;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Wings" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("6 pcs. Spicy Buffalo Wings is out of stock!");
                                    rdBtn01SixPcs.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("6 pcs. Spicy Buffalo Wings is out of stock!");
                                    rdBtn01SixPcs.Enabled = false;
                                }
                                else if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn01SixPcs.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("9 pcs. Spicy Buffalo Wings w/ Fries" == container.Text)
                    {
                        quan = quan * 9;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Wings" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("9 pcs. Spicy Buffalo Wings is out of stock!");
                                    rdBtn01NinePcs.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("9 pcs. Spicy Buffalo Wings is out of stock!");
                                    rdBtn01NinePcs.Enabled = false;
                                }
                                else if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn01NinePcs.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("3 pcs. Cheezy Onion Rings w/ Fries" == container.Text)
                    {
                        quan = quan * 3;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Onion rings" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("3 pcs. Cheezy Onion Rings is out of stock!");
                                    rdBtn02ThreePcs.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("3 pcs. Cheezy Onion Rings is out of stock!");
                                    rdBtn02ThreePcs.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn02ThreePcs.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("6 pcs. Cheezy Onion Rings w/ Fries" == container.Text)
                    {
                        quan = quan * 6;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Onion rings" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("6 pcs. Cheezy Onion Rings is out of stock!");
                                    rdBtn02SixPcs.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("6 pcs. Cheezy Onion Rings is out of stock!");
                                    rdBtn02SixPcs.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn02SixPcs.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("9 pcs. Cheezy Onion Rings w/ Fries" == container.Text)
                    {
                        quan = quan * 9;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Onion rings" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("9 pcs. Cheezy Onion Rings is out of stock!");
                                    rdBtn02NinePcs.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("9 pcs. Cheezy Onion Rings is out of stock!");
                                    rdBtn02NinePcs.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn02NinePcs.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("3 pcs. Monte Cristo Sandwich w/ Fries" == container.Text)
                    {
                        quan = quan * 3;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Sandwich" == recipe)
                            {
                                total = quantity - quan;
                                if (total < 0)
                                {
                                    MessageBox.Show("3 pcs. Monte Cristo Sandwich is out of stock!");
                                    rdBtn05ThreePcs.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("3 pcs. Monte Cristo Sandwich is out of stock!");
                                    rdBtn05ThreePcs.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn05ThreePcs.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("6 pcs. Monte Cristo Sandwich w/ Fries" == container.Text)
                    {
                        quan = quan * 6;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Sandwich" == recipe)
                            {
                                total = quantity - quan;
                                if (total < 0)
                                {
                                    MessageBox.Show("6 pcs. Monte Cristo Sandwich is out of stock!");
                                    rdBtn05SixPcs.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("6 pcs. Monte Cristo Sandwich is out of stock!");
                                    rdBtn05SixPcs.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    rdBtn05SixPcs.Enabled = false;
                                    con.cmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("3 pcs. Dynamite w/ Fries" == container.Text)
                    {
                        quan = quan * 3;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Dynamite" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("3 pcs. Dynamite is out of stock!");
                                    rdBtn06ThreePcs.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("3 pcs. Dynamite is out of stock!");
                                    rdBtn06ThreePcs.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn06ThreePcs.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("6 pcs. Dynamite w/ Fries" == container.Text)
                    {
                        quan = quan * 6;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Dynamite" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("6 pcs. Dynamite is out of stock!");
                                    rdBtn06SixPcs.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("6 pcs. Dynamite is out of stock!");
                                    rdBtn06SixPcs.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn06SixPcs.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("9 pcs. Dynamite w/ Fries" == container.Text)
                    {
                        quan = quan * 9;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Dynamite" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("9 pcs. Dynamite is out of stock!");
                                    rdBtn06NinePcs.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("9 pcs. Dynamite is out of stock!");
                                    rdBtn06NinePcs.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn06NinePcs.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("Pinky Dust Lemonade" == container.Text)
                    {
                        quan = quan * 1;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("P Lemonade" == recipe)
                            {
                                total = quantity - quan;
                                if (total < 0)
                                {
                                    MessageBox.Show("Pinky Dust Lemonade is out of stock!");
                                    rdBtn11Pinky.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("Pinky Dust Lemonade is out of stock!");
                                    rdBtn11Pinky.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn11Pinky.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("Ocean Blue Lemonade" == container.Text)
                    {
                        quan = quan * 1;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("B Lemonade" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("Ocean Blue Lemonade is out of stock!");
                                    rdBtn12Blue.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("Ocean Blue Lemonade is out of stock!");
                                    rdBtn12Blue.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn12Blue.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("Bloody Red Lemonade" == container.Text)
                    {
                        quan = quan * 1;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("R Lemonade" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("Bloody Red Lemonade is out of stock!");
                                    rdBtn13Red.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("Bloody Red Lemonade is out of stock!");
                                    rdBtn13Red.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn13Red.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("Choco Hot Fudge Milkshake" == container.Text)
                    {
                        quan = quan * 1;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Ch Milkshake" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("Choco Hot Fudge Milkshake is out of stock!");
                                    rdBtn14Choco.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("Choco Hot Fudge Milkshake is out of stock!");
                                    rdBtn14Choco.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn14Choco.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("Cookies N Cream Milkshake" == container.Text)
                    {
                        quan = quan * 1;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Co Milkshake" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("Cookies N Cream Milkshake is out of stock!");
                                    rdBtn14Cookies.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("Cookies N Cream Milkshake is out of stock!");
                                    rdBtn14Cookies.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn14Cookies.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("Mango Graham Milkshake" == container.Text)
                    {
                        quan = quan * 1;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("M Milkshake" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("Mango Graham Milkshake is out of stock!");
                                    rdBtn14Mango.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("Mango Graham Milkshake is out of stock!");
                                    rdBtn14Mango.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn14Mango.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("Pandan Milkshake" == container.Text)
                    {
                        quan = quan * 1;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("P Milkshake" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("Pandan Milkshake is out of stock!");
                                    rdBtn14Pandan.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("Pandan Milkshake is out of stock!");
                                    rdBtn14Pandan.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn14Pandan.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("Strawberry Milkshake" == container.Text)
                    {
                        quan = quan * 1;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("S Milkshake" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("Strawberry Milkshake is out of stock!");
                                    rdBtn14Straw.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("Strawberry Milkshake is out of stock!");
                                    rdBtn14Straw.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    rdBtn14Straw.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("Mojojastic w/ Fries" == container.Text)
                    {
                        quan = quan * 3;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Potato" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("Mojojastic is out of stock!");
                                    btnEnterMojo.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("Mojojastic is out of stock!");
                                    btnEnterMojo.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    btnEnterMojo.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("Nachos" == container.Text)
                    {
                        quan = quan * 3;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Nachos" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("Nachos is out of stock!");
                                    btnEnterNach.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("Nachos is out of stock!");
                                    btnEnterNach.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    btnEnterNach.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("Coffee Jelly" == container.Text)
                    {
                        quan = quan * 1;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Coffee Jelly" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("Coffee Jelly is out of stock!");
                                    btnEnterCoffee.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("Coffee Jelly is out of stock!");
                                    btnEnterCoffee.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    btnEnterCoffee.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    else if ("Coffee Jelly" == container.Text)
                    {
                        quan = quan * 1;

                        con.query = "SELECT Recipe, Quantity from tblinventory";
                        con.cmd = new OleDbCommand(con.query, con.con);
                        con.cmd.ExecuteNonQuery();
                        con.read = con.cmd.ExecuteReader();

                        int coun = 0;
                        string recipe = "";
                        int quantity = 0;

                        while (con.read.Read())
                        {
                            coun = coun + 1;
                            recipe = con.read["Recipe"].ToString();
                            quantity = int.Parse(con.read["Quantity"].ToString());

                            if ("Iced Coffee" == recipe)
                            {
                                total = quantity - quan;

                                if (total < 0)
                                {
                                    MessageBox.Show("Iced Coffee is out of stock!");
                                    btnEnterIced.Enabled = false;
                                }
                                else if (total > quantity)
                                {
                                    MessageBox.Show("Iced Coffee is out of stock!");
                                    btnEnterIced.Enabled = false;
                                }
                                if (total == 0)
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                    btnEnterIced.Enabled = false;
                                }
                                else
                                {
                                    con.query = "UPDATE tblinventory SET [Quantity]='" + total + "' WHERE [Recipe]= '" + recipe + "'";
                                    con.cmd = new OleDbCommand(con.query, con.con);
                                    con.cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }

            con.con.Close();
            Pay pay = new Pay(this);
            pay.Show();
            pay.txtbxTotalPay.Text = txtbxPayable.Text;

            this.Refresh();
        }

        private void txtbxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
