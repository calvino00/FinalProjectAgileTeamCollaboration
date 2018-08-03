namespace BiayaBelanja
{
    partial class FrmEditBarang
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Kode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pajak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHapus = new System.Windows.Forms.Button();
            this.tbPajakBrg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDaftar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.192F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 47);
            this.label3.TabIndex = 5;
            this.label3.Text = "PENGEDITAN BARANG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edit Barang yang Sudah Terdaftar";
            // 
            // tbHarga
            // 
            this.tbHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHarga.Location = new System.Drawing.Point(237, 533);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbHarga.Size = new System.Drawing.Size(224, 34);
            this.tbHarga.TabIndex = 12;
            // 
            // tbNama
            // 
            this.tbNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(237, 478);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(224, 34);
            this.tbNama.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Harga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nama";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Red;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBatal.Location = new System.Drawing.Point(573, 692);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(143, 47);
            this.btnBatal.TabIndex = 13;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Blue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEdit.Location = new System.Drawing.Point(573, 535);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(143, 47);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kode,
            this.Nama,
            this.Harga,
            this.Pajak});
            this.dgvData.Location = new System.Drawing.Point(17, 134);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(763, 318);
            this.dgvData.TabIndex = 15;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // Kode
            // 
            this.Kode.HeaderText = "Kode Barang";
            this.Kode.Name = "Kode";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama Barang";
            this.Nama.Name = "Nama";
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga Barang";
            this.Harga.Name = "Harga";
            // 
            // Pajak
            // 
            this.Pajak.HeaderText = "Pajak Barang";
            this.Pajak.Name = "Pajak";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.Window;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(573, 478);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(143, 47);
            this.btnHapus.TabIndex = 16;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // tbPajakBrg
            // 
            this.tbPajakBrg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbPajakBrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPajakBrg.Location = new System.Drawing.Point(237, 591);
            this.tbPajakBrg.Name = "tbPajakBrg";
            this.tbPajakBrg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPajakBrg.Size = new System.Drawing.Size(224, 34);
            this.tbPajakBrg.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 594);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Pajak / Barang";
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.Color.Yellow;
            this.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftar.Location = new System.Drawing.Point(391, 692);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(143, 47);
            this.btnDaftar.TabIndex = 23;
            this.btnDaftar.Text = "DAFTAR";
            this.btnDaftar.UseVisualStyleBackColor = false;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // FrmEditBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 793);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.tbPajakBrg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FrmEditBarang";
            this.Text = "PENGEDITAN BARANG";
            this.Load += new System.EventHandler(this.FrmEditBarang_Load);
            this.Resize += new System.EventHandler(this.FrmEditBarang_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox tbPajakBrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pajak;
        private System.Windows.Forms.Button btnDaftar;
    }
}