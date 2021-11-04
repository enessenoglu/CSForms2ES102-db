
namespace CSForms2ES102_main.FormIslemleri
{
    partial class frmcevap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lblkdv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam KDV :";
            // 
            // lblad
            // 
            this.lblad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblad.Location = new System.Drawing.Point(294, 83);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(100, 13);
            this.lblad.TabIndex = 2;
            // 
            // lblkdv
            // 
            this.lblkdv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblkdv.Location = new System.Drawing.Point(297, 116);
            this.lblkdv.Name = "lblkdv";
            this.lblkdv.Size = new System.Drawing.Size(100, 13);
            this.lblkdv.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Fiyat :";
            // 
            // lblfiyat
            // 
            this.lblfiyat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblfiyat.Location = new System.Drawing.Point(297, 155);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(100, 13);
            this.lblfiyat.TabIndex = 5;
            // 
            // frmcevap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblkdv);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmcevap";
            this.Text = "frmcevap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblad;
        public System.Windows.Forms.Label lblkdv;
        public System.Windows.Forms.Label lblfiyat;
    }
}