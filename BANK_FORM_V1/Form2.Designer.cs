namespace BANK_FORM_V1
{
    partial class Form2
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
            this.choose_label = new System.Windows.Forms.Label();
            this.Transfere_button = new System.Windows.Forms.Button();
            this.Help_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Balance_label = new System.Windows.Forms.Label();
            this.account_label = new System.Windows.Forms.Label();
            this.User_ID_number_label = new System.Windows.Forms.Label();
            this.Close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choose_label
            // 
            this.choose_label.AutoSize = true;
            this.choose_label.Location = new System.Drawing.Point(9, 22);
            this.choose_label.Name = "choose_label";
            this.choose_label.Size = new System.Drawing.Size(133, 13);
            this.choose_label.TabIndex = 0;
            this.choose_label.Text = "Please choose deportment";
            // 
            // Transfere_button
            // 
            this.Transfere_button.Location = new System.Drawing.Point(12, 144);
            this.Transfere_button.Name = "Transfere_button";
            this.Transfere_button.Size = new System.Drawing.Size(75, 23);
            this.Transfere_button.TabIndex = 2;
            this.Transfere_button.Text = "Transfere";
            this.Transfere_button.UseVisualStyleBackColor = true;
            this.Transfere_button.Click += new System.EventHandler(this.Transfere_button_Click);
            // 
            // Help_button
            // 
            this.Help_button.Location = new System.Drawing.Point(87, 144);
            this.Help_button.Name = "Help_button";
            this.Help_button.Size = new System.Drawing.Size(75, 23);
            this.Help_button.TabIndex = 3;
            this.Help_button.Text = "Help";
            this.Help_button.UseVisualStyleBackColor = true;
            this.Help_button.Click += new System.EventHandler(this.Help_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Balance_label
            // 
            this.Balance_label.AutoSize = true;
            this.Balance_label.Location = new System.Drawing.Point(203, 74);
            this.Balance_label.Name = "Balance_label";
            this.Balance_label.Size = new System.Drawing.Size(42, 13);
            this.Balance_label.TabIndex = 5;
            this.Balance_label.Text = "xxxxxxx";
            // 
            // account_label
            // 
            this.account_label.AutoSize = true;
            this.account_label.Location = new System.Drawing.Point(9, 55);
            this.account_label.Name = "account_label";
            this.account_label.Size = new System.Drawing.Size(52, 13);
            this.account_label.TabIndex = 6;
            this.account_label.Text = "Accounts";
            // 
            // User_ID_number_label
            // 
            this.User_ID_number_label.AutoSize = true;
            this.User_ID_number_label.Location = new System.Drawing.Point(178, 9);
            this.User_ID_number_label.Name = "User_ID_number_label";
            this.User_ID_number_label.Size = new System.Drawing.Size(0, 13);
            this.User_ID_number_label.TabIndex = 8;
            // 
            // Close_button
            // 
            this.Close_button.Location = new System.Drawing.Point(163, 144);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(75, 23);
            this.Close_button.TabIndex = 9;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 179);
            this.ControlBox = false;
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.User_ID_number_label);
            this.Controls.Add(this.account_label);
            this.Controls.Add(this.Balance_label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Help_button);
            this.Controls.Add(this.Transfere_button);
            this.Controls.Add(this.choose_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choose_label;
        private System.Windows.Forms.Button Transfere_button;
        private System.Windows.Forms.Button Help_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Balance_label;
        private System.Windows.Forms.Label account_label;
        private System.Windows.Forms.Label User_ID_number_label;
        private System.Windows.Forms.Button Close_button;
    }
}