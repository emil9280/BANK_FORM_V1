namespace BANK_FORM_V1
{
    partial class Signup
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
            this.new_username_tb = new System.Windows.Forms.TextBox();
            this.new_password_tb = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.new_email_tb = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.add_user = new System.Windows.Forms.Button();
            this.repass_label = new System.Windows.Forms.Label();
            this.repass_tb = new System.Windows.Forms.TextBox();
            this.full_name_label = new System.Windows.Forms.Label();
            this.full_name_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // new_username_tb
            // 
            this.new_username_tb.Location = new System.Drawing.Point(168, 46);
            this.new_username_tb.Name = "new_username_tb";
            this.new_username_tb.Size = new System.Drawing.Size(100, 20);
            this.new_username_tb.TabIndex = 0;
            // 
            // new_password_tb
            // 
            this.new_password_tb.Location = new System.Drawing.Point(168, 73);
            this.new_password_tb.Name = "new_password_tb";
            this.new_password_tb.PasswordChar = '*';
            this.new_password_tb.Size = new System.Drawing.Size(100, 20);
            this.new_password_tb.TabIndex = 1;
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(12, 186);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // new_email_tb
            // 
            this.new_email_tb.Location = new System.Drawing.Point(168, 126);
            this.new_email_tb.Name = "new_email_tb";
            this.new_email_tb.Size = new System.Drawing.Size(100, 20);
            this.new_email_tb.TabIndex = 3;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(23, 46);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(55, 13);
            this.username_label.TabIndex = 4;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(23, 73);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Password";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(23, 126);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(35, 13);
            this.email_label.TabIndex = 6;
            this.email_label.Text = "E-mail";
            // 
            // add_user
            // 
            this.add_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_user.Location = new System.Drawing.Point(196, 186);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(75, 23);
            this.add_user.TabIndex = 7;
            this.add_user.Text = "Add user";
            this.add_user.UseVisualStyleBackColor = true;
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // repass_label
            // 
            this.repass_label.AutoSize = true;
            this.repass_label.Location = new System.Drawing.Point(23, 100);
            this.repass_label.Name = "repass_label";
            this.repass_label.Size = new System.Drawing.Size(93, 13);
            this.repass_label.TabIndex = 8;
            this.repass_label.Text = "Reenter password";
            // 
            // repass_tb
            // 
            this.repass_tb.Location = new System.Drawing.Point(167, 100);
            this.repass_tb.Name = "repass_tb";
            this.repass_tb.PasswordChar = '*';
            this.repass_tb.Size = new System.Drawing.Size(100, 20);
            this.repass_tb.TabIndex = 9;
            // 
            // full_name_label
            // 
            this.full_name_label.AutoSize = true;
            this.full_name_label.Location = new System.Drawing.Point(24, 20);
            this.full_name_label.Name = "full_name_label";
            this.full_name_label.Size = new System.Drawing.Size(54, 13);
            this.full_name_label.TabIndex = 10;
            this.full_name_label.Text = "Full Name";
            // 
            // full_name_tb
            // 
            this.full_name_tb.Location = new System.Drawing.Point(168, 20);
            this.full_name_tb.Name = "full_name_tb";
            this.full_name_tb.Size = new System.Drawing.Size(100, 20);
            this.full_name_tb.TabIndex = 11;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 218);
            this.Controls.Add(this.full_name_tb);
            this.Controls.Add(this.full_name_label);
            this.Controls.Add(this.repass_tb);
            this.Controls.Add(this.repass_label);
            this.Controls.Add(this.add_user);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.new_email_tb);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.new_password_tb);
            this.Controls.Add(this.new_username_tb);
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox new_username_tb;
        private System.Windows.Forms.TextBox new_password_tb;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox new_email_tb;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.Label repass_label;
        private System.Windows.Forms.TextBox repass_tb;
        private System.Windows.Forms.Label full_name_label;
        private System.Windows.Forms.TextBox full_name_tb;
    }
}