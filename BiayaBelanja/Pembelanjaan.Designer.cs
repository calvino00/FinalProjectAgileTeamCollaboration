namespace BiayaBelanja
{
    partial class FrmPembelanjaan
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnKonfirmasi = new System.Windows.Forms.Button();
            this.tbPajakTransaksi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotalHarga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvBarang = new System.Windows.Forms.ListView();
            this.tbNamaBrg = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.Nama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Harga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pajak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 42);
            this.label4.TabIndex = 5;
            this.label4.Text = "Input Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.192F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(860, 74);
            this.label3.TabIndex = 4;
            this.label3.Text = "PEMBELANJAAN BARANG";
            // 
            // tbHarga
            // 
            this.tbHarga.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHarga.Location = new System.Drawing.Point(294, 325);
            this.tbHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.ReadOnly = true;
            this.tbHarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbHarga.Size = new System.Drawing.Size(334, 49);
            this.tbHarga.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Harga";
            // 
            // tbQty
            // 
            this.tbQty.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQty.Location = new System.Drawing.Point(294, 417);
            this.tbQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(334, 49);
            this.tbQty.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 422);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quantity";
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubTotal.Location = new System.Drawing.Point(1071, 789);
            this.tbSubTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSubTotal.Size = new System.Drawing.Size(334, 49);
            this.tbSubTotal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(704, 794);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 42);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sub Total";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Red;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBatal.Location = new System.Drawing.Point(1192, 1052);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(214, 73);
            this.btnBatal.TabIndex = 14;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnKonfirmasi
            // 
            this.btnKonfirmasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKonfirmasi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKonfirmasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKonfirmasi.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKonfirmasi.Location = new System.Drawing.Point(864, 1052);
            this.btnKonfirmasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKonfirmasi.Name = "btnKonfirmasi";
            this.btnKonfirmasi.Size = new System.Drawing.Size(303, 73);
            this.btnKonfirmasi.TabIndex = 13;
            this.btnKonfirmasi.Text = "KONFIRMASI";
            this.btnKonfirmasi.UseVisualStyleBackColor = false;
            // 
            // tbPajakTransaksi
            // 
            this.tbPajakTransaksi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbPajakTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPajakTransaksi.Location = new System.Drawing.Point(1071, 698);
            this.tbPajakTransaksi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPajakTransaksi.Name = "tbPajakTransaksi";
            this.tbPajakTransaksi.ReadOnly = true;
            this.tbPajakTransaksi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPajakTransaksi.Size = new System.Drawing.Size(334, 49);
            this.tbPajakTransaksi.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(704, 703);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 42);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pajak / Transaksi";
            // 
            // tbTotalHarga
            // 
            this.tbTotalHarga.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbTotalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalHarga.Location = new System.Drawing.Point(1071, 875);
            this.tbTotalHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTotalHarga.Name = "tbTotalHarga";
            this.tbTotalHarga.ReadOnly = true;
            this.tbTotalHarga.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTotalHarga.Size = new System.Drawing.Size(334, 49);
            this.tbTotalHarga.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(704, 880);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 42);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total Harga";
            // 
            // lvBarang
            // 
            this.lvBarang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nama,
            this.Harga,
            this.Pajak,
            this.Qty});
            this.lvBarang.Location = new System.Drawing.Point(711, 233);
            this.lvBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvBarang.Name = "lvBarang";
            this.lvBarang.Size = new System.Drawing.Size(694, 424);
            this.lvBarang.TabIndex = 19;
            this.lvBarang.UseCompatibleStateImageBehavior = false;
            this.lvBarang.View = System.Windows.Forms.View.Details;
            // 
            // tbNamaBrg
            // 
            this.tbNamaBrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaBrg.Location = new System.Drawing.Point(38, 233);
            this.tbNamaBrg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNamaBrg.Name = "tbNamaBrg";
            this.tbNamaBrg.Size = new System.Drawing.Size(590, 49);
            this.tbNamaBrg.TabIndex = 20;
            this.tbNamaBrg.Leave += new System.EventHandler(this.tbNamaBrg_Leave);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Window;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(168, 530);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(284, 73);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Blue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEdit.Location = new System.Drawing.Point(38, 1052);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(214, 73);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.Color.Yellow;
            this.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftar.Location = new System.Drawing.Point(294, 1056);
            this.btnDaftar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(214, 73);
            this.btnDaftar.TabIndex = 22;
            this.btnDaftar.Text = "DAFTAR";
            this.btnDaftar.UseVisualStyleBackColor = false;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // Nama
            // 
            this.Nama.Text = "Nama";
            this.Nama.Width = 100;
            // 
            // Harga
            // 
            this.Harga.Text = "Harga";
            this.Harga.Width = 50;
            // 
            // Pajak
            // 
            this.Pajak.Text = "Pajak";
            this.Pajak.Width = 50;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.Width = 50;
            // 
            // FrmPembelanjaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 1148);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbNamaBrg);
            this.Controls.Add(this.lvBarang);
            this.Controls.Add(this.tbTotalHarga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPajakTransaksi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnKonfirmasi);
            this.Controls.Add(this.tbSubTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPembelanjaan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEMBELANJAAN BARANG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnKonfirmasi;
        private System.Windows.Forms.TextBox tbPajakTransaksi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTotalHarga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvBarang;
        private System.Windows.Forms.TextBox tbNamaBrg;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.ColumnHeader Nama;
        private System.Windows.Forms.ColumnHeader Harga;
        private System.Windows.Forms.ColumnHeader Pajak;
        private System.Windows.Forms.ColumnHeader Qty;
    }
}