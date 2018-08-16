namespace BANK_FORM_V1
{
    partial class Transfere
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
            this.From_CoBo = new System.Windows.Forms.ComboBox();
            this.Too_CoBo = new System.Windows.Forms.ComboBox();
            this.Amount_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Transfere_Bu = new System.Windows.Forms.Button();
            this.Error_lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_bu
            // 
            this.cancel_bu.Location = new System.Drawing.Point(127, 113);
            this.cancel_bu.Name = "cancel_bu";
            this.cancel_bu.Size = new System.Drawing.Size(75, 23);
            this.cancel_bu.TabIndex = 0;
            this.cancel_bu.Text = "Cancel";
            this.cancel_bu.UseVisualStyleBackColor = true;
            this.cancel_bu.Click += new System.EventHandler(this.cancel_bu_Click);
            // 
            // From_CoBo
            // 
            this.From_CoBo.FormattingEnabled = true;
            this.From_CoBo.Location = new System.Drawing.Point(12, 12);
            this.From_CoBo.Name = "From_CoBo";
            this.From_CoBo.Size = new System.Drawing.Size(121, 21);
            this.From_CoBo.TabIndex = 8;
            // 
            // Too_CoBo
            // 
            this.Too_CoBo.FormattingEnabled = true;
            this.Too_CoBo.Location = new System.Drawing.Point(12, 40);
            this.Too_CoBo.Name = "Too_CoBo";
            this.Too_CoBo.Size = new System.Drawing.Size(121, 21);
            this.Too_CoBo.TabIndex = 2;
            // 
            // Amount_TB
            // 
            this.Amount_TB.Location = new System.Drawing.Point(33, 67);
            this.Amount_TB.Name = "Amount_TB";
            this.Amount_TB.Size = new System.Drawing.Size(100, 20);
            this.Amount_TB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Too account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // Transfere_Bu
            // 
            this.Transfere_Bu.Location = new System.Drawing.Point(33, 113);
            this.Transfere_Bu.Name = "Transfere_Bu";
            this.Transfere_Bu.Size = new System.Drawing.Size(75, 23);
            this.Transfere_Bu.TabIndex = 7;
            this.Transfere_Bu.Text = "Transfere";
            this.Transfere_Bu.UseVisualStyleBackColor = true;
            this.Transfere_Bu.Click += new System.EventHandler(this.Transfere_Bu_Click);
            // 
            // Error_lable
            // 
            this.Error_lable.AutoSize = true;
            this.Error_lable.Location = new System.Drawing.Point(30, 90);
            this.Error_lable.Name = "Error_lable";
            this.Error_lable.Size = new System.Drawing.Size(0, 13);
            this.Error_lable.TabIndex = 8;
            // 
            // Transfere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 148);
            this.Controls.Add(this.Error_lable);
            this.Controls.Add(this.Transfere_Bu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Amount_TB);
            this.Controls.Add(this.Too_CoBo);
            this.Controls.Add(this.From_CoBo);
            this.Controls.Add(this.cancel_bu);
            this.Name = "Transfere";
            this.Text = "Transfere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_bu;
        private System.Windows.Forms.ComboBox From_CoBo;
        private System.Windows.Forms.ComboBox Too_CoBo;
        private System.Windows.Forms.TextBox Amount_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Transfere_Bu;
        private System.Windows.Forms.Label Error_lable;
    }
}