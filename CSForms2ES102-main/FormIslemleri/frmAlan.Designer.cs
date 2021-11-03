
namespace CSForms2ES102_main.FormIslemleri
{
    partial class frmAlan
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adres :";
            // 
            // lblAd
            // 
            this.lblAd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAd.Location = new System.Drawing.Point(185, 46);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(183, 13);
            this.lblAd.TabIndex = 0;
            // 
            // lblSoyad
            // 
            this.lblSoyad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSoyad.Location = new System.Drawing.Point(185, 72);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(183, 13);
            this.lblSoyad.TabIndex = 0;
            // 
            // lblAdres
            // 
            this.lblAdres.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdres.Location = new System.Drawing.Point(185, 99);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(183, 115);
            this.lblAdres.TabIndex = 0;
            // 
            // frmAlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlan";
            this.Text = "frmAlan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlan_FormClosing);
            this.Load += new System.EventHandler(this.frmAlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblAd;
        public System.Windows.Forms.Label lblSoyad;
        public System.Windows.Forms.Label lblAdres;
    }
}