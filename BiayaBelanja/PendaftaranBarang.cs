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

        }
    }
}
