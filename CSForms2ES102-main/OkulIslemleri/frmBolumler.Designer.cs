
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
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTamSil = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbPassive = new System.Windows.Forms.RadioButton();
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
            this.scPanel.Panel1.Controls.Add(this.rbPassive);
            this.scPanel.Panel1.Controls.Add(this.rbActive);
            this.scPanel.Panel1.Controls.Add(this.rbHepsi);
            this.scPanel.Panel1.Controls.Add(this.btnTamSil);
            this.scPanel.Panel1.Controls.Add(this.btnSil);
            this.scPanel.Panel1.Controls.Add(this.btnKayit);
            this.scPanel.Panel1.Controls.Add(this.txtBolumAdi);
            this.scPanel.Panel1.Controls.Add(this.label1);
            // 
            // scPanel.Panel2
            // 
            this.scPanel.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.scPanel.Panel2.Controls.Add(this.liste);
            this.scPanel.Size = new System.Drawing.Size(618, 477);
            this.scPanel.SplitterDistance = 186;
            this.scPanel.TabIndex = 0;
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
            // txtBolumAdi
            // 
            this.txtBolumAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBolumAdi.Location = new System.Drawing.Point(0, 23);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(614, 20);
            this.txtBolumAdi.TabIndex = 1;
            this.txtBolumAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm Adı Giriş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BolumAdi,
            this.IsActive});
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.MultiSelect = false;
            this.liste.Name = "liste";
            this.liste.ReadOnly = true;
            this.liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.liste.Size = new System.Drawing.Size(614, 283);
            this.liste.TabIndex = 0;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(50, 58);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTamSil
            // 
            this.btnTamSil.Location = new System.Drawing.Point(168, 57);
            this.btnTamSil.Name = "btnTamSil";
            this.btnTamSil.Size = new System.Drawing.Size(75, 23);
            this.btnTamSil.TabIndex = 4;
            this.btnTamSil.Text = "Tam Sil";
            this.btnTamSil.UseVisualStyleBackColor = true;
            this.btnTamSil.Click += new System.EventHandler(this.btnTamSil_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Sıra No";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 67;
            // 
            // BolumAdi
            // 
            this.BolumAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BolumAdi.HeaderText = "Bölüm Adı";
            this.BolumAdi.Name = "BolumAdi";
            this.BolumAdi.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Durum";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rbHepsi
            // 
            this.rbHepsi.AutoSize = true;
            this.rbHepsi.Checked = true;
            this.rbHepsi.Location = new System.Drawing.Point(313, 57);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(52, 17);
            this.rbHepsi.TabIndex = 1;
            this.rbHepsi.TabStop = true;
            this.rbHepsi.Text = "Hepsi";
            this.rbHepsi.UseVisualStyleBackColor = true;
            this.rbHepsi.CheckedChanged += new System.EventHandler(this.rbHepsi_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(313, 80);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(46, 17);
            this.rbActive.TabIndex = 5;
            this.rbActive.Text = "Aktif";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // rbPassive
            // 
            this.rbPassive.AutoSize = true;
            this.rbPassive.Location = new System.Drawing.Point(313, 103);
            this.rbPassive.Name = "rbPassive";
            this.rbPassive.Size = new System.Drawing.Size(48, 17);
            this.rbPassive.TabIndex = 6;
            this.rbPassive.Text = "Pasif";
            this.rbPassive.UseVisualStyleBackColor = true;
            this.rbPassive.CheckedChanged += new System.EventHandler(this.rbPassive_CheckedChanged);
            // 
            // frmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 477);
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
        private System.Windows.Forms.Button btnTamSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolumAdi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.RadioButton rbPassive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RadioButton rbHepsi;
    }
}