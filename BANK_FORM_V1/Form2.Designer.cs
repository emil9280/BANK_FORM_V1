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
            this.Accounts_buttom = new System.Windows.Forms.Button();
            this.Transfere_button = new System.Windows.Forms.Button();
            this.Help_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choose_label
            // 
            this.choose_label.AutoSize = true;
            this.choose_label.Location = new System.Drawing.Point(30, 19);
            this.choose_label.Name = "choose_label";
            this.choose_label.Size = new System.Drawing.Size(133, 13);
            this.choose_label.TabIndex = 0;
            this.choose_label.Text = "Please choose deportment";
            // 
            // Accounts_buttom
            // 
            this.Accounts_buttom.Location = new System.Drawing.Point(56, 66);
            this.Accounts_buttom.Name = "Accounts_buttom";
            this.Accounts_buttom.Size = new System.Drawing.Size(75, 23);
            this.Accounts_buttom.TabIndex = 1;
            this.Accounts_buttom.Text = "Accounts";
            this.Accounts_buttom.UseVisualStyleBackColor = true;
            this.Accounts_buttom.Click += new System.EventHandler(this.Accounts_buttom_Click);
            // 
            // Transfere_button
            // 
            this.Transfere_button.Location = new System.Drawing.Point(56, 96);
            this.Transfere_button.Name = "Transfere_button";
            this.Transfere_button.Size = new System.Drawing.Size(75, 23);
            this.Transfere_button.TabIndex = 2;
            this.Transfere_button.Text = "Transfere";
            this.Transfere_button.UseVisualStyleBackColor = true;
            this.Transfere_button.Click += new System.EventHandler(this.Transfere_button_Click);
            // 
            // Help_button
            // 
            this.Help_button.Location = new System.Drawing.Point(56, 126);
            this.Help_button.Name = "Help_button";
            this.Help_button.Size = new System.Drawing.Size(75, 23);
            this.Help_button.TabIndex = 3;
            this.Help_button.Text = "Help";
            this.Help_button.UseVisualStyleBackColor = true;
            this.Help_button.Click += new System.EventHandler(this.Help_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 178);
            this.Controls.Add(this.Help_button);
            this.Controls.Add(this.Transfere_button);
            this.Controls.Add(this.Accounts_buttom);
            this.Controls.Add(this.choose_label);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choose_label;
        private System.Windows.Forms.Button Accounts_buttom;
        private System.Windows.Forms.Button Transfere_button;
        private System.Windows.Forms.Button Help_button;
    }
}