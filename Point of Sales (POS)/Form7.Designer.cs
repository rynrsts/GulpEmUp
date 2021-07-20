namespace Point_of_Sales__POS_
{
    partial class Create
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFN = new System.Windows.Forms.Label();
            this.cmbbxUT = new System.Windows.Forms.ComboBox();
            this.txtbxFN = new System.Windows.Forms.TextBox();
            this.txtbxPW = new System.Windows.Forms.TextBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.txtbxUN = new System.Windows.Forms.TextBox();
            this.lblUT = new System.Windows.Forms.Label();
            this.txtbxSN = new System.Windows.Forms.TextBox();
            this.lblUN = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(123, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 50);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(78, 72);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(85, 21);
            this.lblFN.TabIndex = 21;
            this.lblFN.Text = "Firstname:";
            // 
            // cmbbxUT
            // 
            this.cmbbxUT.BackColor = System.Drawing.Color.White;
            this.cmbbxUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxUT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxUT.FormattingEnabled = true;
            this.cmbbxUT.Items.AddRange(new object[] {
            "Cashier",
            "Manager"});
            this.cmbbxUT.Location = new System.Drawing.Point(203, 158);
            this.cmbbxUT.Name = "cmbbxUT";
            this.cmbbxUT.Size = new System.Drawing.Size(200, 29);
            this.cmbbxUT.TabIndex = 31;
            this.cmbbxUT.TabStop = false;
            // 
            // txtbxFN
            // 
            this.txtbxFN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxFN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFN.Location = new System.Drawing.Point(203, 70);
            this.txtbxFN.MaxLength = 27;
            this.txtbxFN.Name = "txtbxFN";
            this.txtbxFN.Size = new System.Drawing.Size(200, 29);
            this.txtbxFN.TabIndex = 25;
            this.txtbxFN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxFN_KeyPress);
            // 
            // txtbxPW
            // 
            this.txtbxPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxPW.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPW.Location = new System.Drawing.Point(203, 247);
            this.txtbxPW.MaxLength = 17;
            this.txtbxPW.Name = "txtbxPW";
            this.txtbxPW.Size = new System.Drawing.Size(200, 29);
            this.txtbxPW.TabIndex = 29;
            this.txtbxPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPW_KeyPress);
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSN.Location = new System.Drawing.Point(85, 116);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(78, 21);
            this.lblSN.TabIndex = 22;
            this.lblSN.Text = "Surname:";
            // 
            // txtbxUN
            // 
            this.txtbxUN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxUN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUN.Location = new System.Drawing.Point(203, 203);
            this.txtbxUN.MaxLength = 17;
            this.txtbxUN.Name = "txtbxUN";
            this.txtbxUN.Size = new System.Drawing.Size(200, 29);
            this.txtbxUN.TabIndex = 28;
            this.txtbxUN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxUN_KeyPress);
            // 
            // lblUT
            // 
            this.lblUT.AutoSize = true;
            this.lblUT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUT.Location = new System.Drawing.Point(77, 161);
            this.lblUT.Name = "lblUT";
            this.lblUT.Size = new System.Drawing.Size(86, 21);
            this.lblUT.TabIndex = 23;
            this.lblUT.Text = "User Type:";
            // 
            // txtbxSN
            // 
            this.txtbxSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxSN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSN.Location = new System.Drawing.Point(203, 114);
            this.txtbxSN.MaxLength = 27;
            this.txtbxSN.Name = "txtbxSN";
            this.txtbxSN.Size = new System.Drawing.Size(200, 29);
            this.txtbxSN.TabIndex = 27;
            this.txtbxSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxSN_KeyPress);
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.Location = new System.Drawing.Point(76, 205);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(87, 21);
            this.lblUN.TabIndex = 24;
            this.lblUN.Text = "Username:";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPW.Location = new System.Drawing.Point(80, 249);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(83, 21);
            this.lblPW.TabIndex = 26;
            this.lblPW.Text = "Password:";
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.Location = new System.Drawing.Point(177, 8);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(146, 32);
            this.lblCreate.TabIndex = 32;
            this.lblCreate.Text = "Create User";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(273, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 50);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 10);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 21);
            this.lblUser.TabIndex = 146;
            this.lblUser.Visible = false;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(32, 10);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(0, 21);
            this.lblFirst.TabIndex = 145;
            this.lblFirst.Visible = false;
            // 
            // lblSur
            // 
            this.lblSur.AutoSize = true;
            this.lblSur.Location = new System.Drawing.Point(45, 10);
            this.lblSur.Name = "lblSur";
            this.lblSur.Size = new System.Drawing.Size(0, 21);
            this.lblSur.TabIndex = 144;
            this.lblSur.Visible = false;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblSur);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.cmbbxUT);
            this.Controls.Add(this.txtbxFN);
            this.Controls.Add(this.txtbxPW);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.txtbxUN);
            this.Controls.Add(this.lblUT);
            this.Controls.Add(this.txtbxSN);
            this.Controls.Add(this.lblUN);
            this.Controls.Add(this.lblPW);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.ComboBox cmbbxUT;
        private System.Windows.Forms.TextBox txtbxFN;
        private System.Windows.Forms.TextBox txtbxPW;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.TextBox txtbxUN;
        private System.Windows.Forms.Label lblUT;
        private System.Windows.Forms.TextBox txtbxSN;
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSur;
    }
}