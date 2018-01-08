namespace BANK_FORM_V1
{
    partial class error_login
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
            this.Incorrect = new System.Windows.Forms.Label();
            this.Retry_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Incorrect
            // 
            this.Incorrect.AutoSize = true;
            this.Incorrect.Location = new System.Drawing.Point(29, 21);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(159, 13);
            this.Incorrect.TabIndex = 0;
            this.Incorrect.Text = "Username or password incorrect";
            // 
            // Retry_button
            // 
            this.Retry_button.Location = new System.Drawing.Point(70, 48);
            this.Retry_button.Name = "Retry_button";
            this.Retry_button.Size = new System.Drawing.Size(75, 23);
            this.Retry_button.TabIndex = 1;
            this.Retry_button.Text = "R&etry";
            this.Retry_button.UseVisualStyleBackColor = true;
            this.Retry_button.Click += new System.EventHandler(this.Retry_button_Click);
            // 
            // error_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 83);
            this.Controls.Add(this.Retry_button);
            this.Controls.Add(this.Incorrect);
            this.Name = "error_login";
            this.Text = "error_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Incorrect;
        private System.Windows.Forms.Button Retry_button;
    }
}