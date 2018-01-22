namespace BANK_FORM_V1
{
    partial class help
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
            this.cancel_bu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancel_bu
            // 
            this.cancel_bu.Location = new System.Drawing.Point(12, 226);
            this.cancel_bu.Name = "cancel_bu";
            this.cancel_bu.Size = new System.Drawing.Size(75, 23);
            this.cancel_bu.TabIndex = 0;
            this.cancel_bu.Text = "Cancel";
            this.cancel_bu.UseVisualStyleBackColor = true;
            this.cancel_bu.Click += new System.EventHandler(this.cancel_bu_Click);
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancel_bu);
            this.Name = "help";
            this.Text = "help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancel_bu;
    }
}