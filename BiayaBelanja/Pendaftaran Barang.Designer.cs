namespace BiayaBelanja
{
    partial class FrmPerhitunganBiaya
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
            this.btnBelanja = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.192F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1042, 74);
            this.label3.TabIndex = 2;
            this.label3.Text = "PERHITUNGAN BIAYA BELANJA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(455, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Input Harga Barang Baru";
            // 
            // tbNamaBrgBaru
            // 
            this.tbNamaBrgBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaBrgBaru.Location = new System.Drawing.Point(346, 220);
            this.tbNamaBrgBaru.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNamaBrgBaru.Name = "tbNamaBrgBaru";
            this.tbNamaBrgBaru.Size = new System.Drawing.Size(334, 49);
            this.tbNamaBrgBaru.TabIndex = 4;
            // 
            // tbHargaBrgBaru
            // 
            this.tbHargaBrgBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHargaBrgBaru.Location = new System.Drawing.Point(346, 306);
            this.tbHargaBrgBaru.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHargaBrgBaru.Name = "tbHargaBrgBaru";
            this.tbHargaBrgBaru.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbHargaBrgBaru.Size = new System.Drawing.Size(334, 49);
            this.tbHargaBrgBaru.TabIndex = 5;
            this.tbHargaBrgBaru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHargaBrgBaru_KeyPress);
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.SystemColors.Window;
            this.btnDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftar.Location = new System.Drawing.Point(346, 488);
            this.btnDaftar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(214, 73);
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
            this.btnBatal.Location = new System.Drawing.Point(958, 647);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(214, 73);
            this.btnBatal.TabIndex = 7;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Blue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEdit.Location = new System.Drawing.Point(699, 647);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(214, 73);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // tbPajakBrg
            // 
            this.tbPajakBrg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbPajakBrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPajakBrg.Location = new System.Drawing.Point(346, 398);
            this.tbPajakBrg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPajakBrg.Name = "tbPajakBrg";
            this.tbPajakBrg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPajakBrg.Size = new System.Drawing.Size(334, 49);
            this.tbPajakBrg.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 403);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 42);
            this.label6.TabIndex = 17;
            this.label6.Text = "Pajak / Barang";
            // 
            // btnBelanja
            // 
            this.btnBelanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBelanja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBelanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBelanja.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBelanja.Location = new System.Drawing.Point(410, 647);
            this.btnBelanja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBelanja.Name = "btnBelanja";
            this.btnBelanja.Size = new System.Drawing.Size(243, 73);
            this.btnBelanja.TabIndex = 19;
            this.btnBelanja.Text = "BELANJA";
            this.btnBelanja.UseVisualStyleBackColor = false;
            this.btnBelanja.Click += new System.EventHandler(this.btnBelanja_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(687, 403);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 42);
            this.label5.TabIndex = 20;
            this.label5.Text = "%";
            // 
            // FrmPerhitunganBiaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 758);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBelanja);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPerhitunganBiaya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APLIKASI PERHITUNGAN BIAYA BELANJA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button btnBelanja;
        private System.Windows.Forms.Label label5;
    }
}

