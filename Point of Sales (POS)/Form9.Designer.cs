namespace Point_of_Sales__POS_
{
    partial class Inventory
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
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.dtgrdInventory = new System.Windows.Forms.DataGridView();
            this.dateOne = new System.Windows.Forms.DateTimePicker();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.containeruser = new System.Windows.Forms.Label();
            this.lblConSur = new System.Windows.Forms.Label();
            this.lblConFirst = new System.Windows.Forms.Label();
            this.lblConUser = new System.Windows.Forms.Label();
            this.lblSur = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdInventory)).BeginInit();
            this.pnlInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.BackColor = System.Drawing.Color.Green;
            this.btnAddRecipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRecipe.FlatAppearance.BorderSize = 0;
            this.btnAddRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecipe.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecipe.ForeColor = System.Drawing.Color.White;
            this.btnAddRecipe.Location = new System.Drawing.Point(878, 304);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(160, 50);
            this.btnAddRecipe.TabIndex = 148;
            this.btnAddRecipe.TabStop = false;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = false;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(864, 22);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(19, 21);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "o";
            this.lblQuantity.Visible = false;
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Location = new System.Drawing.Point(889, 22);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(19, 21);
            this.lblRecipe.TabIndex = 1;
            this.lblRecipe.Text = "o";
            this.lblRecipe.Visible = false;
            // 
            // dtgrdInventory
            // 
            this.dtgrdInventory.BackgroundColor = System.Drawing.Color.White;
            this.dtgrdInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdInventory.GridColor = System.Drawing.SystemColors.Control;
            this.dtgrdInventory.Location = new System.Drawing.Point(288, 101);
            this.dtgrdInventory.Name = "dtgrdInventory";
            this.dtgrdInventory.RowHeadersWidth = 51;
            this.dtgrdInventory.Size = new System.Drawing.Size(550, 450);
            this.dtgrdInventory.TabIndex = 0;
            this.dtgrdInventory.TabStop = false;
            // 
            // dateOne
            // 
            this.dateOne.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOne.Enabled = false;
            this.dateOne.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOne.Location = new System.Drawing.Point(946, 18);
            this.dateOne.Name = "dateOne";
            this.dateOne.Size = new System.Drawing.Size(270, 27);
            this.dateOne.TabIndex = 125;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(1228, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(110, 40);
            this.btnLogOut.TabIndex = 129;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(12, 12);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(110, 40);
            this.btnEmployee.TabIndex = 126;
            this.btnEmployee.TabStop = false;
            this.btnEmployee.Text = "Users";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(134, 12);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(145, 40);
            this.btnInventory.TabIndex = 125;
            this.btnInventory.TabStop = false;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // pnlInventory
            // 
            this.pnlInventory.BackColor = System.Drawing.Color.LightPink;
            this.pnlInventory.Controls.Add(this.btnAddRecipe);
            this.pnlInventory.Controls.Add(this.dtgrdInventory);
            this.pnlInventory.Location = new System.Drawing.Point(12, 64);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(1326, 653);
            this.pnlInventory.TabIndex = 156;
            // 
            // containeruser
            // 
            this.containeruser.AutoSize = true;
            this.containeruser.Location = new System.Drawing.Point(806, 22);
            this.containeruser.Name = "containeruser";
            this.containeruser.Size = new System.Drawing.Size(52, 21);
            this.containeruser.TabIndex = 149;
            this.containeruser.Text = "label5";
            this.containeruser.Visible = false;
            // 
            // lblConSur
            // 
            this.lblConSur.AutoSize = true;
            this.lblConSur.Location = new System.Drawing.Point(1416, 768);
            this.lblConSur.Name = "lblConSur";
            this.lblConSur.Size = new System.Drawing.Size(0, 21);
            this.lblConSur.TabIndex = 155;
            this.lblConSur.Visible = false;
            // 
            // lblConFirst
            // 
            this.lblConFirst.AutoSize = true;
            this.lblConFirst.Location = new System.Drawing.Point(1436, 768);
            this.lblConFirst.Name = "lblConFirst";
            this.lblConFirst.Size = new System.Drawing.Size(0, 21);
            this.lblConFirst.TabIndex = 154;
            this.lblConFirst.Visible = false;
            // 
            // lblConUser
            // 
            this.lblConUser.AutoSize = true;
            this.lblConUser.Location = new System.Drawing.Point(1449, 768);
            this.lblConUser.Name = "lblConUser";
            this.lblConUser.Size = new System.Drawing.Size(0, 21);
            this.lblConUser.TabIndex = 153;
            this.lblConUser.Visible = false;
            // 
            // lblSur
            // 
            this.lblSur.AutoSize = true;
            this.lblSur.Location = new System.Drawing.Point(1390, 132);
            this.lblSur.Name = "lblSur";
            this.lblSur.Size = new System.Drawing.Size(0, 21);
            this.lblSur.TabIndex = 150;
            this.lblSur.Visible = false;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(1383, 94);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(0, 21);
            this.lblFirst.TabIndex = 149;
            this.lblFirst.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(1390, 69);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 21);
            this.lblUser.TabIndex = 148;
            this.lblUser.Visible = false;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.containeruser);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.dateOne);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this.pnlInventory);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.lblConSur);
            this.Controls.Add(this.lblConFirst);
            this.Controls.Add(this.lblConUser);
            this.Controls.Add(this.lblSur);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdInventory)).EndInit();
            this.pnlInventory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRecipe;
        public System.Windows.Forms.DataGridView dtgrdInventory;
        private System.Windows.Forms.DateTimePicker dateOne;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.Label lblConSur;
        private System.Windows.Forms.Label lblConFirst;
        private System.Windows.Forms.Label lblConUser;
        private System.Windows.Forms.Label lblSur;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label containeruser;
    }
}