namespace Point_of_Sales__POS_
{
    partial class Pay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtbxTotalPay = new System.Windows.Forms.TextBox();
            this.lblTendered = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtbxChange = new System.Windows.Forms.TextBox();
            this.txtbxTendered = new System.Windows.Forms.TextBox();
            this.dateOne = new System.Windows.Forms.DateTimePicker();
            this.containeruser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Green;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(171, 273);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(130, 50);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(321, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 50);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtbxTotalPay
            // 
            this.txtbxTotalPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxTotalPay.Enabled = false;
            this.txtbxTotalPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTotalPay.Location = new System.Drawing.Point(251, 116);
            this.txtbxTotalPay.MaxLength = 12;
            this.txtbxTotalPay.Name = "txtbxTotalPay";
            this.txtbxTotalPay.Size = new System.Drawing.Size(200, 29);
            this.txtbxTotalPay.TabIndex = 11;
            this.txtbxTotalPay.TabStop = false;
            this.txtbxTotalPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTendered
            // 
            this.lblTendered.AutoSize = true;
            this.lblTendered.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTendered.Location = new System.Drawing.Point(80, 167);
            this.lblTendered.Name = "lblTendered";
            this.lblTendered.Size = new System.Drawing.Size(121, 21);
            this.lblTendered.TabIndex = 10;
            this.lblTendered.Text = "Cash Tendered:";
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPay.Location = new System.Drawing.Point(29, 118);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(172, 21);
            this.lblTotalPay.TabIndex = 9;
            this.lblTotalPay.Text = "Total Payable Amount:";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(193, 44);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(114, 32);
            this.lblPay.TabIndex = 8;
            this.lblPay.Text = "Payment";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(12, 10);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(0, 21);
            this.lblManager.TabIndex = 15;
            this.lblManager.Visible = false;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(132, 216);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(69, 21);
            this.lblChange.TabIndex = 16;
            this.lblChange.Text = "Change:";
            // 
            // txtbxChange
            // 
            this.txtbxChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxChange.Enabled = false;
            this.txtbxChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxChange.Location = new System.Drawing.Point(251, 214);
            this.txtbxChange.MaxLength = 12;
            this.txtbxChange.Name = "txtbxChange";
            this.txtbxChange.Size = new System.Drawing.Size(200, 29);
            this.txtbxChange.TabIndex = 17;
            this.txtbxChange.TabStop = false;
            this.txtbxChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbxTendered
            // 
            this.txtbxTendered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxTendered.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTendered.Location = new System.Drawing.Point(251, 165);
            this.txtbxTendered.MaxLength = 12;
            this.txtbxTendered.Name = "txtbxTendered";
            this.txtbxTendered.Size = new System.Drawing.Size(200, 29);
            this.txtbxTendered.TabIndex = 1;
            this.txtbxTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbxTendered.TextChanged += new System.EventHandler(this.txtbxTendered_TextChanged);
            // 
            // dateOne
            // 
            this.dateOne.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOne.Enabled = false;
            this.dateOne.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOne.Location = new System.Drawing.Point(12, 12);
            this.dateOne.Name = "dateOne";
            this.dateOne.Size = new System.Drawing.Size(250, 23);
            this.dateOne.TabIndex = 126;
            this.dateOne.Visible = false;
            // 
            // containeruser
            // 
            this.containeruser.AutoSize = true;
            this.containeruser.Location = new System.Drawing.Point(420, 9);
            this.containeruser.Name = "containeruser";
            this.containeruser.Size = new System.Drawing.Size(52, 21);
            this.containeruser.TabIndex = 151;
            this.containeruser.Text = "label5";
            this.containeruser.Visible = false;
            // 
            // Pay
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.containeruser);
            this.Controls.Add(this.dateOne);
            this.Controls.Add(this.txtbxTendered);
            this.Controls.Add(this.txtbxChange);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtbxTotalPay);
            this.Controls.Add(this.lblTendered);
            this.Controls.Add(this.lblTotalPay);
            this.Controls.Add(this.lblPay);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.Load += new System.EventHandler(this.Pay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtbxTotalPay;
        public System.Windows.Forms.Label containeruser;
        public System.Windows.Forms.Button btnPay;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lblTendered;
        public System.Windows.Forms.Label lblTotalPay;
        public System.Windows.Forms.Label lblPay;
        public System.Windows.Forms.Label lblManager;
        public System.Windows.Forms.Label lblChange;
        public System.Windows.Forms.TextBox txtbxTendered;
        public System.Windows.Forms.TextBox txtbxChange;
        public System.Windows.Forms.DateTimePicker dateOne;
    }
}