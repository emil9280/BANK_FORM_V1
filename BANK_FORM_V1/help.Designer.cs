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
            this.info_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_bu
            // 
            this.cancel_bu.Location = new System.Drawing.Point(111, 35);
            this.cancel_bu.Name = "cancel_bu";
            this.cancel_bu.Size = new System.Drawing.Size(75, 23);
            this.cancel_bu.TabIndex = 0;
            this.cancel_bu.Text = "Cancel";
            this.cancel_bu.UseVisualStyleBackColor = true;
            this.cancel_bu.Click += new System.EventHandler(this.cancel_bu_Click);
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_label.Location = new System.Drawing.Point(23, 15);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(249, 17);
            this.info_label.TabIndex = 1;
            this.info_label.Text = "For help contact system adminestrator";
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 73);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.cancel_bu);
            this.Name = "help";
            this.Text = "help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_bu;
        private System.Windows.Forms.Label info_label;
    }
}