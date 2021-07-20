using System;
using System.Drawing;
using System.Windows.Forms;

namespace Point_of_Sales__POS_
{
    public partial class Discount : Form
    {
        static Color darkCyanBlueTemp = Color.FromArgb(0x263947);
        static Color gray97Temp = Color.FromArgb(0xF7F7F7);
        static Color greenTemp = Color.FromArgb(0x00BF6F);

        Color darkCyanBlue = Color.FromArgb(darkCyanBlueTemp.R, darkCyanBlueTemp.G, darkCyanBlueTemp.B);
        Color gray97 = Color.FromArgb(gray97Temp.R, gray97Temp.G, gray97Temp.B);
        Color green = Color.FromArgb(greenTemp.R, greenTemp.G, greenTemp.B);

        POSGulpEmUp POSGEU;

        double discount;
        double discounted;
        string discountedS;
        double discountedPrice;
        string discountedPriceS;

        public Discount(POSGulpEmUp POS)
        {
            POSGEU = POS;
            InitializeComponent();
        }

        private void Discount_Load(object sender, EventArgs e)
        {
            txtbxPercent.BackColor = gray97;
            btnDiscount.BackColor = green;
            btnCancel.BackColor = darkCyanBlue;
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (txtbxPercent.Text == "")
            {
                MessageBox.Show("Please enter discount percentage", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxPercent.Focus();
                return;
            }

            try
            {
                double disc = double.Parse(txtbxPercent.Text);
                if (disc <= 25) {
                    discount = Convert.ToDouble(txtbxPercent.Text);
                    discount /= 100;

                    discounted = POSGEU.pprice * discount;
                    discountedS = Convert.ToString(discounted);
                    POSGEU.txtbxDiscount.Text = discountedS;

                    discountedPrice = POSGEU.pprice - discounted;
                    discountedPriceS = Convert.ToString(discountedPrice);
                    POSGEU.txtbxPayable.Text = discountedPriceS;

                    this.Close();
                }
                else if (disc >25)
                {
                    MessageBox.Show("No above 25% discount rate");
                }
                else if(disc == 100)
                {
                    MessageBox.Show("No free in this business");
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbxPercent_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPercent_Click(object sender, EventArgs e)
        {

        }

        private void lblPercentage_Click(object sender, EventArgs e)
        {

        }

        private void lblDiscount_Click(object sender, EventArgs e)
        {

        }

        private void txtbxPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
