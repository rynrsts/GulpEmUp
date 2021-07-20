namespace Point_of_Sales__POS_
{
    partial class Trail
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
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pnlTrail = new System.Windows.Forms.Panel();
            this.containeruser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSur = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblConSur = new System.Windows.Forms.Label();
            this.lblConFirst = new System.Windows.Forms.Label();
            this.lblConUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTrail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrail
            // 
            this.btnTrail.BackColor = System.Drawing.Color.SandyBrown;
            this.btnTrail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrail.ForeColor = System.Drawing.Color.White;
            this.btnTrail.Location = new System.Drawing.Point(412, 6);
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
            this.dateOne.Location = new System.Drawing.Point(972, 10);
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
            this.btnLogOut.Location = new System.Drawing.Point(1189, 6);
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
            this.pnlMain.Controls.Add(this.btnTrail);
            this.pnlMain.Controls.Add(this.dateOne);
            this.pnlMain.Controls.Add(this.btnLogOut);
            this.pnlMain.Controls.Add(this.btnEmployee);
            this.pnlMain.Controls.Add(this.btnInventory);
            this.pnlMain.Location = new System.Drawing.Point(40, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1285, 40);
            this.pnlMain.TabIndex = 155;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(54, 6);
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
            this.btnInventory.Location = new System.Drawing.Point(160, 5);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(140, 32);
            this.btnInventory.TabIndex = 125;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // pnlTrail
            // 
            this.pnlTrail.BackColor = System.Drawing.Color.LightPink;
            this.pnlTrail.Controls.Add(this.containeruser);
            this.pnlTrail.Controls.Add(this.dataGridView1);
            this.pnlTrail.Location = new System.Drawing.Point(40, 70);
            this.pnlTrail.Name = "pnlTrail";
            this.pnlTrail.Size = new System.Drawing.Size(1286, 600);
            this.pnlTrail.TabIndex = 156;
            // 
            // containeruser
            // 
            this.containeruser.AutoSize = true;
            this.containeruser.Location = new System.Drawing.Point(226, 293);
            this.containeruser.Name = "containeruser";
            this.containeruser.Size = new System.Drawing.Size(64, 24);
            this.containeruser.TabIndex = 161;
            this.containeruser.Text = "label5";
            this.containeruser.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(614, 328);
            this.dataGridView1.TabIndex = 160;
            // 
            // lblSur
            // 
            this.lblSur.AutoSize = true;
            this.lblSur.Location = new System.Drawing.Point(1279, 125);
            this.lblSur.Name = "lblSur";
            this.lblSur.Size = new System.Drawing.Size(0, 24);
            this.lblSur.TabIndex = 154;
            this.lblSur.Visible = false;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(1272, 91);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(0, 24);
            this.lblFirst.TabIndex = 153;
            this.lblFirst.Visible = false;
            // 
            // lblConSur
            // 
            this.lblConSur.AutoSize = true;
            this.lblConSur.Location = new System.Drawing.Point(1305, 701);
            this.lblConSur.Name = "lblConSur";
            this.lblConSur.Size = new System.Drawing.Size(0, 24);
            this.lblConSur.TabIndex = 159;
            this.lblConSur.Visible = false;
            // 
            // lblConFirst
            // 
            this.lblConFirst.AutoSize = true;
            this.lblConFirst.Location = new System.Drawing.Point(1325, 701);
            this.lblConFirst.Name = "lblConFirst";
            this.lblConFirst.Size = new System.Drawing.Size(0, 24);
            this.lblConFirst.TabIndex = 158;
            this.lblConFirst.Visible = false;
            // 
            // lblConUser
            // 
            this.lblConUser.AutoSize = true;
            this.lblConUser.Location = new System.Drawing.Point(1338, 701);
            this.lblConUser.Name = "lblConUser";
            this.lblConUser.Size = new System.Drawing.Size(0, 24);
            this.lblConUser.TabIndex = 157;
            this.lblConUser.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(1279, 68);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 24);
            this.lblUser.TabIndex = 152;
            this.lblUser.Visible = false;
            // 
            // Trail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTrail);
            this.Controls.Add(this.lblSur);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblConSur);
            this.Controls.Add(this.lblConFirst);
            this.Controls.Add(this.lblConUser);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Trail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trail";
            this.Load += new System.EventHandler(this.Trail_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlTrail.ResumeLayout(false);
            this.pnlTrail.PerformLayout();
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
        private System.Windows.Forms.Panel pnlTrail;
        private System.Windows.Forms.Label lblSur;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblConSur;
        private System.Windows.Forms.Label lblConFirst;
        private System.Windows.Forms.Label lblConUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label containeruser;
    }
}