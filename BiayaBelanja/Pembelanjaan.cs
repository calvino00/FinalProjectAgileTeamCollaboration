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
    public partial class FrmPembelanjaan : Form
    {
        List<BarangPenjualan> listData = null;
        int hasil = 0;

        public FrmPembelanjaan()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEditBarang FrmEdit = new FrmEditBarang();
            FrmEdit.ShowDialog();
            this.Show();
            
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPendaftaranBarang daftar = new FrmPendaftaranBarang();
            daftar.ShowDialog();
            this.Show();
        }

        Barang result = null;
        private void btnOK_Click(object sender, EventArgs e)
        {
            listData = new List<BarangPenjualan>();
            listData.Add(
                new BarangPenjualan
                {
                    NamaBarang = this.tbNamaBrg.Text,
                    HargaBarang = this.tbHarga.Text,
                    PajakBarang = result.PajakBarang,
                    Quantity = this.tbQty.Text
                }
                );

            string hasilpajak = (Convert.ToInt32(this.tbHarga.Text) * (Convert.ToInt32(result.PajakBarang)) * Convert.ToInt32(this.tbQty.Text) / 100).ToString();
            string hasilharga = (Convert.ToInt32(this.tbHarga.Text) * Convert.ToInt32(this.tbQty.Text)).ToString();
            string hasill = (hasil + Convert.ToInt32(hasilpajak) + Convert.ToInt32(hasilharga)).ToString();
            hasil = Convert.ToInt32(hasill);
            tbTotalHarga.Text = (Convert.ToInt32(hasil)).ToString();
            foreach (var jenis in listData)
            {
                ListViewItem item = new ListViewItem(jenis.NamaBarang);
                item.SubItems.Add(jenis.HargaBarang.ToString());
                item.SubItems.Add($"{jenis.PajakBarang.ToString()}%");
                item.SubItems.Add(jenis.Quantity.ToString());
                lvBarang.Items.Add(item);
            }
            this.tbNamaBrg.Text = this.tbHarga.Text = this.tbQty.Text = null;

        }

        private void tbNamaBrg_Leave(object sender, EventArgs e)
        {
            if (tbNamaBrg.Text.Trim().Equals(""))
            {
                this.tbNamaBrg.Focus();
            }
            else
            {
                BarangDAO dao = new BarangDAO(Setting.GetConnectionString());
                result = dao.GetNamaBarang(tbNamaBrg.Text);
                if (result == null)
                {

                    MessageBox.Show("Maaf, Barang tidak ditemukan", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tbNamaBrg.Text = null;
                    this.tbNamaBrg.Focus();
                }
                else
                {
                    this.tbHarga.Text = result.HargaBarang;
                }
            }
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
        }

        private void tbSubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
