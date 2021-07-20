namespace Point_of_Sales__POS_
{
    partial class Sales
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
            this.btnTrail = new System.Windows.Forms.Button();
            this.dateOne = new System.Windows.Forms.DateTimePicker();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.containeruser = new System.Windows.Forms.Label();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSur = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblConSur = new System.Windows.Forms.Label();
            this.lblConFirst = new System.Windows.Forms.Label();
            this.lblConUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrail
            // 
            this.btnTrail.BackColor = System.Drawing.Color.SandyBrown;
            this.btnTrail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrail.ForeColor = System.Drawing.Color.White;
            this.btnTrail.Location = new System.Drawing.Point(398, 4);
            this.btnTrail.Name = "btnTrail";
            this.btnTrail.Size = new System.Drawing.Size(100, 32);
            this.btnTrail.TabIndex = 130;
            this.btnTrail.Text = "TRAIL";
            this.btnTrail.UseVisualStyleBackColor = false;
            this.btnTrail.Click += new System.EventHandler(this.btnTrail_Click);
            // 
            // dateOne
            // 
            this.dateOne.Enabled = false;
            this.dateOne.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOne.Location = new System.Drawing.Point(958, 8);
            this.dateOne.Name = "dateOne";
            this.dateOne.Size = new System.Drawing.Size(200, 27);
            this.dateOne.TabIndex = 125;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.HotPink;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(1175, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(90, 32);
            this.btnLogOut.TabIndex = 129;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlMain.Controls.Add(this.containeruser);
            this.pnlMain.Controls.Add(this.btnTrail);
            this.pnlMain.Controls.Add(this.dateOne);
            this.pnlMain.Controls.Add(this.btnLogOut);
            this.pnlMain.Controls.Add(this.btnEmployee);
            this.pnlMain.Controls.Add(this.btnInventory);
            this.pnlMain.Controls.Add(this.btnSales);
            this.pnlMain.Location = new System.Drawing.Point(26, 10);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1285, 40);
            this.pnlMain.TabIndex = 147;
            // 
            // containeruser
            // 
            this.containeruser.AutoSize = true;
            this.containeruser.Location = new System.Drawing.Point(617, 11);
            this.containeruser.Name = "containeruser";
            this.containeruser.Size = new System.Drawing.Size(64, 24);
            this.containeruser.TabIndex = 150;
            this.containeruser.Text = "label5";
            this.containeruser.Visible = false;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(40, 4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(100, 32);
            this.btnEmployee.TabIndex = 126;
            this.btnEmployee.Text = "USERS";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.SandyBrown;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(146, 3);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(140, 32);
            this.btnInventory.TabIndex = 125;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Location = new System.Drawing.Point(292, 4);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(100, 32);
            this.btnSales.TabIndex = 124;
            this.btnSales.Text = "SALES";
            this.btnSales.UseVisualStyleBackColor = false;
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.LightPink;
            this.pnlSales.Controls.Add(this.dataGridView1);
            this.pnlSales.Location = new System.Drawing.Point(26, 68);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(1286, 600);
            this.pnlSales.TabIndex = 148;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(300, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(601, 322);
            this.dataGridView1.TabIndex = 152;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblSur
            // 
            this.lblSur.AutoSize = true;
            this.lblSur.Location = new System.Drawing.Point(1265, 123);
            this.lblSur.Name = "lblSur";
            this.lblSur.Size = new System.Drawing.Size(0, 24);
            this.lblSur.TabIndex = 146;
            this.lblSur.Visible = false;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(1258, 89);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(0, 24);
            this.lblFirst.TabIndex = 145;
            this.lblFirst.Visible = false;
            // 
            // lblConSur
            // 
            this.lblConSur.AutoSize = true;
            this.lblConSur.Location = new System.Drawing.Point(1291, 699);
            this.lblConSur.Name = "lblConSur";
            this.lblConSur.Size = new System.Drawing.Size(0, 24);
            this.lblConSur.TabIndex = 151;
            this.lblConSur.Visible = false;
            // 
            // lblConFirst
            // 
            this.lblConFirst.AutoSize = true;
            this.lblConFirst.Location = new System.Drawing.Point(1311, 699);
            this.lblConFirst.Name = "lblConFirst";
            this.lblConFirst.Size = new System.Drawing.Size(0, 24);
            this.lblConFirst.TabIndex = 150;
            this.lblConFirst.Visible = false;
            // 
            // lblConUser
            // 
            this.lblConUser.AutoSize = true;
            this.lblConUser.Location = new System.Drawing.Point(1324, 699);
            this.lblConUser.Name = "lblConUser";
            this.lblConUser.Size = new System.Drawing.Size(0, 24);
            this.lblConUser.TabIndex = 149;
            this.lblConUser.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(1265, 66);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 24);
            this.lblUser.TabIndex = 144;
            this.lblUser.Visible = false;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSales);
            this.Controls.Add(this.lblSur);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblConSur);
            this.Controls.Add(this.lblConFirst);
            this.Controls.Add(this.lblConUser);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrail;
        private System.Windows.Forms.DateTimePicker dateOne;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Label lblSur;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblConSur;
        private System.Windows.Forms.Label lblConFirst;
        private System.Windows.Forms.Label lblConUser;
        private System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label containeruser;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}