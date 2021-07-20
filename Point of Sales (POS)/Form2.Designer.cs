namespace Point_of_Sales__POS_
{
    partial class LogIn
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtbxUser = new System.Windows.Forms.TextBox();
            this.txtbxPass = new System.Windows.Forms.TextBox();
            this.pcbxLogIn = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.pcbxLogo = new System.Windows.Forms.PictureBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(930, 13);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 24);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtbxUser
            // 
            this.txtbxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUser.Location = new System.Drawing.Point(745, 248);
            this.txtbxUser.MaxLength = 17;
            this.txtbxUser.Name = "txtbxUser";
            this.txtbxUser.Size = new System.Drawing.Size(200, 29);
            this.txtbxUser.TabIndex = 2;
            // 
            // txtbxPass
            // 
            this.txtbxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPass.Location = new System.Drawing.Point(745, 297);
            this.txtbxPass.MaxLength = 17;
            this.txtbxPass.Name = "txtbxPass";
            this.txtbxPass.PasswordChar = '*';
            this.txtbxPass.Size = new System.Drawing.Size(200, 29);
            this.txtbxPass.TabIndex = 3;
            // 
            // pcbxLogIn
            // 
            this.pcbxLogIn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pcbxLogIn.Location = new System.Drawing.Point(525, 180);
            this.pcbxLogIn.Name = "pcbxLogIn";
            this.pcbxLogIn.Size = new System.Drawing.Size(500, 300);
            this.pcbxLogIn.TabIndex = 7;
            this.pcbxLogIn.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Black;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(604, 250);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(91, 21);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.Black;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(604, 299);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(86, 21);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Password:";
            // 
            // pcbxLogo
            // 
            this.pcbxLogo.BackgroundImage = global::Point_of_Sales__POS_.Properties.Resources.Gulp__Em_Up1;
            this.pcbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbxLogo.Location = new System.Drawing.Point(175, 180);
            this.pcbxLogo.Name = "pcbxLogo";
            this.pcbxLogo.Size = new System.Drawing.Size(300, 300);
            this.pcbxLogo.TabIndex = 10;
            this.pcbxLogo.TabStop = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(845, 9);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(0, 21);
            this.lblUserType.TabIndex = 11;
            this.lblUserType.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(608, 366);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogin.Size = new System.Drawing.Size(337, 45);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LogIn
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.pcbxLogo);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtbxPass);
            this.Controls.Add(this.txtbxUser);
            this.Controls.Add(this.pcbxLogIn);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtbxUser;
        private System.Windows.Forms.TextBox txtbxPass;
        private System.Windows.Forms.PictureBox pcbxLogIn;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.PictureBox pcbxLogo;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Button btnLogin;
    }
}