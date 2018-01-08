namespace BANK_FORM_V1
{
    partial class Form1
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
            this.greeting = new System.Windows.Forms.Label();
            this.Username_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Username_TB = new System.Windows.Forms.TextBox();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.Signup_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Location = new System.Drawing.Point(24, 9);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(161, 13);
            this.greeting.TabIndex = 0;
            this.greeting.Text = "Welcome to bank of techcollege";
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(12, 41);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(55, 13);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(15, 67);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(53, 13);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // Username_TB
            // 
            this.Username_TB.Location = new System.Drawing.Point(94, 41);
            this.Username_TB.Name = "Username_TB";
            this.Username_TB.Size = new System.Drawing.Size(100, 20);
            this.Username_TB.TabIndex = 3;
            this.Username_TB.TextChanged += new System.EventHandler(this.Username_TB_TextChanged);
            // 
            // Password_TB
            // 
            this.Password_TB.Location = new System.Drawing.Point(94, 68);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(100, 20);
            this.Password_TB.TabIndex = 4;
            this.Password_TB.TextChanged += new System.EventHandler(this.Password_TB_TextChanged);
            // 
            // Signup_button
            // 
            this.Signup_button.Location = new System.Drawing.Point(12, 104);
            this.Signup_button.Name = "Signup_button";
            this.Signup_button.Size = new System.Drawing.Size(75, 23);
            this.Signup_button.TabIndex = 5;
            this.Signup_button.Text = "Signup";
            this.Signup_button.UseVisualStyleBackColor = true;
            this.Signup_button.Click += new System.EventHandler(this.Signup_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(110, 104);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 148);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.Signup_button);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.Username_TB);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.greeting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Username_TB;
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.Button Signup_button;
        private System.Windows.Forms.Button login_button;
    }
}

