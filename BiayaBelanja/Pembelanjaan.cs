using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiayaBelanja
{
    public partial class FrmPembelanjaan : Form
    {
        FrmPendaftaranBarang daftar = new FrmPendaftaranBarang();
        FrmEditBarang FrmEdit = new FrmEditBarang();
        public FrmPembelanjaan()
        {
            InitializeComponent();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEdit.ShowDialog();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            daftar.ShowDialog();
        }
    }
}
