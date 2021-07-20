namespace Point_of_Sales__POS_
{
    partial class Recipe
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddRecipe = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtbxQuantity = new System.Windows.Forms.TextBox();
            this.lblConID = new System.Windows.Forms.Label();
            this.cmbbxRecipe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(281, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 50);
            this.btnCancel.TabIndex = 159;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAddRecipe
            // 
            this.lblAddRecipe.AutoSize = true;
            this.lblAddRecipe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRecipe.Location = new System.Drawing.Point(178, 60);
            this.lblAddRecipe.Name = "lblAddRecipe";
            this.lblAddRecipe.Size = new System.Drawing.Size(144, 32);
            this.lblAddRecipe.TabIndex = 158;
            this.lblAddRecipe.Text = "Add Recipe";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(121, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 50);
            this.btnAdd.TabIndex = 156;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.Location = new System.Drawing.Point(97, 145);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(64, 21);
            this.lblRecipe.TabIndex = 147;
            this.lblRecipe.Text = "Recipe:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(89, 193);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(72, 21);
            this.lblQuantity.TabIndex = 148;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtbxQuantity
            // 
            this.txtbxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxQuantity.Location = new System.Drawing.Point(211, 191);
            this.txtbxQuantity.MaxLength = 27;
            this.txtbxQuantity.Name = "txtbxQuantity";
            this.txtbxQuantity.Size = new System.Drawing.Size(200, 29);
            this.txtbxQuantity.TabIndex = 153;
            this.txtbxQuantity.TextChanged += new System.EventHandler(this.txtbxQuantity_TextChanged);
            // 
            // lblConID
            // 
            this.lblConID.AutoSize = true;
            this.lblConID.Location = new System.Drawing.Point(454, 368);
            this.lblConID.Name = "lblConID";
            this.lblConID.Size = new System.Drawing.Size(19, 21);
            this.lblConID.TabIndex = 160;
            this.lblConID.Text = "o";
            this.lblConID.Visible = false;
            // 
            // cmbbxRecipe
            // 
            this.cmbbxRecipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxRecipe.FormattingEnabled = true;
            this.cmbbxRecipe.Items.AddRange(new object[] {
            "Buffalo Wings",
            "Onion Rings",
            "Mojojastic",
            "Nachos",
            "Sandwich",
            "Dynamite",
            "R Lemonade",
            "B Lemonade",
            "P Lemonade",
            "Iced Coffee",
            "Coffee Jelly",
            "Ch Milkshake",
            "Co Milkshake",
            "M Milkshake",
            "P Milkshake",
            "S Milkshake"});
            this.cmbbxRecipe.Location = new System.Drawing.Point(211, 142);
            this.cmbbxRecipe.Name = "cmbbxRecipe";
            this.cmbbxRecipe.Size = new System.Drawing.Size(200, 29);
            this.cmbbxRecipe.TabIndex = 161;
            // 
            // Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.cmbbxRecipe);
            this.Controls.Add(this.lblConID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAddRecipe);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtbxQuantity);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Recipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAddRecipe;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtbxQuantity;
        private System.Windows.Forms.Label lblConID;
        private System.Windows.Forms.ComboBox cmbbxRecipe;
    }
}