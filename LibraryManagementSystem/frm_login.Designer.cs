namespace LibraryManagementSystem
{
    partial class frm_login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))); // A professional blue
            this.btn_login.FlatAppearance.BorderSize = 0; // No border
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat; // Flat style
            this.btn_login.ForeColor = System.Drawing.Color.White; // White text on button
            this.btn_login.Location = new System.Drawing.Point(340, 280); // Adjusted placement
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(130, 40); // More standard button size
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false; // Allow custom BackColor
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Username.Location = new System.Drawing.Point(100, 150); // Adjusted
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(71, 19); // Adjusted font size
            this.lbl_Username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_password.Location = new System.Drawing.Point(100, 200); // Adjusted (more consistent spacing)
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(67, 19); // Adjusted font size
            this.lbl_password.Text = "Password";
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))); // Darker textbox background
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; // Flat border
            this.txt_Username.ForeColor = System.Drawing.Color.WhiteSmoke; // White text
            this.txt_Username.Location = new System.Drawing.Point(220, 147); // Adjusted
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(250, 26); // Reduced width, adjusted height for new font
            this.txt_Username.TabIndex = 0; // Better tab index order
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Password.Location = new System.Drawing.Point(220, 197); // Adjusted
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(250, 26);
            this.txt_Password.TabIndex = 1; // Better tab index order
            this.txt_Password.UseSystemPasswordChar = true; // IMPORTANT for password security
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Lighter, modern font for title
            this.lbl_title.ForeColor = System.Drawing.Color.WhiteSmoke; // Bright white for contrast
            this.lbl_title.Location = new System.Drawing.Point(70, 40); // Adjusted for new form size
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(400, 50);
            this.lbl_title.Text = "Library Access"; // Simpler title
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))); // Slightly lighter dark for secondary action
            this.btn_Register.FlatAppearance.BorderSize = 0;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Register.Location = new System.Drawing.Point(200, 280); // Placed to the left of login
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(130, 40);
            this.btn_Register.TabIndex = 3;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F); // Smaller default font size
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))); // Darker, almost black background
            this.ClientSize = new System.Drawing.Size(550, 400); // Reduced size
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.btn_login);
            this.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // Modern font
            this.Name = "frm_login";
            this.Text = "Login - Library System"; // More descriptive title
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_Register;
    }
}