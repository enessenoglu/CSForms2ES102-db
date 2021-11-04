
namespace CSForms2ES102_main.OkulIslemleri
{
    partial class frmBolumler
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
            this.scPanel = new System.Windows.Forms.SplitContainer();
            this.liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scPanel)).BeginInit();
            this.scPanel.Panel1.SuspendLayout();
            this.scPanel.Panel2.SuspendLayout();
            this.scPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.SuspendLayout();
            // 
            // scPanel
            // 
            this.scPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scPanel.Location = new System.Drawing.Point(0, 0);
            this.scPanel.Name = "scPanel";
            this.scPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scPanel.Panel1
            // 
            this.scPanel.Panel1.BackColor = System.Drawing.Color.Silver;
            this.scPanel.Panel1.Controls.Add(this.btnKayit);
            this.scPanel.Panel1.Controls.Add(this.txtBolumAdi);
            this.scPanel.Panel1.Controls.Add(this.label1);
            // 
            // scPanel.Panel2
            // 
            this.scPanel.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.scPanel.Panel2.Controls.Add(this.liste);
            this.scPanel.Size = new System.Drawing.Size(618, 302);
            this.scPanel.SplitterDistance = 99;
            this.scPanel.TabIndex = 0;
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BolumAdi});
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(614, 195);
            this.liste.TabIndex = 0;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Sıra No";
            this.Id.Name = "Id";
            this.Id.Width = 67;
            // 
            // BolumAdi
            // 
            this.BolumAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BolumAdi.HeaderText = "Bölüm Adı";
            this.BolumAdi.Name = "BolumAdi";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm Adı Giriş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBolumAdi.Location = new System.Drawing.Point(0, 23);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(614, 20);
            this.txtBolumAdi.TabIndex = 1;
            this.txtBolumAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKayit
            // 
            this.btnKayit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKayit.Location = new System.Drawing.Point(529, 49);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 33);
            this.btnKayit.TabIndex = 2;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // frmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 302);
            this.Controls.Add(this.scPanel);
            this.Name = "frmBolumler";
            this.Text = "frmBolumler";
            this.Load += new System.EventHandler(this.frmBolumler_Load);
            this.scPanel.Panel1.ResumeLayout(false);
            this.scPanel.Panel1.PerformLayout();
            this.scPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scPanel)).EndInit();
            this.scPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scPanel;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolumAdi;
    }
}