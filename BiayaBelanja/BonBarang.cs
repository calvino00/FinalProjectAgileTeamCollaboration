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
    public partial class BonBarang : Form
    {
        List<BarangPenjualan> barang;
        string TotalHarga;
        public BonBarang()
        {
            InitializeComponent();
        }
        public BonBarang(List<BarangPenjualan> _barang, string Harga)
        {
            InitializeComponent();
            barang = _barang;
            TotalHarga = Harga;
        }

        private void BonBarang_Load(object sender, EventArgs e)
        {

            foreach (var jenis in barang)
            {
                ListViewItem item = new ListViewItem(jenis.NamaBarang);
                item.SubItems.Add(jenis.HargaBarang.ToString());
                item.SubItems.Add($"{jenis.PajakBarang.ToString()}%");
                item.SubItems.Add(jenis.Quantity.ToString());
                lvBarang.Items.Add(item);
            }
            tbTotalHarga.Text = TotalHarga;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
