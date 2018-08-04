using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BelanjaLibrary;

namespace BiayaBelanja
{
    public partial class FrmPendaftaranBarang : Form

    {

        FrmPembelanjaan belanja = new FrmPembelanjaan();
        BarangDAO dao = new BarangDAO(Setting.GetConnectionString());
        public FrmPendaftaranBarang()
        {
            InitializeComponent();
        }



        private void btnBelanja_Click(object sender, EventArgs e)
        {

        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            Barang barang = null;
            if (this.tbNamaBrgBaru.Text.Trim() == "")//jika isian nama kosong
            {
                MessageBox.Show("Sorry , nama barang wajib isi ...");
                this.tbNamaBrgBaru.Focus();
            }
            else if (this.tbHargaBrgBaru.Text.Trim() == "")
            {
                MessageBox.Show("Sorry , harga barang wajib isi ...");
                this.tbHargaBrgBaru.Focus();
            }
            else if (this.tbPajakBrg.Text.Trim() == "")
            {
                MessageBox.Show("Sorry , pajak barang wajib isi ...");
                this.tbPajakBrg.Focus();
            }

            else
            {
                barang = new Barang();
                barang.KodeBarang = dao.GetKodeBarangBerikutnya();
                barang.NamaBarang = this.tbNamaBrgBaru.Text;
                barang.HargaBarang = this.tbHargaBrgBaru.Text;
                barang.PajakBarang = this.tbPajakBrg.Text;
                dao.Insert(barang);
                this.tbHargaBrgBaru.Text = this.tbNamaBrgBaru.Text = this.tbPajakBrg.Text = null;
                this.Close();

            }

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEditBarang edit = new FrmEditBarang();
            edit.ShowDialog();
            this.Close();
        }

        private void tbNamaBrgBaru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (' '))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbHargaBrgBaru_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.tbHargaBrgBaru.Text) <= 0)
            {
                MessageBox.Show("Input angka yang benar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbHargaBrgBaru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {   

                e.Handled = true;
            }
        }

        private void tbPajakBrg_TextChanged(object sender, EventArgs e)
        {
            decimal temp = 0;
            if (this.tbPajakBrg.Text != "")
            {
                temp = Convert.ToDecimal(this.tbPajakBrg.Text);
                if (temp >= 100)
                {
                    this.tbPajakBrg.Text = Convert.ToDecimal(100).ToString("n0");
                }
                else
                {
                    this.tbPajakBrg.Text = temp.ToString("n0");
                }
                this.tbPajakBrg.SelectionStart = this.tbPajakBrg.Text.Length;
            }
            else
            {
               tbPajakBrg.Text = "0";
            }
        }

        private void tbPajakBrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back )
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }
    }
}
