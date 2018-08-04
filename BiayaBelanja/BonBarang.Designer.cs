namespace BiayaBelanja
{
    partial class BonBarang
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
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lvBarang = new System.Windows.Forms.ListView();
            this.tbTotalHarga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Harga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pajak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.AutoSize = true;
            this.lblTotalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHarga.Location = new System.Drawing.Point(245, 627);
            this.lblTotalHarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(186, 37);
            this.lblTotalHarga.TabIndex = 0;
            this.lblTotalHarga.Text = "Total Harga";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(516, 708);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 58);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lvBarang
            // 
            this.lvBarang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvBarang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nama,
            this.Harga,
            this.Pajak,
            this.Qty});
            this.lvBarang.Location = new System.Drawing.Point(1, 147);
            this.lvBarang.Name = "lvBarang";
            this.lvBarang.Size = new System.Drawing.Size(690, 440);
            this.lvBarang.TabIndex = 2;
            this.lvBarang.UseCompatibleStateImageBehavior = false;
            this.lvBarang.View = System.Windows.Forms.View.Details;
            // 
            // tbTotalHarga
            // 
            this.tbTotalHarga.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbTotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTotalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalHarga.Location = new System.Drawing.Point(473, 627);
            this.tbTotalHarga.Name = "tbTotalHarga";
            this.tbTotalHarga.Size = new System.Drawing.Size(168, 37);
            this.tbTotalHarga.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bon Pembayaran";
            // 
            // Nama
            // 
            this.Nama.Text = "Nama";
            this.Nama.Width = 120;
            // 
            // Harga
            // 
            this.Harga.Text = "Harga";
            this.Harga.Width = 85;
            // 
            // Pajak
            // 
            this.Pajak.Text = "Pajak";
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.Width = 50;
            // 
            // BonBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 793);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTotalHarga);
            this.Controls.Add(this.lvBarang);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTotalHarga);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BonBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BonBarang";
            this.Load += new System.EventHandler(this.BonBarang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListView lvBarang;
        private System.Windows.Forms.TextBox tbTotalHarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Nama;
        private System.Windows.Forms.ColumnHeader Harga;
        private System.Windows.Forms.ColumnHeader Pajak;
        private System.Windows.Forms.ColumnHeader Qty;
    }
}