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
    
    public partial class FrmEditBarang : Form   
    {
        
        BarangDAO dao = new BarangDAO(Setting.GetConnectionString());

        public FrmEditBarang()
        {
            InitializeComponent();
            this.dgvData.AutoGenerateColumns = false;
        }

        private void FrmEditBarang_Load(object sender, EventArgs e)
        {
            this.dgvData.DataSource = dao.GetAllDataBarang();
            dgvData.Columns[0].DataPropertyName = "KodeBarang";
            dgvData.Columns[1].DataPropertyName = "NamaBarang";
            dgvData.Columns[2].DataPropertyName = "HargaBarang";
            dgvData.Columns[3].DataPropertyName = "PajakBarang";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (this.dgvData.SelectedRows.Count > 0 && MessageBox.Show("Hapus Item Data Terpilih ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var dao = new BarangDAO(Setting.GetConnectionString()))
                    {
                        if (dao.DeleteBarang(this.dgvData.SelectedRows[0].Cells[0].Value.ToString().Trim()) > 0)
                        {
                            FrmEditBarang_Load(null, null);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void FrmEditBarang_Resize(object sender, EventArgs e)
        {
            this.dgvData.Columns[0].Width = 15 * this.dgvData.Width / 100;
            this.dgvData.Columns[1].Width = 40 * this.dgvData.Width / 100;
            this.dgvData.Columns[2].Width = 25 * this.dgvData.Width / 100;
            this.dgvData.Columns[3].Width = 20 * this.dgvData.Width / 100;
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tbNama.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
            this.tbHarga.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
            this.tbPajakBrg.Text = dgvData.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Barang baru = new Barang
            {
                KodeBarang = dgvData.CurrentRow.Cells[0].Value.ToString(),
                NamaBarang = this.tbNama.Text,
                HargaBarang = this.tbHarga.Text,
                PajakBarang = this.tbPajakBrg.Text
            };
            dao.Update(baru);
            this.dgvData.DataSource = null;
            this.dgvData.DataSource = dao.GetAllDataBarang();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPendaftaranBarang daftar = new FrmPendaftaranBarang();
            daftar.ShowDialog();
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
