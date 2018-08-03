namespace BiayaBelanja
{
    partial class FrmPendaftaranBarang
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbNamaBrgBaru = new System.Windows.Forms.TextBox();
            this.tbHargaBrgBaru = new System.Windows.Forms.TextBox();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbPajakBrg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.192F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(667, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "PERHITUNGAN BIAYA BELANJA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Input Harga Barang Baru";
            // 
            // tbNamaBrgBaru
            // 
            this.tbNamaBrgBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaBrgBaru.Location = new System.Drawing.Point(231, 141);
            this.tbNamaBrgBaru.Name = "tbNamaBrgBaru";
            this.tbNamaBrgBaru.Size = new System.Drawing.Size(224, 34);
            this.tbNamaBrgBaru.TabIndex = 4;
            // 
            // tbHargaBrgBaru
            // 
            this.tbHargaBrgBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHargaBrgBaru.Location = new System.Drawing.Point(231, 196);
            this.tbHargaBrgBaru.Name = "tbHargaBrgBaru";
            this.tbHargaBrgBaru.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbHargaBrgBaru.Size = new System.Drawing.Size(224, 34);
            this.tbHargaBrgBaru.TabIndex = 5;
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.SystemColors.Window;
            this.btnDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftar.Location = new System.Drawing.Point(294, 414);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(143, 47);
            this.btnDaftar.TabIndex = 6;
            this.btnDaftar.Text = "DAFTAR";
            this.btnDaftar.UseVisualStyleBackColor = false;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Red;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBatal.Location = new System.Drawing.Point(639, 414);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(143, 47);
            this.btnBatal.TabIndex = 7;
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
            this.btnEdit.Location = new System.Drawing.Point(466, 414);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(143, 47);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbPajakBrg
            // 
            this.tbPajakBrg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbPajakBrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPajakBrg.Location = new System.Drawing.Point(231, 255);
            this.tbPajakBrg.Name = "tbPajakBrg";
            this.tbPajakBrg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPajakBrg.Size = new System.Drawing.Size(224, 34);
            this.tbPajakBrg.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Pajak / Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "%";
            // 
            // FrmPendaftaranBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPajakBrg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.tbHargaBrgBaru);
            this.Controls.Add(this.tbNamaBrgBaru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPendaftaranBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APLIKASI PERHITUNGAN BIAYA BELANJA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNamaBrgBaru;
        private System.Windows.Forms.TextBox tbHargaBrgBaru;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbPajakBrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

